CREATE TABLE [dbo].[TBL_Clicks]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [IdTexto] INT NOT NULL, 
    [IdUsuario] INT NOT NULL, 
    [TipoClick] INT NOT NULL, 
    [FechaAlta] SMALLDATETIME NOT NULL DEFAULT GETDATE()
)
