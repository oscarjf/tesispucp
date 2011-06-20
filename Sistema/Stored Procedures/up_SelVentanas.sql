CREATE PROCEDURE up_SelVentanas (
@idPerfil		INT
)
AS
BEGIN
	SELECT V.Nombre
	FROM VentanasxPerfil X, Ventana V
	WHERE X.Id_Ventana = V.Id_Ventana AND X.Id_Perfil = @idPerfil
END