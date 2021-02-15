CREATE PROCEDURE [SCH_LectoresConGloria].[SP_FaltantesCategoriasByTexto]
	@idTexto int
AS
	SELECT A.Id,
	A.Nombre AS Valor
	FROM [SCH_LectoresConGloria].TBL_Categorias AS A
	WHERE A.Id NOT IN ( SELECT A_IN.IdCategoria
					FROM [SCH_LectoresConGloria].TBL_TextosCategorias A_IN
					WHERE A_IN.IdTexto = @idTexto)
RETURN 0
