USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ValidarAcceso]    Script Date: 09/06/2013 13:08:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
DECLARE @id INT = 0
EXEC @id = up_ValidarAcceso 'cavalosr','1234',0
PRINT(@id)
*/
ALTER PROCEDURE [dbo].[up_ValidarAcceso]
(
	@Usuario		VARCHAR(20),
	@Contrasena		VARCHAR(20),
	@Acceso			INT	OUTPUT	--0: Denegado
)
AS
BEGIN
  SET @Acceso = 0
  
  SELECT @Acceso = IdEmpleado 
  FROM Empleado
  WHERE Estado = 'ACTIVO' AND Usuario = @Usuario AND Contrasena = @Contrasena
  
  RETURN @Acceso
END