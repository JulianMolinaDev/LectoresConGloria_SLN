ALTER TABLE [SCH_LectoresConGloria].[TBL_Clicks]
	ADD CONSTRAINT [FK_Clicks_Lectores]
	FOREIGN KEY ([IdLector])
	REFERENCES [SCH_LectoresConGloria].[TBL_Lectores] (Id)
