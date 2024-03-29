USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ManConsultorio]    Script Date: 09/06/2013 13:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_ManConsultorio]
(
	@IdConsultorio		INT,
	@Piso				VARCHAR(4),
	@Numero				VARCHAR(10),
	@IdPabellon			INT,
	@Estado				VARCHAR(8),
	@Accion				INT,
	@IdGenerado			INT	OUTPUT --0:INSERT, 1:UPDATE, 2:DELETE, 3:RECOVER, 4:SELECT, 5:SELECTALL, 6:SELECT CUSTOM
)
AS
BEGIN
  BEGIN TRANSACTION
    IF @Accion = 0
    BEGIN
		INSERT INTO Consultorio(Piso, Numero, IdPabellon, Estado)
		VALUES (@Piso, @Numero, @IdPabellon, 'ACTIVO')
		
		SET @IdGenerado = SCOPE_IDENTITY()
    END
    
    IF @Accion = 1
    BEGIN
		UPDATE Consultorio SET Piso = @Piso, Numero = @Numero, IdPabellon = @IdPabellon
		WHERE IdConsultorio = @IdConsultorio
							
		SET @IdGenerado = 1
    END
    IF @Accion = 2
    BEGIN
		UPDATE Consultorio SET Estado = 'INACTIVO'
		WHERE IdConsultorio = @IdConsultorio
		
		SET @IdGenerado = 1
    END
    IF @Accion = 3
    BEGIN
		UPDATE Consultorio SET Estado = 'ACTIVO'
		WHERE IdConsultorio = @IdConsultorio
		
		SET @IdGenerado = 1
    END
    IF @Accion = 4
    BEGIN
		SELECT C.IdConsultorio, C.Piso, C.Numero, C.IdPabellon, P.Nombre AS Pabellon, C.Estado 
		FROM Consultorio C, Pabellon P
		WHERE C.IdPabellon = P.IdPabellon AND C.IdConsultorio = @IdConsultorio
		ORDER BY C.Piso, C.Numero
	END
    IF @Accion = 5
    BEGIN
		SELECT C.IdConsultorio, C.Piso, C.Numero, C.IdPabellon, P.Nombre AS Pabellon, C.Estado 
		FROM Consultorio C, Pabellon P
		WHERE C.IdPabellon = P.IdPabellon
		ORDER BY C.Piso, C.Numero
	END
	IF @Accion = 6
	BEGIN
		DECLARE @Query VARCHAR(1000)
		SET @Query = 'SELECT C.IdConsultorio, C.Piso, C.Numero, C.IdPabellon, P.Nombre AS Pabellon, C.Estado FROM Consultorio C, Pabellon P WHERE C.IdPabellon = P.IdPabellon'
		
		IF @Piso <> ''
		BEGIN
			SET @Query = @Query + ' AND C.Piso LIKE ''%' + @Piso + '%'''
		END
		
		IF @Numero <> ''
		BEGIN
			SET @Query = @Query + ' AND C.Numero LIKE ''%' + @Numero + '%'''
		END
		
		IF @IdPabellon <> 0
		BEGIN
			SET @Query = @Query + ' AND C.IdPabellon = ''' + @IdPabellon + ''''
		END	
		
		IF @Estado <>  'TODOS'
		BEGIN
			SET @Query = @Query + ' AND C.Estado = ''' + @Estado + ''''
		END
		
		SET @Query = @Query + ' ORDER BY C.Piso, C.Numero'	
						
		EXEC(@Query)
	END
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
    
    SET @IdGenerado = 0
	
	RETURN @IdGenerado
  END
  
  COMMIT TRANSACTION
  
  RETURN @IdGenerado
END