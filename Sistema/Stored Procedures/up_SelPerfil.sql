CREATE PROCEDURE up_SelPerfil (
@idPerfil		INT,
@nombre			VARCHAR(30),
@tipoPersonal	VARCHAR(14),
@estado			VARCHAR(8),
@accion			INT --4: Seleccionar 1, 5: Seleccionar Todos, 6: Seleccionar por Criterios
)
AS
BEGIN
    IF @accion = 4
    BEGIN
		SELECT Id_Perfil, Nombre, TipoPersonal, Estado 
		FROM Perfil
		WHERE Id_Perfil = @idPerfil
	END
    
    IF @accion = 5
    BEGIN
		SELECT Id_Perfil, Nombre, TipoPersonal, Estado 
		FROM Perfil
	END
    
    IF @accion = 6
    BEGIN
		DECLARE @query VARCHAR(1000)
		SET @query = 'SELECT Id_Perfil, Nombre, TipoPersonal, Estado FROM Perfil WHERE Id_Perfil > 0 '
		
		IF @nombre <> ''
		BEGIN
			SET @query = @query + 'AND Nombre LIKE ''%' + @nombre + '%'''
		END
		
		IF @tipoPersonal <> 'TODOS'
		BEGIN
			SET @query = @query + 'AND TipoPersonal = ''' + @tipoPersonal + ''''
		END
		
		IF @estado <> 'TODOS'
		BEGIN
			SET @query = @query + 'AND Estado = ''' + @estado + ''''
		END
		
		EXEC(@query)
	END
END