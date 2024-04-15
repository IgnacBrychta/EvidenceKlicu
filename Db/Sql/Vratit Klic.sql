UPDATE ZaznamyVypujceni
SET
	DatumVraceni = @DatumVraceni
WHERE
	IdKlice = @KlicID AND 
	IdZamestnance = @ZamestnanecId