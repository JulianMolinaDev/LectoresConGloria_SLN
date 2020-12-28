ALTER TABLE [SCH_LectoresConGloria].[TBL_TextosLibros]
	ADD CONSTRAINT [FK_TextosLibros_Libros]
	FOREIGN KEY (IdLibro)
	REFERENCES [SCH_LectoresConGloria].[TBL_Libros] (Id)
