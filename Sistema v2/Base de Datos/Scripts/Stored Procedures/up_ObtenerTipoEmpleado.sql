USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ObtenerTipoEmpleado]    Script Date: 09/06/2013 13:06:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_ObtenerTipoEmpleado]
(
	@IdEmpleado		INT
)
AS
BEGIN
  SELECT TipoEmpleado 
  FROM Empleado
  WHERE IdEmpleado = @IdEmpleado
END