CREATE PROCEDURE [SCH_LectoresConGloria].[SP_FaltantesFormatosByLibro]
	@idLibro int
AS
	SELECT A.Id,
	A.Nombre AS Valor
	FROM [SCH_LectoresConGloria].TBL_Formatos AS A
	WHERE A.Id NOT IN ( SELECT A_IN.IdFormato
					FROM [SCH_LectoresConGloria].TBL_FormatosLibros A_IN
					WHERE A_IN.IdLibro = @idLibro)
RETURN 0
