CREATE PROCEDURE up_SelEspecialidad(
@idEspecialidad			INT,
@nombre					VARCHAR(30),
@estado					VARCHAR(8),
@accion					INT --4: Seleccionar 1, 5: Seleccionar Todos, 6: Seleccionar por Criterios
)
AS
BEGIN
    IF @accion = 4
    BEGIN
		SELECT Id_Especialidad, Nombre, Descripcion, Estado 
		FROM Especialidad
		WHERE Id_Especialidad = @idEspecialidad
	END
    
    IF @accion = 5
    BEGIN
		SELECT Id_Especialidad, Nombre, Descripcion, Estado 
		FROM Especialidad
	END
    
    IF @accion = 6
    BEGIN
		DECLARE @query VARCHAR(1000)
		SET @query = 'SELECT Id_Especialidad, Nombre, Descripcion, Estado FROM Especialidad WHERE Id_Especialidad > 0 '
		
		IF @nombre <> ''
		BEGIN
			SET @query = @query + 'AND Nombre LIKE ''%' + @nombre + '%'''
		END
		
		IF @estado <> 'TODOS'
		BEGIN
			SET @query = @query + 'AND Estado = ''' + @estado + ''''
		END
		
		EXEC(@query)
	END
END