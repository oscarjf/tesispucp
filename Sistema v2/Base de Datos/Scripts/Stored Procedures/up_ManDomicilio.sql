USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ManDomicilio]    Script Date: 09/06/2013 13:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_ManDomicilio]
(
	@IdDomicilio	INT,
	@Departamento	VARCHAR(40),
	@Provincia		VARCHAR(40),
	@Distrito		VARCHAR(40),
	@Direccion		VARCHAR(100),
	@Accion			INT,
	@IdGenerado		INT	OUTPUT
)
AS
BEGIN
  BEGIN TRANSACTION
    IF @Accion = 0
    BEGIN
		INSERT INTO Domicilio (Departamento, Provincia, Distrito, Direccion)
		VALUES (@Departamento, @Provincia, @Distrito, @Direccion)
		
		SET @IdGenerado = SCOPE_IDENTITY()
    END
    
    IF @Accion = 1
    BEGIN
		UPDATE Domicilio SET Departamento = @Departamento, Provincia = @Provincia, 
							Distrito = @Distrito, Direccion = @Direccion
		WHERE IdDomicilio = @IdDomicilio
							
		SET @IdGenerado = 0
    END
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
	RETURN
  END
  
  COMMIT TRANSACTION
  
  RETURN @IdGenerado
END