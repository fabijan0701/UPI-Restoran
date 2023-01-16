﻿SELECT 
	G.BROJ_OSOBNE, G.IME, G.PREZIME, G.KONTAKT,
	S.BROJ, P.NAZIV, K.NAZIV,
	R.BROJ, R.POCETAK, R.KRAJ
FROM REZERVACIJA R INNER JOIN GOST G ON G.BROJ_OSOBNE = R.BROJ_OSOBNE
INNER JOIN STOL S ON R.STOL_ID = S.BROJ
INNER JOIN POZICIJA P ON P.ID = S.POZICIJA
INNER JOIN KLASA K ON K.ID = S.KLASA_ID
WHERE R.POCETAK >= '2023-01-14 13:00:00.000' AND R.KRAJ <= '2023-01-14 15:00:00.000'