ALTER TABLE [dbo].[TBL_TextosLibros]
	ADD CONSTRAINT [FK_TextosLibros_Libros]
	FOREIGN KEY (IdLibro)
	REFERENCES [TBL_Libros] (Id)
