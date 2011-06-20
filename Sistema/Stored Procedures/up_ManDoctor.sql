CREATE PROCEDURE up_ManDoctor (
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
@usuario					VARCHAR(20),
@contrasena					VARCHAR(20),
@tipoPersonal				VARCHAR(14),
@idPerfil					INT,
@cmp						VARCHAR(5),
@indicadorHC				CHAR(1),
@idAreaMedica				INT,
@idEspecialidad				INT,
@estado						VARCHAR(8),
@accion						INT --0: Insertar, 1: Modificar, 2: Eliminar, 3: Recuperar
)
AS

BEGIN
  BEGIN TRANSACTION
    IF @accion = 0
    BEGIN
		DECLARE @idLugarNacimiento INT, @idDomicilio INT, @idDoctor INT, @output INT
		--Insertamos en la Tabla LugarNacimiento
		EXEC @idLugarNacimiento = up_ManLugarNacimiento 0, @paisNacimiento, @departamentoNacimiento,
														@provinciaNacimiento, @distritoNacimiento,
														@accion, @output OUTPUT
		
		--Insertamos en la Tabla Domicilio
		EXEC @idDomicilio = up_ManDomicilio 0, @departamentoDomicilio, @provinciaDomicilio, @distritoDomicilio,
											@direccionDomicilio, @accion, @output OUTPUT
		
		--Insertamos en la Tabla Persona
		EXEC @idDoctor = up_ManPersona 0, @paterno, @materno, @nombres, @sexo, @fechaNacimiento, @idTipoDocumento,
									   @numeroDocumento, @estadoCivil, @idLugarNacimiento, @idDomicilio, @telefono,
									   @celular, @email, @fechaRegistro, @tipoPersona, @accion, @output OUTPUT
									   
		--Insertamos en la Tabla Personal
		EXEC up_ManPersonal @idDoctor, @usuario, @contrasena, @tipoPersonal, @idPerfil, @estado, @accion
		
		--Insertamos en la Tabla Doctor
		INSERT INTO Doctor (Id_Doctor, CMP, IndicadorHC, Id_AreaMedica)
		VALUES (@idDoctor, @cmp, @indicadorHC, @idAreaMedica)
		
	END
    
 --   IF @accion = 1
 --   BEGIN
		
	--END
    
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
	RETURN
  END
  COMMIT TRANSACTION
END