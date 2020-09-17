ALTER TABLE [dbo].[TBL_TextosLibros]
	ADD CONSTRAINT [FK_TextosLibros_Textos]
	FOREIGN KEY (IdTexto)
	REFERENCES [TBL_Textos] (Id)
