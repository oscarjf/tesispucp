USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ManBaseDatos]    Script Date: 09/06/2013 13:01:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
EXEC up_ManBaseDatos 'CentroSalud','C:\\TEMP\\josue.bak',1,0
*/
ALTER PROCEDURE [dbo].[up_ManBaseDatos]
(
	@NombreBaseDatos	VARCHAR(100),
	@Ruta				VARCHAR(1000),
	@Accion				INT,
	@IdGenerado			INT OUTPUT
)
AS
BEGIN
  IF @Accion = 0
  BEGIN
	BACKUP DATABASE @NombreBaseDatos
	TO DISK = @Ruta
    WITH INIT, NOUNLOAD, NAME = 'BACKUP CENTROSALUD', NOSKIP, STATS = 10, NOFORMAT
    
    SET @IdGenerado = 1
  END
  
  IF @Accion = 1
  BEGIN
	DECLARE @script VARCHAR(3000)
	SET @script = 'USE master RESTORE DATABASE ' + @NombreBaseDatos + ' FROM DISK = ' + @Ruta + ' WITH REPLACE, STATS = 10'
	
	EXEC(@script)
	
	SET @IdGenerado = 1
  END
  
  RETURN @IdGenerado
END