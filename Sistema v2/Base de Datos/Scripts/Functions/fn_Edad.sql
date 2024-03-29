USE [CentroSalud]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_Edad]    Script Date: 09/06/2013 13:12:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[fn_Edad]
(
  @FechaNacimiento	DATETIME, 
  @FechaActual	DATETIME
)
RETURNS VARCHAR(7)
AS
BEGIN
  DECLARE @Ano VARCHAR(3)
  DECLARE @Mes VARCHAR(3)

  SET @Ano = YEAR(@FechaActual) - YEAR(@FechaNacimiento)

  IF MONTH(@FechaNacimiento) > MONTH(@FechaActual)
  BEGIN
    SET @Ano = @Ano - 1
    SET @Mes = 12 - (month(@FechaNacimiento) - month(@FechaActual))
  END

  IF MONTH(@FechaNacimiento) < MONTH(@FechaActual)
  BEGIN
    SET @Mes = (MONTH(@FechaActual) - MONTH(@FechaNacimiento))
  END

  IF MONTH(@FechaNacimiento) = MONTH(@FechaActual)
  BEGIN
    IF DAY(@FechaNacimiento) <= DAY(@FechaActual)
    BEGIN
      SET @Mes = 0
    END
    IF DAY(@FechaNacimiento) > DAY(@FechaActual)
    BEGIN
      SET @Ano = @Ano - 1
      SET @Mes = 11
    END
  END

--RETURN RIGHT('  ' + @Ano,2) + 'a ' + RIGHT('  ' + @Mes,2) + 'm'
  RETURN @Ano
END
