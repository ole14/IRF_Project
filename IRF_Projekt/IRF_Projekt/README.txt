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

Egy háttér adatbázis felel az ár és készlet adatok nyílvántartásáért (ez nem volt a feladatom része, de ezt a megoldást találtam a
a legegyszerűbbnek a funkció elkészítéséhez).
Az adatbázis összességében 1 táblát tartalmaz ami a következő:

		AnimalData tábla
			Date Datetime Primary key,
			AnimType varchar(50),
			AnimName varchar(100),
			AnimPrice integer,
			AnimQuantity integer

A 2 textbox, quantityBox és priceBox ebből a táblából hozza vissza a kijelölt állat ár és készlet adatait.
A Nyílvántartott adatok módosítása gombbal megjelenik egy módosító form, amin hasonló logika szerint jelennek meg az adatok.
Itt lehet módosítani a főoldalon megjelenő információkat, és a módosít gomb megnyomásával egy új sor kerül az adatbázisba.
Mivel az adatbázisban a Date mező a primary key, és kicsi a valószínűsége, hogy 1 mp alatt ugyanaz az állat módosításra kerüljön,
így a quantityBox és priceBox minden esetben képes megjeleníteni a legutolsó mentett eredményt az 'order by Date desc' szerint.

Kiválasztott kategória százalék alapú átárazása.
Ez a funkció lehetőséget biztosít, kategória alapon árazni az állatokat, a funkció emelés és csökkentés esetén a megfelelő %-al módosítja az árakat
és ezeket az árakat rögzíti az adatbázisba.
	
Fejlesztésre váró funkciók:
	- Új állatok esetén is fusson le az árazás, de legyen kezelve a hiba
	- Új állat esetén a készlet és ár legyen 0
	- A kiválasztott típus alapján excel export
		- Tartalmazza a kiválasztott lista elemeit
		- és a hozzájuk kapcsolódó ár és készlet információt
			(Select first * from AnimalData where AnimType = typeLabel.text Order by Date desc)... itt az aktuális lista kell csak, 
			ami az esetleges törlés után maradt.
	- Projekt kinézet átalakítása