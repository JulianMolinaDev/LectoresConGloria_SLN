ALTER TABLE [SCH_LectoresConGloria].[TBL_Clicks]
	ADD CONSTRAINT [FK_Clicks_Textos]
	FOREIGN KEY (IdTexto)
	REFERENCES [SCH_LectoresConGloria].[TBL_Textos] (Id)
