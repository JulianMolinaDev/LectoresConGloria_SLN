CREATE TABLE [dbo].[TBL_FormatosLibros]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [IdLibro] INT NOT NULL, 
    [IdFormato] INT NOT NULL, 
    [Archivo] VARCHAR(50) NOT NULL
)
