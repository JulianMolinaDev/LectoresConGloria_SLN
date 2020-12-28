ALTER TABLE [SCH_LectoresConGloria].[TBL_FormatosLibros]
	ADD CONSTRAINT [FK_FormatosLibros_Libros]
	FOREIGN KEY (IdLibro)
	REFERENCES [SCH_LectoresConGloria].[TBL_Libros] (Id)
