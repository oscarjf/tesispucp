USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ValidarCodigoUnidadProductoraServicio]    Script Date: 09/06/2013 13:09:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_ValidarCodigoUnidadProductoraServicio]
(
	@IdUnidadProductoraServicio			INT,
	@CodigoUnidadProductoraServicio		VARCHAR(5),
	@Contador							INT	OUTPUT
)
AS
BEGIN
  IF @IdUnidadProductoraServicio = 0
  BEGIN
	SELECT @Contador = COUNT(IdUnidadProductoraServicio)
	FROM UnidadProductoraServicio
	WHERE Codigo = @CodigoUnidadProductoraServicio
  END

  IF @IdUnidadProductoraServicio <> 0
  BEGIN
	SELECT @Contador = COUNT(IdUnidadProductoraServicio)
	FROM UnidadProductoraServicio
	WHERE Codigo = @CodigoUnidadProductoraServicio AND NOT (IdUnidadProductoraServicio = @IdUnidadProductoraServicio)
  END
  
  RETURN @Contador
END