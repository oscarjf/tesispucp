CREATE PROCEDURE up_ManPersona (
@idPersona					INT,
@paterno					VARCHAR(30),
@materno					VARCHAR(30),
@nombres					VARCHAR(60),
@sexo						CHAR(1),
@fechaNacimiento			DATETIME,
@idTipoDocumento			INT,
@numeroDocumento			VARCHAR(20),
@estadoCivil				VARCHAR(10),
@paisNacimiento				VARCHAR(40),
@departamentoNacimiento		VARCHAR(40),
@provinciaNacimiento		VARCHAR(40),
@distritoNacimiento			VARCHAR(40),
@departamentoDomicilio		VARCHAR(40),
@provinciaDomicilio			VARCHAR(40),
@distritoDomicilio			VARCHAR(40),
@direccionDomicilio			VARCHAR(200),
@telefono					VARCHAR(8),
@celular					VARCHAR(10),
@email						VARCHAR(60),
@fechaRegistro				DATETIME,
@tipoPersona				VARCHAR(8),
@accion						INT, --0: Insertar, 1: Modificar
@idGenerado					INT		OUTPUT
)
AS

BEGIN
  BEGIN TRANSACTION
	DECLARE @idLugarNacimiento INT, @idDomicilio INT
    IF @accion = 0
    BEGIN
		INSERT INTO Persona (Paterno, Materno, Nombres, Sexo, FechaNacimiento,
							Id_TipoDocumento, Numero_Documento, EstadoCivil, 
							Id_LugarNacimiento, Id_Domicilio, Telefono, Celular,
							Email, FechaRegistro, TipoPersona)
		VALUES (@paterno, @materno, @nombres, @sexo, @fechaNacimiento, @idTipoDocumento,
				@numeroDocumento, @estadoCivil, @idLugarNacimiento, @idDomicilio, @telefono,
				@celular, @email, @fechaRegistro, @tipoPersona)
		
		SET @idGenerado = SCOPE_IDENTITY()
		
		RETURN @idGenerado
	END
    
    IF @accion = 1
    BEGIN
		UPDATE Persona
		SET Paterno = @paterno, Materno = @materno, Nombres = @nombres, Sexo = @sexo,
			FechaNacimiento = @fechaNacimiento, Id_TipoDocumento = @idTipoDocumento,
			Numero_Documento = @numeroDocumento, EstadoCivil = @estadoCivil, 
			Id_LugarNacimiento = @idLugarNacimiento,Id_Domicilio = @idDomicilio,
			Telefono = @telefono, Celular = @celular, Email = @email, 
			FechaRegistro = @fechaRegistro, TipoPersona = @tipoPersona
		WHERE Id_Persona = @idPersona
		
		SET @idGenerado = 0
		
		RETURN @idGenerado
    END
    
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
	RETURN
  END
  COMMIT TRANSACTION
END