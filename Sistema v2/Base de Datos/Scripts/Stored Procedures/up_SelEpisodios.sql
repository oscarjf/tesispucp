USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_SelEpisodios]    Script Date: 09/20/2013 16:23:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_SelEpisodios]
(
	@IdPaciente		INT
)
AS
BEGIN
  SELECT EP.IdEpisodio, EP.FechaRegistro, E.TipoEmpleado, P.Paterno + ' ' + P.Materno + ', ' + P.Nombres AS Responsable,
		 EP.IdEnfermedad
  FROM HistoriaClinica H, Episodio EP, Persona P, Empleado E
  WHERE H.IdHistoriaClinica = EP.IdHistoriaClinica AND 
		EP.IdEmpleado = E.IdEmpleado AND E.IdEmpleado = P.IdPersona AND H.IdPaciente = @IdPaciente
  ORDER BY EP.FechaRegistro DESC
END