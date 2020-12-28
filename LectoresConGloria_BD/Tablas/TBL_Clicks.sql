CREATE TABLE [SCH_LectoresConGloria].[TBL_Clicks]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [IdTexto] INT NOT NULL, 
    [IdLector] INT NOT NULL, 
    [TipoClick] INT NOT NULL, 
    [FechaAlta] SMALLDATETIME NOT NULL DEFAULT GETDATE()
)
