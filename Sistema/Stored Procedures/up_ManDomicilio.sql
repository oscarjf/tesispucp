ALTER PROCEDURE [dbo].[up_ManDomicilio] (
@idDomicilio	   INT,
@departamento	   VARCHAR(40),
@provincia		   VARCHAR(40),
@distrito		   VARCHAR(40),
@direccion		   VARCHAR(200),
@indicador		   INT --0: Insertar, 1: Modificar
)
AS

BEGIN
  BEGIN TRANSACTION
    IF @indicador = 0
    BEGIN
    
		INSERT INTO Domicilio (Departamento, Provincia, Distrito,Direccion)
		VALUES (@departamento, @provincia,@distrito,@direccion)
		
    END
    
    IF @indicador = 1
    BEGIN
		UPDATE Domicilio
		SET Departamento = @departamento, Provincia = @provincia,Distrito=@distrito,Direccion=@direccion
		WHERE Id_Domicilio = @idDomicilio
    END
    
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
	RETURN
  END
  COMMIT TRANSACTION
END