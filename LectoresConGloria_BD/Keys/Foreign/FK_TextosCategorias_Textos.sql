ALTER TABLE [SCH_LectoresConGloria].[TBL_TextosCategorias]
	ADD CONSTRAINT [FK_TextosCategorias_Textos]
	FOREIGN KEY (IdTexto)
	REFERENCES [SCH_LectoresConGloria].[TBL_Textos] (Id)
