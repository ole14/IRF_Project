Beadabdó feladat követelménye:

1.A Olvasás CSV fájlból
2.C Adott tulajdonságú elemek törlése egy listából
3.B Formázott Excel létrehozása a rendelkezésre álló adatokból
4.B Enumeráció létrehozása és használata

Teljesítési terv:

A feladat teljesítéséhez egy kisállat kereskedés állatokra vonatkozó nyílvántartását tűztem ki.

Az enum funkció az előre megadott típus gombok betöltését csinálja.
Megnyitásnál, a LoadButtons() funkció betölti az enum által meghatározott elemek gombjait, majd a LoadTypes() funkció felolvassa a program mappájában található csv-t, 
ami az állatokat és a típusukat tartalmazza.

Ezt a CSV újraolvasása gomb segítségével más forrásból is lehet indítani, de fontos, hogy csak Type és Name oszlop legyen benne.
A Type-ok a következőek lehetnek, az Enum funkció csak ezeket az elemeket ismeri, a többivel nem fog foglalkozni (elírás esetén se)
	- Kutya
	- Macska
	- Madár
	- Hüllő (vigyázni kell, mert valamiért a csv készítés során belefutottam a konvertálási problémába, 
				ha a csv nem jól készül el ezt az osztályt nem ismeri fel a program, mert a Hüll? típust nem tudja értelmezni)
			CSV pontosvesszővel és UTF8 mentéssel nekem működött, de excelben építettem a csv-t, lehet másik excel verzió esetén ez a probléma nem jön elő
	- Rágcsáló
	- Díszhal

Az animalBox-ba kerülnek be a csv-ben található állatok, és ezt a korábban legenerált gombokkal lehet szűrni.
Az animalBox sorait lehet törölni, viszont a törlés csak a nyitott állományra vonatkozik, a csv fájlt nem írja felül.

Fejlesztésre váró funkciók:
	
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