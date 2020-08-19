ALTER TABLE [dbo].[TBL_Clicks]
	ADD CONSTRAINT [FK_Clicks_Usuarios]
	FOREIGN KEY (IdUsuario)
	REFERENCES [TBL_Usuarios] (Id)
