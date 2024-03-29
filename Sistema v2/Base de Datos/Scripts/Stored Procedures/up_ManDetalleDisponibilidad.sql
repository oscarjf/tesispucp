USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ManDetalleDisponibilidad]    Script Date: 09/06/2013 13:01:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_ManDetalleDisponibilidad]
(
	@IdDisponibilidadDoctor		INT,
	@FechaElegida				DATE,
	@DetalleXML					XML,
	@ListaEliminados			VARCHAR(2000),
	@Accion						INT, --0:INSERT, 4:SELECT
	@IdGenerado					INT	OUTPUT 
)
AS
BEGIN
  BEGIN TRANSACTION
    IF @Accion = 0
    BEGIN
		--SI EXISTEN DISPONIBILIDADES A ELIMINAR, RECORREMOS LA LISTA PARA ELIMINARLOS
		IF @ListaEliminados <> ''
		BEGIN
			DECLARE @item INT
			DECLARE cur CURSOR FOR 
			(
			   SELECT Item FROM fn_Split(@ListaEliminados, ',') 
			)

			OPEN cur
			FETCH NEXT FROM cur INTO @item

			WHILE @@FETCH_STATUS = 0 
			BEGIN
				--INSERT INTO EspecialidadesxDoctor(IdEspecialidad, IdDoctor)
				--VALUES (CONVERT(INT, @item), @IdDoctor)
				DELETE FROM DetalleDisponibilidad
				WHERE IdDisponibilidad = @IdDisponibilidadDoctor AND
					  IdDetalleDisponibilidad = @item
				
				FETCH NEXT FROM cur INTO @item
			END

			CLOSE cur
			DEALLOCATE cur
		END
		
		-- RECORREMOS EL ARCHIVO XML E INSERTAMOS EN LA TABLA 'DetalleDisponibilidad'
		DECLARE @IdDetalleDisponibilidad INT, @IdDisponibilidad INT, @Fecha DATE, @HoraInicio DATETIME, @HoraFin DATETIME
		DECLARE cur CURSOR FOR 
		(
			SELECT
			  R.x.value('(_IdDetalleDisponibilidad/text())[1]', 'int') AS IdDetalleDisponibilidad,
			  R.x.value('(_IdDisponibilidad/text())[1]', 'int') AS IdDisponibilidad,
			  R.x.value('(_Fecha/text())[1]', 'date') AS Fecha,
			  R.x.value('(_HoraInicio/text())[1]', 'datetime') AS HoraInicio,
			  R.x.value('(_HoraFin/text())[1]', 'datetime') AS HoraFin
			FROM
			  @DetalleXML.nodes('/ArrayOfClsDetalleDisponibilidad[1]') AS P(x)
			  CROSS APPLY
			  P.x.nodes('clsDetalleDisponibilidad') AS R(x)
		)  

		OPEN cur
		FETCH NEXT FROM cur INTO @IdDetalleDisponibilidad, @IdDisponibilidad, @Fecha, @HoraInicio, @HoraFin

		WHILE @@FETCH_STATUS = 0 
		BEGIN
			INSERT INTO DetalleDisponibilidad (IdDisponibilidad, Fecha, HoraInicio, HoraFin)
			VALUES (@IdDisponibilidad, @Fecha, @HoraInicio, @HoraFin)
			
			FETCH NEXT FROM cur INTO @IdDetalleDisponibilidad, @IdDisponibilidad, @Fecha, @HoraInicio, @HoraFin
		END

		CLOSE cur
		DEALLOCATE cur
		
		SET @IdGenerado = 1
    END
    
    IF @Accion = 4
    BEGIN
		SELECT IdDetalleDisponibilidad, IdDisponibilidad, Fecha, HoraInicio, HoraFin 
		FROM DetalleDisponibilidad
		WHERE YEAR(Fecha) = YEAR(@FechaElegida) AND --MONTH(Fecha) = MONTH(@FechaElegida) AND
			  IdDisponibilidad = @IdDisponibilidadDoctor
	END
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
    
    SET @IdGenerado = 0
	
	RETURN @IdGenerado
  END
  
  COMMIT TRANSACTION
  
  RETURN @IdGenerado
END