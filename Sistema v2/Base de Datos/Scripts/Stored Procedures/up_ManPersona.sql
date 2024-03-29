USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ManPersona]    Script Date: 09/06/2013 13:05:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_ManPersona]
(
	@IdPersona			INT,
	@Paterno			VARCHAR(30),
	@Materno			VARCHAR(30),
	@Nombres			VARCHAR(30),
	@Sexo				VARCHAR(9),
	@FechaNacimiento	DATETIME,
	@IdTipoDocumento	INT,
	@NumeroDocumento	VARCHAR(50),
	@EstadoCivil		VARCHAR(10),
	@IdLugarNacimiento	INT,
	@IdDomicilio		INT,
	@Telefono			VARCHAR(12),
	@Celular			VARCHAR(12),
	@CorreoElectronico	VARCHAR(100),
	@TipoPersona		VARCHAR(8),
	@Accion				INT, --0: INSERT, 1:UPDATE
	@IdGenerado			INT	OUTPUT	
)
AS
BEGIN
  BEGIN TRANSACTION
    IF @Accion = 0
    BEGIN
		INSERT INTO Persona (Paterno, Materno, Nombres, Sexo, FechaNacimiento,
							 NumeroDocumento, EstadoCivil, IdLugarNacimiento, IdDomicilio, Telefono,
							 Celular, CorreoElectronico, FechaRegistro, TipoPersona)
		VALUES (@Paterno, @Materno, @Nombres, @Sexo, @FechaNacimiento, @NumeroDocumento,
				@EstadoCivil, @IdLugarNacimiento, @IdDomicilio, @Telefono, @Celular, @CorreoElectronico,
				GETDATE(), @TipoPersona)
		
		SET @IdGenerado = SCOPE_IDENTITY()
		
		IF (@IdTipoDocumento <> 0)
		BEGIN
			UPDATE Persona 
			SET IdTipoDocumento = @IdTipoDocumento 
			WHERE IdPersona = @IdGenerado
		END
    END
    
    IF @Accion = 1
    BEGIN
		UPDATE Persona SET Paterno = @Paterno, Materno = @Materno, Nombres = @Nombres, Sexo = @Sexo, 
						   FechaNacimiento = @FechaNacimiento,
						   NumeroDocumento = @NumeroDocumento, EstadoCivil = @EstadoCivil, 
						   IdLugarNacimiento = @IdLugarNacimiento, IdDomicilio = @IdDomicilio, 
						   Telefono = @Telefono, Celular = @Celular, 
						   CorreoElectronico = @CorreoElectronico, TipoPersona = @TipoPersona
		WHERE IdPersona = @IdPersona
		
		IF (@IdTipoDocumento <> 0)
		BEGIN
			UPDATE Persona 
			SET IdTipoDocumento = @IdTipoDocumento 
			WHERE IdPersona = @IdPersona
		END
		
		SET @IdGenerado = 0
    END
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
	RETURN
  END
  
  COMMIT TRANSACTION
  
  RETURN @IdGenerado
END