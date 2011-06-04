ALTER PROCEDURE [dbo].[up_ManPacientesAtendidos] (
@idpacientesatend  INT,
@iddoctor		   INT,
@fecharegistro	   DATETIME,
@indicador		   INT --0: Insertar, 1: Modificar
)
AS

BEGIN
  BEGIN TRANSACTION
    IF @indicador = 0
    BEGIN
    
		INSERT INTO PacientesAtendidos (Id_PacientesAtendidos, Id_Doctor, FechaRegistro)
		VALUES (@idpacientesatend, @iddoctor, @fecharegistro)
		
    END
    
    IF @indicador = 1
    BEGIN
		UPDATE PacientesAtendidos
		SET Id_Doctor = @iddoctor, FechaRegistro = @fecharegistro
		WHERE Id_PacientesAtendidos = @idpacientesatend
    END    
    
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
	RETURN
  END
  COMMIT TRANSACTION
END