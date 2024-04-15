-- ZapujcenZamestnanci = 0,
-- Nedostupny = 1,
-- Dostupny = 2,
--DECLARE @ZamestnanecID INT = 1;

SELECT 
    k.Id AS KlicId,
    k.Cislo,
    k.NazevMistnosti,
    k.OznaceniDveri,
    k.PocetKusu,
    CASE
        WHEN EXISTS (
            SELECT 1 
            FROM ZaznamyVypujceni 
            WHERE IdKlice = k.Id AND IdZamestnance = @ZamestnanecId AND DatumVraceni IS NULL
        ) THEN 0
        WHEN (
            SELECT COUNT(*) 
            FROM ZaznamyVypujceni 
            WHERE IdKlice = k.Id AND DatumVraceni IS NULL
        ) = k.PocetKusu THEN 1
        ELSE 2
    END AS StavKlice,
    LastVypujceni.DatumVypujceni AS DatumPoslednihoVypujceni,
    LastVraceni.DatumVraceni AS DatumPoslednihoVraceni
FROM Klice k
LEFT JOIN (
    SELECT IdKlice, MAX(DatumVypujceni) AS DatumVypujceni
    FROM ZaznamyVypujceni
    WHERE ZaznamyVypujceni.IdZamestnance = @ZamestnanecId
    GROUP BY IdKlice
) AS LastVypujceni ON k.Id = LastVypujceni.IdKlice
LEFT JOIN (
    SELECT IdKlice, MAX(DatumVraceni) AS DatumVraceni
    FROM ZaznamyVypujceni
    WHERE ZaznamyVypujceni.IdZamestnance = @ZamestnanecId
    GROUP BY IdKlice
) AS LastVraceni ON k.Id = LastVraceni.IdKlice
