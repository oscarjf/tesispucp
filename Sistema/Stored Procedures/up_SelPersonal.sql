CREATE PROCEDURE [dbo].[up_SelPersonal] (
@usuario			VARCHAR(20),
@contrasena			VARCHAR(20)
)
AS
BEGIN
    
	SELECT P.Usuario,P.Contrasena,P.Id_Perfil,Per.Nombres
	FROM Personal P, Persona Per
	WHERE P.Usuario = @usuario and P.Contrasena =@contrasena and Per.Id_Persona=P.Id_Personal
	
END