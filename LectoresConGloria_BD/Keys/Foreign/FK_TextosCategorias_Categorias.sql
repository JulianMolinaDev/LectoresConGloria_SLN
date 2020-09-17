ALTER TABLE [dbo].[TBL_TextosCategorias]
	ADD CONSTRAINT [FK_TextosCategorias_Categorias]
	FOREIGN KEY (IdCategoria)
	REFERENCES [TBL_Categorias] (Id)
