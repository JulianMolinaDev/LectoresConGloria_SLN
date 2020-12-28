CREATE FUNCTION [SCH_LectoresConGloria].[FN_HabilitaBajarLibro]
(
	@IdLibro INT,
	@IdLector INT,
	@CantidadClicks INT
)
RETURNS BIT
AS
BEGIN
	DECLARE @CantidadContada INT,
	@Output BIT 
	SELECT @CantidadContada = COUNT(1)
			FROM	TBL_Clicks AS A
			WHERE A.IdLector = @IdLector
			AND		A.IdTexto = @IdLibro
	
	IF (@CantidadContada >= @CantidadClicks) BEGIN
		SET @Output = 1
	END
	ELSE BEGIN 
		SET @Output = 0
	END

	RETURN @Output
END
