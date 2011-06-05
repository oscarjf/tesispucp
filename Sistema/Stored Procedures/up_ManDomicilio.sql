CREATE PROCEDURE up_ManDomicilio (
@idDomicilio			INT,
@departamento			VARCHAR(40),
@provincia				VARCHAR(40),
@distrito				VARCHAR(40),
@direccion				VARCHAR(200),
@accion					INT, --0: Insertar, 1: Modificar
@idGenerado				INT		OUTPUT
)
AS

BEGIN
  BEGIN TRANSACTION
    IF @accion = 0
    BEGIN
		INSERT INTO Domicilio (Departamento, Provincia, Distrito, Direccion)
		VALUES (@departamento, @provincia, @distrito, @direccion)
		
		SET @idGenerado = SCOPE_IDENTITY()
		
		RETURN @idGenerado
	END
    
    IF @accion = 1
    BEGIN
		UPDATE Domicilio
		SET Departamento = @departamento, Provincia = @provincia, Distrito = @distrito,
			Direccion = @direccion
		WHERE Id_Domicilio = @idDomicilio
		
		SET @idGenerado = 0
		
		RETURn @idGenerado	
	END
    
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
	RETURN
  END
  COMMIT TRANSACTION
END