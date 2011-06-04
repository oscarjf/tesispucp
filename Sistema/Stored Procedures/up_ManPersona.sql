ALTER PROCEDURE [dbo].[up_ManPersona] (
@idPersona			INT,
@idPersonal			INT,
@usuario			VARCHAR(20),
@contrasena			VARCHAR(20),
@tipopersonal		VARCHAR(14),
@id_horario			INT,
@estado				VARCHAR(8),
@paterno			VARCHAR(30),
@materno			VARCHAR(30),
@nombres			VARCHAR(60),
@sexo				CHAR(1),
@fechanacimiento	DATETIME,
@idTipoDocumento	INT,
@numerodocumento	VARCHAR(20),
@estadocivil		VARCHAR(10),
@idlugarnacimiento	INT,
@iddomicilio		INT,
@telefono			VARCHAR(8),
@celular			VARCHAR(10),
@email				VARCHAR(60),
@fecharegistro		DATETIME,
@tipopersona		VARCHAR(8),
@CMP				VARCHAR(5),
@indicadorhc		CHAR(1),
@idareamedica		INT,
@numerolicenciatura	VARCHAR(10),
@idareaadminis		INT,
@idespecialidad		INT,
@indicador			INT --0: Insertar, 1: Modificar, 2: Eliminar, 3: Recuperar
)
AS

BEGIN
  BEGIN TRANSACTION
    IF @indicador = 0
    BEGIN
    
		INSERT INTO Persona (Paterno,Materno,Nombres,Sexo,FechaNacimiento,Id_TipoDocumento,Numero_Documento,EstadoCivil,Id_LugarNacimiento,Id_Domicilio,Telefono,Celular,Email,FechaRegistro,TipoPersona)
		VALUES (@paterno,@materno,@nombres,@sexo,@fechanacimiento,@idTipoDocumento,@numerodocumento,@estadocivil,@idlugarnacimiento,@iddomicilio,@telefono,@celular,@email,@fecharegistro,@tipopersona)
		
		DECLARE @id_persona INT
		SELECT @id_persona = SCOPE_IDENTITY()
		
		INSERT INTO Personal (Id_Personal,Usuario, Contrasena,TipoPersonal,Id_Horario,Estado)
		VALUES (@id_persona,@usuario,@contrasena,@tipopersonal,@id_horario,@estado)
		
		IF @tipopersonal = 'Doctor'
		BEGIN
		  
		  INSERT INTO Doctor (Id_Doctor,CMP,IndicadorHC,Id_AreaMedica)
		  VALUES (@id_persona,@CMP,@indicadorhc,@idareamedica)
		  
		  INSERT INTO EspecialidadxDoctor (Id_Doctor,Id_Especialidad)
		  VALUES (@id_persona,@idespecialidad)
		END		
		
		IF @tipopersonal = 'Enfermera'
		BEGIN
		  
		  INSERT INTO Enfermera (Id_Enfermera,Id_AreaMedica,NumeroLicenciatura)
		  VALUES (@id_persona,@idareamedica,@numerolicenciatura)
		  
		END		
		
		IF @tipopersonal = 'Tecnico'
		BEGIN
		  
		  INSERT INTO Tecnico (Id_Tecnico,Id_AreaMedica)
		  VALUES (@id_persona,@idareamedica)
		  
		END		
		
		IF @tipopersonal = 'Administrativo'
		BEGIN
		  
		  INSERT INTO Administrativo (Id_Administrativo,Id_AreaAdministrativa)
		  VALUES (@id_persona,@idareaadminis)
		  
		END		
		
    END
    
    IF @indicador = 1
    BEGIN
		
		UPDATE Persona 
		SET Paterno=@paterno,Materno=@materno,Nombres=@nombres,Sexo=@sexo,FechaNacimiento=@fechanacimiento,Id_TipoDocumento=@idTipoDocumento,Numero_Documento=@numerodocumento,EstadoCivil=@estadocivil,Id_LugarNacimiento=@idlugarnacimiento,Id_Domicilio=@iddomicilio,Telefono=@telefono,Celular=@celular,Email=@email,FechaRegistro=@fecharegistro,TipoPersona=@tipopersona
		WHERE @idPersona=Id_Persona
		
		UPDATE Personal 
		SET Usuario=@usuario,Contrasena=@contrasena,TipoPersonal=@tipopersonal,Id_Horario=@id_horario
		WHERE @idPersonal=Id_Personal
		
		IF @tipopersonal = 'Doctor'
		BEGIN
		  
		  UPDATE Doctor 
		  SET CMP=@CMP,IndicadorHC=@indicadorhc
		  WHERE @idPersonal=Id_Doctor
		  		  
		END		
		
		IF @tipopersonal = 'Enfermera'
		BEGIN
		  
		  UPDATE Enfermera 
		  SET NumeroLicenciatura=@numerolicenciatura
		  WHERE @idPersonal=Id_Enfermera
		  
		END					
				
    END
    
    IF @indicador = 2
    BEGIN
		UPDATE Personal
		SET Estado = 'INACTIVO'
		WHERE Id_Personal = @idPersonal
    END
    
    IF @indicador = 3
    BEGIN
		UPDATE Personal
		SET Estado = 'ACTIVO'
		WHERE Id_Personal = @idPersonal
    END
    
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
	RETURN
  END
  COMMIT TRANSACTION
END