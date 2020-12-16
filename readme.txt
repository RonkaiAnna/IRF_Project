B2lQI7- IRF beadandó
Kapott tételek: BAAA
B) Adatbázis létrehozása, kapcsolódás és legalább egy tábla adatainak beolvasása
A) LINQ lekérdezés használata legalább egy WHERE feltétellel
A) Írás CSV fájlba
A) Véletlenszám generálás és felhasználás

Ezek alapján én egy sorsoló programot tervezek létrehozni
-Gombnyomással van lehetõség sorsolni (többször lenyomva több embert sorsol ki)- sorsolás a véletlenszám generálás által fog mûködni
-A sorsolás után lehetõség van kiexportálni a kisorsolt személy(eke)t egy CSV fájlba
-A LINQ lekérdezést abban a formában fogja tartalmazni, hogy egy futtatáskor minden személyt csak egyszer lehet kisorsolni
	-akit már kisorsoltak nem sorsolhatnak újra
	-a where-ben adom meg, hogy a kisorsolt szám legyen a jelenetkezõk ID-jával egyenlõ
-Az adatbázis két táblából áll, egy jelentkezõkból és egy sorsoltakból. A sorsoltak tábla minden sorsolás után leürül.
-A felhasználó felületet újra gondolva, úgy döntöttem, hogy panellal és usercontrollal oldom meg
	-Így az egyik usercontrolon lehetõség lesz új jelentkezõ adatokat megadni
	-A másik usercontrol megmarad a sorsolásnak

Összefogalás:
-A programban elhelyezett tippek segítik a program gyors megismerését, könnyû használatát

Adatbevitel felület:
-Az adatbevitel felületen lehetõség van:
	-új adatokat felvinni
		-a kód ellenõrzi, hogy üres adatokat ne adhassunk meg, ezt az tábla egyébként sem fogadná el
	-a régi adatokat változtatni, pédául egy rosszul felvitt adat javítása (ilyenkor fontos, hogy a változtatásokat elmentsük)
	-és rekordokat törölni is, ha példul új sorsolást rendezünk, új résztvevõkkel

Sorsolás felület:
-Végül a gombnyomásra sorsolást annyiban változtattam meg, hogy egy textboxban meg kell adni, hogy hány embert szeretnénk kisorsolni
	-így nagyobb (20-30 fõ sorsolásnál) nem kell egyesével kattingatni
	-maga a sorsolás egy nagyon összetett folyamat,
		-hiszen mindenkit csak egyszer sorsolhat,
		-fel kell ismernie és kezelnie kell ha olyan számot generált amilyen ID nem létezik
		-kezelnie kell a textbox tartalmát (szám legyen, mely kisebb mint a  jelentkezõk száma)
-Minden sorsolás után addig nem lehet újra sorsolni, míg a tábla adatai nem lesznek törölve.
	-Ennek oka: ha korábban sorsoltunk 10 embert és most sorsolni szeretnénk még 5-öt,
	de a jelentkezõk csak 12-en vannak, akkor a program végtelen ciklusban probálna olyan ID-t találni ami még nem fordult elõ.
-A kisorsolt embereket CSV fájlba lehet menteni, és így a fájl segítségével egyszerûen lehet értesíteni a nyerteseket.
