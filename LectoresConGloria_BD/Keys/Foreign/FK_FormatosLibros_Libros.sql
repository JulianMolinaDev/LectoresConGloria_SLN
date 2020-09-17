ALTER TABLE [dbo].[TBL_FormatosLibros]
	ADD CONSTRAINT [FK_FormatosLibros_Libros]
	FOREIGN KEY (IdLibro)
	REFERENCES [TBL_Libros] (Id)
