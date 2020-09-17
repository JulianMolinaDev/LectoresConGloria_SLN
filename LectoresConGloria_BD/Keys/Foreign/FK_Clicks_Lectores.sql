ALTER TABLE [dbo].[TBL_Clicks]
	ADD CONSTRAINT [FK_Clicks_Lectores]
	FOREIGN KEY ([IdLector])
	REFERENCES [TBL_Lectores] (Id)
