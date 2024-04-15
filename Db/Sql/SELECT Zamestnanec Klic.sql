--DECLARE @KlicId INT = 1;

SELECT 
    z.Id AS IdZamestnance,
    z.Jmeno,
    z.Prijmeni,
    z.Zkratka,
    MAX(CASE WHEN v.IdKlice = @KlicId THEN v.DatumVypujceni END) AS DatumPoslednihoVypujceni,
    MAX(CASE WHEN v.IdKlice = @KlicId THEN v.DatumVraceni END) AS DatumPoslednihoVraceni
FROM Zamestnanci z
JOIN ZaznamyVypujceni v ON z.Id = v.IdZamestnance
WHERE v.IdKlice = @KlicId
GROUP BY z.Id, z.Jmeno, z.Prijmeni, z.Zkratka;

