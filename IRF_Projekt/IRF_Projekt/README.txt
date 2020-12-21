Beadabdó feladat követelménye:

1.A Olvasás CSV fájlból
2.C Adott tulajdonságú elemek törlése egy listából
3.B Formázott Excel létrehozása a rendelkezésre álló adatokból
4.B Enumeráció létrehozása és használata

Teljesítési terv:

A feladat teljesítéséhez egy kisállat kereskedés állatokra vonatkozó nyílvántartását tűztem ki.

Az enum funkció az előre megadott típus gombok betöltését csinálja.
Megnyitásnál, a LoadButtons() funkció betölti az enum által meghatározott elemek gombjait, majd a LoadTypes() funkció felolvassa a csv-t, 
ami az állatokat és a típusukat tartalmazza.

Az animalBox-ba kerülnek be a csv-ben található állatok, és ezt a korábban legenerált gombokkal lehet szűrni.
Az animalBox sorait lehet törölni, viszont a törlés csak a nyitott állományra vonatkozik, a csv fájlt nem írja felül.

Fejlesztésre váró funkciók:
	
	- CSV beolvasás manuálisan történjen, nem automatán
	- Háttér adatbázis kapcsolása
		AnimalData tábla
			Date Datetime,
			AnimType varchar(50),
			AnimName varchar(100),
			AnimPrice integer,
			AnimQuantity integer
	- Háttér adatbázis feltöltése ár és készlet adatokkal
	- Ár és készlet módosító funkció
	- A kiválasztott típus alapján excel export
		- Tartalmazza a kiválasztott lista elemeit
		- és a hozzájuk kapcsolódó ár és készlet információt
			(Select first * from AnimalData where AnimType = typeLabel.text Order by Date desc)... itt az aktuális lista kell csak, 
			ami az esetleges törlés után maradt.
	- Projekt kinézet átalakítása