B2lQI7- IRF beadand�
Kapott t�telek: BAAA
B) Adatb�zis l�trehoz�sa, kapcsol�d�s �s legal�bb egy t�bla adatainak beolvas�sa
A) LINQ lek�rdez�s haszn�lata legal�bb egy WHERE felt�tellel
A) �r�s CSV f�jlba
A) V�letlensz�m gener�l�s �s felhaszn�l�s

Ezek alapj�n �n egy sorsol� programot tervezek l�trehozni
-Gombnyom�ssal van lehet�s�g sorsolni (t�bbsz�r lenyomva t�bb embert sorsol ki)- sorsol�s a v�letlensz�m gener�l�s �ltal fog m�k�dni
-A sorsol�s ut�n lehet�s�g van kiexport�lni a kisorsolt szem�ly(eke)t egy CSV f�jlba
-A LINQ lek�rdez�st abban a form�ban fogja tartalmazni, hogy egy futtat�skor minden szem�lyt csak egyszer lehet kisorsolni
	-akit m�r kisorsoltak nem sorsolhatnak �jra
	-a where-ben adom meg, hogy a kisorsolt sz�m legyen a jelenetkez�k ID-j�val egyenl�
-Az adatb�zis k�t t�bl�b�l �ll, egy jelentkez�kb�l �s egy sorsoltakb�l. A sorsoltak t�bla minden sorsol�s ut�n le�r�l.
-A felhaszn�l� fel�letet �jra gondolva, �gy d�nt�ttem, hogy panellal �s usercontrollal oldom meg
	-�gy az egyik usercontrolon lehet�s�g lesz �j jelentkez� adatokat megadni
	-A m�sik usercontrol megmarad a sorsol�snak

�sszefogal�s:
-A programban elhelyezett tippek seg�tik a program gyors megismer�s�t, k�nny� haszn�lat�t

Adatbevitel fel�let:
-Az adatbevitel fel�leten lehet�s�g van:
	-�j adatokat felvinni
		-a k�d ellen�rzi, hogy �res adatokat ne adhassunk meg, ezt az t�bla egy�bk�nt sem fogadn� el
	-a r�gi adatokat v�ltoztatni, p�d�ul egy rosszul felvitt adat jav�t�sa (ilyenkor fontos, hogy a v�ltoztat�sokat elments�k)
	-�s rekordokat t�r�lni is, ha p�ldul �j sorsol�st rendez�nk, �j r�sztvev�kkel

Sorsol�s fel�let:
-V�g�l a gombnyom�sra sorsol�st annyiban v�ltoztattam meg, hogy egy textboxban meg kell adni, hogy h�ny embert szeretn�nk kisorsolni
	-�gy nagyobb (20-30 f� sorsol�sn�l) nem kell egyes�vel kattingatni
	-maga a sorsol�s egy nagyon �sszetett folyamat,
		-hiszen mindenkit csak egyszer sorsolhat,
		-fel kell ismernie �s kezelnie kell ha olyan sz�mot gener�lt amilyen ID nem l�tezik
		-kezelnie kell a textbox tartalm�t (sz�m legyen, mely kisebb mint a  jelentkez�k sz�ma)
-Minden sorsol�s ut�n addig nem lehet �jra sorsolni, m�g a t�bla adatai nem lesznek t�r�lve.
	-Ennek oka: ha kor�bban sorsoltunk 10 embert �s most sorsolni szeretn�nk m�g 5-�t,
	de a jelentkez�k csak 12-en vannak, akkor a program v�gtelen ciklusban prob�lna olyan ID-t tal�lni ami m�g nem fordult el�.
-A kisorsolt embereket CSV f�jlba lehet menteni, �s �gy a f�jl seg�ts�g�vel egyszer�en lehet �rtes�teni a nyerteseket.
