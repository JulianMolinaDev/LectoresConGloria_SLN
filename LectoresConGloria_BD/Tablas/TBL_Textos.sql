﻿CREATE TABLE [dbo].[TBL_Textos]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Titulo] VARCHAR(50) NOT NULL, 
    [Explicacion] VARCHAR(50) NOT NULL, 
    [Audio] VARCHAR(50) NOT NULL, 
    [Archivo] VARCHAR(50) NOT NULL, 
    [FechaAlta] SMALLDATETIME NOT NULL DEFAULT GETDATE()
)