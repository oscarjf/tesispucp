CREATE PROCEDURE up_SelTipoDocumento
AS
BEGIN
    SELECT Id_TipoDocumento, Nombre, Descripcion, NumeroDigitos, Estado
    FROM TipoDocumento
END