ALTER TABLE [SCH_LectoresConGloria].[TBL_TextosCategorias]
	ADD CONSTRAINT [FK_TextosCategorias_Categorias]
	FOREIGN KEY (IdCategoria)
	REFERENCES [SCH_LectoresConGloria].[TBL_Categorias] (Id)
