-- ZapujcenZamestnanci = 0,
-- Nedostupny = 1,
-- Dostupny = 2,

SELECT 
    k.Id,
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
    END AS StavKlice
FROM Klice k
