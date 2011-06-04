CREATE PROCEDURE [dbo].[up_ManTipoDocumento] (
@idTipoDocumento INT,
@nombre			 VARCHAR(30),
@descripcion	 VARCHAR(100),
@numerodigitos	 INT,
@estado			 VARCHAR(8),
@indicador		 INT --0: Insertar, 1: Modificar, 2: Eliminar, 3: Recuperar
)
AS

BEGIN
  BEGIN TRANSACTION
    IF @indicador = 0
    BEGIN
    
		INSERT INTO TipoDocumento (Nombre, Descripcion, NumeroDigitos,Estado)
		VALUES (@nombre, @descripcion, @numerodigitos,@estado)
		
    END
    
    IF @indicador = 1
    BEGIN
		UPDATE TipoDocumento
		SET Nombre = @nombre, Descripcion = @descripcion, NumeroDigitos = @numerodigitos,Estado=@estado
		WHERE Id_TipoDocumento = @idTipoDocumento
    END
    
    IF @indicador = 2
    BEGIN
		UPDATE TipoDocumento
		SET Estado = 'INACTIVO'
		WHERE Id_TipoDocumento = @idTipoDocumento
    END
    
    IF @indicador = 3
    BEGIN
		UPDATE TipoDocumento
		SET Estado = 'ACTIVO'
		WHERE Id_TipoDocumento = @idTipoDocumento
    END
    
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
	RETURN
  END
  COMMIT TRANSACTION
END