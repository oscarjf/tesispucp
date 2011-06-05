CREATE PROCEDURE [dbo].[up_ManEspecialidad] (
@idEspecialidad			INT,
@nombre					VARCHAR(30),
@descripcion			VARCHAR(200),
@accion					INT --0: Insertar, 1: Modificar, 2: Eliminar, 3: Recuperar
)
AS

BEGIN
  BEGIN TRANSACTION
    IF @accion = 0
    BEGIN
		INSERT INTO Especialidad (Nombre, Descripcion, Estado)
		VALUES (@nombre, @descripcion, 'ACTIVO')
    END
    
    IF @accion = 1
    BEGIN
		UPDATE Especialidad
		SET Nombre = @nombre, Descripcion = @descripcion
		WHERE Id_Especialidad = @idEspecialidad
    END
    
    IF @accion = 2
    BEGIN
		UPDATE Especialidad
		SET Estado = 'INACTIVO'
		WHERE Id_Especialidad = @idEspecialidad
    END
    
    IF @accion = 3
    BEGIN
		UPDATE Especialidad
		SET Estado = 'ACTIVO'
		WHERE Id_Especialidad = @idEspecialidad
    END
    
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
	RETURN
  END
  COMMIT TRANSACTION
END