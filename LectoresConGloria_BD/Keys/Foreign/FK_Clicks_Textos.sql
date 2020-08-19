ALTER TABLE [dbo].[TBL_Clicks]
	ADD CONSTRAINT [FK_Clicks_Textos]
	FOREIGN KEY (IdTexto)
	REFERENCES [TBL_Textos] (Id)
