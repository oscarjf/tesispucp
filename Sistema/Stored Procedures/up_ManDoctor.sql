CREATE PROCEDURE up_ManDoctor (
@idPersona			INT,
@paterno			VARCHAR(30),
@materno			VARCHAR(30),
@nombres			VARCHAR(60),
@sexo				CHAR(1),
@fechaNacimiento	DATETIME,
@idTipoDocumento	INT,
@numeroDocumento	VARCHAR(20),
@estadoCivil		VARCHAR(10),
@idLugarNacimiento	INT,
@idDomicilio		INT,
@telefono			VARCHAR(8),
@celular			VARCHAR(10),
@email				VARCHAR(60),
@fechaRegistro		DATETIME,
@tipoPersona		VARCHAR(8),
@usuario			VARCHAR(20),
@contrasena			VARCHAR(20),
@tipoPersonal		VARCHAR(14),
@idHorario			INT,
@estado				VARCHAR(8),
@cmp				VARCHAR(5),
@indicadorHC		CHAR(1),
@idAreaMedica		INT,
@especialidades		TEXT,
@accion				INT --0: Insertar, 1: Modificar, 2: Eliminar, 3: Recuperar
)
AS

BEGIN
  BEGIN TRANSACTION
    IF @accion = 0
    BEGIN
		DECLARE @id INT, @output INT
		EXEC @id = up_ManPersona @idPersona, @paterno, @materno, @nombres, @sexo, 
								 @fechaNacimiento, @idTipoDocumento, @numeroDocumento, 
								 @estadoCivil, @idLugarNacimiento, @idDomicilio, 
								 @telefono, @celular, @email, @fechaRegistro, @tipoPersona, 
								 @accion, @output OUTPUT
		
		EXEC up_ManPersonal @id, @usuario, @contrasena, @tipoPersonal, @idHorario, 
							'ACTIVO', @accion
		
		INSERT INTO Doctor (Id_Doctor, CMP, IndicadorHC, Id_AreaMedica)
		VALUES (@id, @cmp, @indicadorHC, @idAreaMedica)
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