ALTER TABLE [SCH_LectoresConGloria].[TBL_TextosLibros]
	ADD CONSTRAINT [FK_TextosLibros_Textos]
	FOREIGN KEY (IdTexto)
	REFERENCES [SCH_LectoresConGloria].[TBL_Textos] (Id)
