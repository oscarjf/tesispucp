
DECLARE @Tabla VARCHAR(100)
DECLARE Cur CURSOR FOR 
SELECT TABLE_NAME 
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_NAME NOT IN ('sysdiagrams','Auditoria','TablaAuditada')

OPEN Cur

FETCH NEXT FROM Cur 
INTO @Tabla

WHILE @@FETCH_STATUS = 0
BEGIN
	INSERT INTO TablaAuditada(Tabla, IndAuditoria, Insertar, Actualizar, Eliminar)
	VALUES(@Tabla,'','','','')
	
	FETCH NEXT FROM Cur 
	INTO @Tabla
END 
CLOSE Cur;
DEALLOCATE Cur;

SELECT * 
FROM TablaAuditada