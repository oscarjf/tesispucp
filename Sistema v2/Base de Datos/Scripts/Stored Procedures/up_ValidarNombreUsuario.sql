USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ValidarNombreUsuario]    Script Date: 09/06/2013 13:09:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
DECLARE @i INT
EXEC @i = up_ValidarNombreUsuario 5,'wchicana',0
PRINT(@i)
*/
ALTER PROCEDURE [dbo].[up_ValidarNombreUsuario]
(
	@IdEmpleado		INT,
	@Usuario		VARCHAR(20),
	@Contador		INT	OUTPUT
)
AS
BEGIN
  IF @IdEmpleado = 0
  BEGIN
	SELECT @Contador = COUNT(IdEmpleado) 
	FROM Empleado
	WHERE Usuario = @Usuario
  END

  IF @IdEmpleado <> 0
  BEGIN
	SELECT @Contador = COUNT(IdEmpleado) 
	FROM Empleado
	WHERE Usuario = @Usuario AND NOT (IdEmpleado = @IdEmpleado)
  END
  
  RETURN @Contador
END