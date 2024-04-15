--SELECT 
--	k.Id, -- KlicId
--	k.NazevMistnosti,
--	k.OznaceniDveri,
--	z.Id -- ZaznamId
--FROM Klice k
--FULL JOIN ZaznamyVypujceni z ON 
--	k.Id = z.IdKlice
--WHERE z.IdZamestnance = 163
-- 154 199
DECLARE @ZamestnanecId INT = 154; -- Specify the ZamestnanecId parameter here

SELECT
    K.Id AS KeyId,
    K.NazevMistnosti AS RoomName,
    K.OznaceniDveri AS DoorLabel,
    K.PocetKusu AS TotalCount,
    CASE
        WHEN (SELECT COUNT(*)
              FROM ZaznamyVypujceni
              WHERE IdKlice = K.Id AND DatumVraceni IS NULL) > 0
             THEN 1 -- Key borrowed by @ZamestnanecId and not returned yet
        WHEN K.PocetKusu > (SELECT COUNT(*)
                             FROM ZaznamyVypujceni
                             WHERE IdKlice = K.Id AND DatumVraceni IS NULL)
             THEN 0 -- Key available to borrow
        ELSE 2 -- Key not available (fully borrowed)
    END AS StatusCode
FROM
    Klice K
ORDER BY
    K.Id;
