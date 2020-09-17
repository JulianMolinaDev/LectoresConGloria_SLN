ALTER TABLE [dbo].[TBL_FormatosLibros]
	ADD CONSTRAINT [FK_FormatosLibros_Formatos]
	FOREIGN KEY (IdFormato)
	REFERENCES [TBL_Formatos] (Id)
