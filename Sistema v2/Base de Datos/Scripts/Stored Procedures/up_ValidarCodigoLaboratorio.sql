USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ValidarCodigoLaboratorio]    Script Date: 09/06/2013 13:09:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_ValidarCodigoLaboratorio]
(
	@IdLaboratorio			INT,
	@CodigoLaboratorio		VARCHAR(5),
	@Contador				INT	OUTPUT
)
AS
BEGIN
  IF @IdLaboratorio = 0
  BEGIN
	SELECT @Contador = COUNT(IdLaboratorio)
	FROM Laboratorio
	WHERE Codigo = @CodigoLaboratorio
  END

  IF @IdLaboratorio <> 0
  BEGIN
	SELECT @Contador = COUNT(IdLaboratorio)
	FROM Laboratorio
	WHERE Codigo = @CodigoLaboratorio AND NOT (IdLaboratorio = @IdLaboratorio)
  END
  
  RETURN @Contador
END