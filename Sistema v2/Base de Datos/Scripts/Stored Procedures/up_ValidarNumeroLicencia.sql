USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ValidarNumeroLicencia]    Script Date: 09/06/2013 13:09:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_ValidarNumeroLicencia]
(
	@IdEnfermero		INT,
	@NumeroLicencia		VARCHAR(7),
	@Contador			INT	OUTPUT
)
AS
BEGIN
  IF @IdEnfermero = 0
  BEGIN
	SELECT @Contador = COUNT(IdEnfermero)
	FROM Enfermero
	WHERE NumeroLicencia = @NumeroLicencia
  END

  IF @IdEnfermero <> 0
  BEGIN
	SELECT @Contador = COUNT(IdEnfermero)
	FROM Enfermero
	WHERE NumeroLicencia = @NumeroLicencia AND NOT (IdEnfermero = @IdEnfermero)
  END
  
  RETURN @Contador
END