CREATE PROCEDURE [dbo].[SP_FaltantesCategoriasByTexto]
	@idTexto int
AS
	SELECT A.Id,
	A.Nombre AS Valor
	FROM TBL_Categorias AS A
	WHERE A.Id NOT IN ( SELECT A_IN.IdCategoria
					FROM TBL_TextosCategorias A_IN
					WHERE A_IN.IdTexto = @idTexto)
RETURN 0
