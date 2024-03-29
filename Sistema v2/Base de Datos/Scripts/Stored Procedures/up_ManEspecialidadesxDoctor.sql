USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ManEspecialidadesxDoctor]    Script Date: 09/06/2013 13:02:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_ManEspecialidadesxDoctor]
(
	@IdEspecialidad		INT,
	@IdDoctor			INT,
	@Accion				INT --0:INSERT, 2:DELETE, 4:SELECT
)
AS
BEGIN
  BEGIN TRANSACTION
    IF @Accion = 0
    BEGIN
		INSERT INTO EspecialidadesxDoctor(IdEspecialidad, IdDoctor)
		VALUES (@IdEspecialidad, @IdDoctor)
    END
    
    IF @Accion = 2
    BEGIN
		DELETE FROM EspecialidadesxDoctor 
		WHERE IdDoctor = @IdDoctor
    END
    
    IF @Accion = 4
    BEGIN
		SELECT IdEspecialidadDoctor, IdEspecialidad, IdDoctor
		FROM EspecialidadesxDoctor
		WHERE IdDoctor = @IdDoctor
    END
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
  END
  
  COMMIT TRANSACTION
END