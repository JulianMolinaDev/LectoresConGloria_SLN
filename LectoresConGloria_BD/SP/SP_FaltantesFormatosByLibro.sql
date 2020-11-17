CREATE PROCEDURE [dbo].[SP_FaltantesFormatosByLibro]
	@idLibro int
AS
	SELECT A.Id,
	A.Nombre AS Valor
	FROM TBL_Formatos AS A
	WHERE A.Id NOT IN ( SELECT A_IN.IdFormato
					FROM TBL_FormatosLibros A_IN
					WHERE A_IN.IdLibro = @idLibro)
RETURN 0
