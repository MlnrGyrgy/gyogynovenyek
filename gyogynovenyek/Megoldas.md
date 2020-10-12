# Megoldás

# Osztály létrehozása
- Kétféle mód közül bármelyik
  - Ctrl + .
  - Adjunk hozzá egy osztályt 
- 5 tulajdonság
  - public get
  - private set
- 1 konstruktor
  - 1 paraméter --> string
  - például: "Acsalapu;levél;6;8"
  - pontosvesszővel(;) vannak elválasztva
  - 4 darab adat --> 5 tulajdonság?
  - átadott, fájlból beolvasott sort:
    - pontosvessző(;) mentén tagoljuk
    - [0] --> Nev
    - [1] --> Resz 
    - [2] --> Kezd
    - [3] --> Veg 
    - Idotartam --> számolás (lásd lejjebb)
- 5.dik tulajdonság ---> Időtartam
    - Konstruktorban számoljuk
    - számolása: Vég - Kezdet HA! Vég >(nagyobb)Kezdet
    - Vég > Kezdet --> Vég - Kezdet + 1
    - egyébként --> 12 - Vég + Kezdet + 1 
 ## Adatok beolvasása és eltárolása
 - Listában tároljuk az objektum példányokat
 - Olvassuk be:
   - System.IO;
   - StreamReader
   - while ciklus --> amíg tart a fájl
   - cikluson belül listához adjuk egy új objektum példányt(beolvasott sor
 a paraméter)
## 1.Feladat
 - Hány növény van(lista.Count tulajdonság)
## 2.Feladat
  - Milyen gyűjthető részek vannak?
  - Hány darab van ezekből?    
  - Adatszerk: Dictionary <string, int>
 - 1 Milyen gyűjthető részek vannak?
  - foreach "novenyek"
  - Ha a rész nem kulcs adjuk hozzá 0-val
- 2 Hány darab van ezekből? 
  - Foreach novenyek
  - Ha "Resz" == Key --> Value++; 
## 3.Feladat
  - Maximum keresés --> Időtartam alapján
  - Növény(ek) amelyek a legtöbb ideig szedtek
  -  maximum valtozo --> 0 
  -  foreach novenyek
  -  ha max< Idotartam --> idotartam
     -  foreach novenyek 
     -  Kiírni az Időtartam == max;
## 4.Feladat
  - Időtartam átlagszámítás (Összegzés) 