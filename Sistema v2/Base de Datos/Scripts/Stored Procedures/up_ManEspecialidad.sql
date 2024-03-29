USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ManEspecialidad]    Script Date: 09/06/2013 13:02:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--EXEC up_ManEspecialidad 0,'','',1,'TODOS',6,''
ALTER PROCEDURE [dbo].[up_ManEspecialidad]
(
	@IdEspecialidad		INT,
	@Nombre				VARCHAR(50),
	@Descripcion		VARCHAR(500),
	@IdArea				INT,
	@Estado				VARCHAR(8),
	@Accion				INT,
	@IdGenerado			INT	OUTPUT --0:INSERT, 1:UPDATE, 2:DELETE, 3:RECOVER, 4:SELECT, 5:SELECTALL, 6:SELECT CUSTOM
)
AS
BEGIN
  BEGIN TRANSACTION
    IF @Accion = 0
    BEGIN
		INSERT INTO Especialidad(Nombre, Descripcion, IdArea, Estado)
		VALUES (@Nombre, @Descripcion, @IdArea, 'ACTIVO')
		
		SET @IdGenerado = SCOPE_IDENTITY()
    END
    
    IF @Accion = 1
    BEGIN
		UPDATE Especialidad SET Nombre = @Nombre, Descripcion = @Descripcion, IdArea = @IdArea
		WHERE IdEspecialidad = @IdEspecialidad
							
		SET @IdGenerado = 1
    END
    IF @Accion = 2
    BEGIN
		UPDATE Especialidad SET Estado = 'INACTIVO'
		WHERE IdEspecialidad = @IdEspecialidad
		
		SET @IdGenerado = 1
    END
    IF @Accion = 3
    BEGIN
		UPDATE Especialidad SET Estado = 'ACTIVO'
		WHERE IdEspecialidad = @IdEspecialidad
		
		SET @IdGenerado = 1
    END
    IF @Accion = 4
    BEGIN
		SELECT E.IdEspecialidad, E.Nombre, E.Descripcion, E.IdArea, A.Nombre AS Area, E.Estado 
		FROM Especialidad E, Area A
		WHERE E.IdArea = A.IdArea AND E.IdEspecialidad = @IdEspecialidad
		ORDER BY E.Nombre
	END
    IF @Accion = 5
    BEGIN
		SELECT E.IdEspecialidad, E.Nombre, E.Descripcion, E.IdArea, A.Nombre AS Area, E.Estado 
		FROM Especialidad E, Area A
		WHERE E.IdArea = A.IdArea
		ORDER BY E.Nombre
	END
	IF @Accion = 6
	BEGIN
		DECLARE @Query VARCHAR(1000)
		SET @Query = 'SELECT E.IdEspecialidad, E.Nombre, E.Descripcion, E.IdArea, A.Nombre AS Area, E.Estado FROM Especialidad E, Area A WHERE E.IdArea = A.IdArea'
		
		IF @Nombre <> ''
		BEGIN
			SET @Query = @Query + ' AND E.Nombre LIKE ''%' + @Nombre + '%'''
		END
		
		IF @IdArea <> 0
		BEGIN
			SET @Query = @Query  + ' AND A.IdArea = ' + CONVERT(VARCHAR(2), @IdArea) + ''
		END
		
		IF @Estado <> 'TODOS'
		BEGIN
			SET @Query = @Query + ' AND E.Estado = ''' + @Estado + ''''
		END	
		
		SET @Query = @Query + ' ORDER BY E.Nombre'	
						
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