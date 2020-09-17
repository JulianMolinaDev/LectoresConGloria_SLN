ALTER TABLE [dbo].[TBL_TextosCategorias]
	ADD CONSTRAINT [FK_TextosCategorias_Textos]
	FOREIGN KEY (IdTexto)
	REFERENCES [TBL_Textos] (Id)
