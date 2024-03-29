CREATE PROCEDURE [dbo].[up_SelDoctor] (
@idDoctor			INT,
@nombres			VARCHAR(60),
@ap_paterno			VARCHAR(30),
@ap_materno			VARCHAR(30),
@cmp				VARCHAR(5),
@nomespecialidad	VARCHAR(30),
@estado				VARCHAR(8),
@accion				INT --4: Seleccionar 1, 5: Seleccionar Todos, 6: Seleccionar por Criterios
)
AS
BEGIN
    IF @accion = 4
    BEGIN
		SELECT D.Id_Doctor,P.Paterno,P.Materno,P.Nombres,D.CMP,E.Nombre,P.EstadoCivil,P.Sexo,P.FechaNacimiento,TD.Nombre,P.Numero_Documento,A.Nombre,Per.Nombre,P.Telefono,P.Celular,P.Email,Domi.Departamento,Domi.Provincia,Domi.Distrito,Domi.Direccion,LN.Pais,LN.Departamento,LN.Provincia,LN.Distrito,Pl.Estado 
		FROM Persona P, Doctor D, Personal Pl, Especialidad E, EspecialidadxDoctor EP, TipoDocumento TD, Area A, Perfil Per, Domicilio Domi, LugarNacimiento LN
		WHERE D.Id_Doctor = @idDoctor and D.Id_Doctor =Pl.Id_Personal and Pl.Id_Personal=P.Id_Persona and EP.Id_Doctor=@idDoctor and EP.Id_Especialidad= E.Id_Especialidad and TD.Id_TipoDocumento=P.Id_TipoDocumento and D.Id_AreaMedica=A.Id_Area and Pl.Id_Perfil=Per.Id_Perfil and Domi.Id_Domicilio=P.Id_Domicilio and LN.Id_LugarNacimiento=P.Id_LugarNacimiento
	END
    
    IF @accion = 5
    BEGIN
		SELECT D.Id_Doctor,P.Paterno,P.Materno,P.Nombres,D.CMP,E.Nombre,Pl.Estado 
		FROM Persona P, Doctor D, Personal Pl, Especialidad E, EspecialidadxDoctor EP
		WHERE P.Id_Persona = Pl.Id_Personal and Pl.Id_Personal=D.Id_Doctor and EP.Id_Doctor=D.Id_Doctor and EP.Id_Especialidad= E.Id_Especialidad
	END
    
    IF @accion = 6
    BEGIN
		DECLARE @query VARCHAR(1000)
		SET @query = 'SELECT D.Id_Doctor,P.Paterno,P.Materno,P.Nombres,D.CMP,E.Nombre,Pl.Estado 
					  FROM Persona P, Doctor D, Personal Pl, Especialidad E, EspecialidadxDoctor EP 
					  WHERE P.Id_Persona = Pl.Id_Personal and Pl.Id_Personal=D.Id_Doctor and EP.Id_Doctor=D.Id_Doctor 
					  and EP.Id_Especialidad= E.Id_Especialidad '
		
		IF @nombres <> ''
		BEGIN
			SET @query = @query + 'AND P.Nombres LIKE ''%' + @nombres + '%'''
		END
		
		IF @ap_paterno <> ''
		BEGIN
			SET @query = @query + 'AND P.Paterno LIKE ''%' + @ap_paterno + '%'''
		END
		
		IF @ap_materno <> ''
		BEGIN
			SET @query = @query + 'AND P.Materno LIKE ''%' + @ap_materno + '%'''
		END
		
		IF @cmp <> ''
		BEGIN
			SET @query = @query + 'AND D.CMP LIKE ''%' + @cmp + '%'''
		END
		
		IF @nomespecialidad <> ''
		BEGIN
			SET @query = @query + 'AND E.Nombre LIKE ''%' + @nomespecialidad + '%'''
		END
		
		IF @estado <> 'TODOS'
		BEGIN
			SET @query = @query + 'AND Pl.Estado = ''' + @estado + ''''
		END
		
		EXEC(@query)
	END	
END