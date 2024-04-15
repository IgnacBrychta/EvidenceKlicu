CREATE TABLE [dbo].[Klice]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[Cislo] INT NOT NULL,
	[NazevMistnosti] NVARCHAR(64) NOT NULL,
	[OznaceniDveri] NVARCHAR(64) NOT NULL,
	[PocetKusu] INT NOT NULL,
)