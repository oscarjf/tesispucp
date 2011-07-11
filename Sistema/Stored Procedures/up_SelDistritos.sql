USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_SelDistritos]    Script Date: 07/10/2011 21:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_SelDistritos]
@CodDepartamento      char(2),
@CodProvincia         char(2)
AS

BEGIN	
	SET NOCOUNT ON

		SELECT * 
		FROM Ubigeo 
		WHERE CodDepartamento = @CodDepartamento 
        AND CodProvincia = @CodProvincia and CodDistrito <> '00'
		
	SET NOCOUNT OFF
END
