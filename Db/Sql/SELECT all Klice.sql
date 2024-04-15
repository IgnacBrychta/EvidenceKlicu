SELECT 
    k.Id AS KlicId,
    k.Cislo,
    k.NazevMistnosti,
    k.OznaceniDveri,
    k.PocetKusu,
    ISNULL(BorrowedKeys.CountBorrowed, 0) AS PocetZapujcenychKlicu
FROM Klice k
LEFT JOIN (
    SELECT IdKlice, COUNT(*) AS CountBorrowed
    FROM ZaznamyVypujceni
    WHERE DatumVypujceni IS NOT NULL AND DatumVraceni IS NULL
    GROUP BY IdKlice
) AS BorrowedKeys ON k.Id = BorrowedKeys.IdKlice;
