ALTER PROCEDURE up_ManLugarNacimiento (
@idLugarNacimiento		INT,
@pais					VARCHAR(40),
@departamento			VARCHAR(40),
@provincia				VARCHAR(40),
@distrito				VARCHAR(40),
@accion					INT, --0: Insertar, 1: Modificar
@idGenerado				INT		OUTPUT
)
AS

BEGIN
  BEGIN TRANSACTION
    IF @accion = 0
    BEGIN
		INSERT INTO LugarNacimiento (Pais, Departamento, Provincia, Distrito)
		VALUES (@pais, @departamento, @provincia, @distrito)
		
		SET @idGenerado = SCOPE_IDENTITY()
	END
    
    IF @accion = 1
    BEGIN
		UPDATE LugarNacimiento
		SET Pais = @pais, Departamento = @departamento, Provincia = @provincia, Distrito = @distrito
		WHERE Id_LugarNacimiento = @idLugarNacimiento
		
		SET @idGenerado = 0
	END
    
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
	RETURN
  END
  COMMIT TRANSACTION
  
  RETURN @idGenerado
END