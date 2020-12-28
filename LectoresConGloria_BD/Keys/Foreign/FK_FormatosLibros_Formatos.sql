ALTER TABLE [SCH_LectoresConGloria].[TBL_FormatosLibros]
	ADD CONSTRAINT [FK_FormatosLibros_Formatos]
	FOREIGN KEY (IdFormato)
	REFERENCES [SCH_LectoresConGloria].[TBL_Formatos] (Id)
