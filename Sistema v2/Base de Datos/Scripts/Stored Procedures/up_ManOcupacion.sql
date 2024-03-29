USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ManOcupacion]    Script Date: 09/06/2013 13:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_ManOcupacion]
(
	@IdOcupacion	INT,
	@Nombre			VARCHAR(50),
	@Descripcion	VARCHAR(500),
	@Estado			VARCHAR(8),
	@Accion			INT,
	@IdGenerado		INT	OUTPUT --0:INSERT, 1:UPDATE, 2:DELETE, 3:RECOVER, 4:SELECT, 5:SELECTALL, 6:SELECT CUSTOM
)
AS
BEGIN
  BEGIN TRANSACTION
    IF @Accion = 0
    BEGIN
		INSERT INTO Ocupacion(Nombre, Descripcion, Estado)
		VALUES (@Nombre, @Descripcion, 'ACTIVO')
		
		SET @IdGenerado = SCOPE_IDENTITY()
    END
    
    IF @Accion = 1
    BEGIN
		UPDATE Ocupacion SET Nombre = @Nombre, Descripcion = @Descripcion
		WHERE IdOcupacion = @IdOcupacion
							
		SET @IdGenerado = 1
    END
    IF @Accion = 2
    BEGIN
		UPDATE Ocupacion SET Estado = 'INACTIVO'
		WHERE IdOcupacion = @IdOcupacion
		
		SET @IdGenerado = 1
    END
    IF @Accion = 3
    BEGIN
		UPDATE Ocupacion SET Estado = 'ACTIVO'
		WHERE IdOcupacion = @IdOcupacion
		
		SET @IdGenerado = 1
    END
    IF @Accion = 4
    BEGIN
		SELECT IdOcupacion, Nombre, Descripcion, Estado 
		FROM Ocupacion
		WHERE IdOcupacion = @IdOcupacion
		ORDER BY Nombre
	END
    IF @Accion = 5
    BEGIN
		SELECT IdOcupacion, Nombre, Descripcion, Estado 
		FROM Ocupacion
		ORDER BY Nombre
	END
	IF @Accion = 6
	BEGIN
		DECLARE @Query VARCHAR(1000)
		SET @Query = 'SELECT IdOcupacion, Nombre, Descripcion, Estado FROM Ocupacion WHERE IdOcupacion > 0'
		
		IF @Nombre <> ''
		BEGIN
			SET @Query = @Query + ' AND Nombre LIKE ''%' + @Nombre + '%'''
		END
		
		IF @Estado <> 'TODOS'
		BEGIN
			SET @Query = @Query + ' AND Estado = ''' + @Estado + ''''
		END	
		
		SET @Query = @Query + ' ORDER BY Nombre'	
						
		EXEC(@Query)
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