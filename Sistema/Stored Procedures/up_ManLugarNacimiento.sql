ALTER PROCEDURE [dbo].[up_ManLugarNacimiento] (
@idLugarNacimiento INT,
@pais			   VARCHAR(40),
@departamento	   VARCHAR(40),
@provincia		   VARCHAR(40),
@distrito		   VARCHAR(40),
@indicador		   INT --0: Insertar, 1: Modificar
)
AS

BEGIN
  BEGIN TRANSACTION
    IF @indicador = 0
    BEGIN
    
		INSERT INTO LugarNacimiento (Pais, Departamento, Provincia, Distrito)
		VALUES (@pais, @departamento, @provincia,@distrito)
		
    END
    
    IF @indicador = 1
    BEGIN
		UPDATE LugarNacimiento
		SET Pais = @pais, Departamento = @departamento, Provincia = @provincia,Distrito=@distrito
		WHERE Id_LugarNacimiento = @idLugarNacimiento
    END
    
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
	RETURN
  END
  COMMIT TRANSACTION
END