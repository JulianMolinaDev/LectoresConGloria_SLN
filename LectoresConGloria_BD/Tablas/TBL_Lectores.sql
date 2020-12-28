CREATE TABLE [SCH_LectoresConGloria].[TBL_Lectores]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [Nombre] VARCHAR(50) NOT NULL, 
    [Apellidos] VARCHAR(50) NOT NULL, 
    [FechaNacimiento] DATE NOT NULL, 
    [Correo] VARCHAR(50) NOT NULL, 
    [Password] VARBINARY(MAX) NOT NULL, 
    [FechaAlta] SMALLDATETIME NOT NULL DEFAULT GETDATE()
)
