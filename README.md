# Temat projeku: 18. Wzorce projektowe

## Czym jest wzorzec?
”Wzorzec opisuje problem, który powtarza się wielokrotnie w danym środowisku, oraz podaje istotę jego
rozwiązania w taki sposób, aby można było je zastosować miliony razy bez potrzeby powtarzania tej samej
pracy.”

Christopher Alexander ”A pattern language”, 1977

## Wzorce projektowe
Są to powtarzalne rozwiązania związane z zagadnieniami projektowymi. Nie są to gotowe przykłady kodów, a raczej sposób (podejście) do rozwiązania danego problemu.
Wzorce projektowe możemy podzielić na trzy główne kategorie, które cechują się swoimi własnościami:
- **Wzorce kreacyjne** wprowadzają mechanizmy tworzenia obiektów i pozwalają na ponowne wykorzystanie istniejącego kodu.
- **Wzorce strukturalne** wyjaśniają jak tworzyć obiekty i klasy w większe struktury i zachowywać przy tym elastyczność i efektywność struktur.
- **Wzorce behawioralne** które zajmują się komunikacją i podziałem obowiązków między obiektami.

Jak piszą w książce "Wzorce projektowe: Elementy oprogramowania obiektowego wielokrotnego użytku" autorstwa *bandy czworga do tej pory powstało 23 wzorce, mające na celu ułatwić życie programistom.

*banda czworga - Erich Gamma, John Vlissides, Ralph Johnson i Richard Helm

### Wzorce konstrukcyjne
”Konstrukcyjne wzorce projektowe pozwalają ująć w abstrakcyjnej formie proces tworzenia egzemplarzy klas. Pomagają zachować niezależność systemu od sposobu tworzenia, składania i reprezentowania
obiektów. Klasowe wzorce konstrukcyjne są oparte na dziedziczeniu i służą do modyfikowania klas, których
egzemplarze są tworzone. W obiektowych wzorcach konstrukcyjnych tworzenie egzemplarzy jest delegowane
do innego obiektu.”

Gamma E., Helm R., Johnson R., Vlissides J. M., ”Wzorce projektowe. Elementy oprogramowania obiektowego wielokrotnego
użytku”,Helion, 2010

### Wzorce strukturalne
”Wzorce strukturalne dotyczą składania klas i obiektów w większe struktury. Klasowe wzorce strukturalne są oparte na wykorzystaniu dziedziczenia do składania interfejsów lub implementacji. (...) Strukturalne
wzorce obiektowe nie polegają na składaniu interfejsów lub implementacji, ale opisują sposób składania obiektów w celu obsługi nowych funkcji.”

Gamma E., Helm R., Johnson R., Vlissides J. M., ”Wzorce projektowe. Elementy oprogramowania obiektowego wielokrotnego
użytku”,Helion, 2010

### Wzorce czynnościowe
”Wzorce operacyjne dotyczą algorytmów i podziału zadań między obiekty. Opisują nie tylko modele
obiektów i klas, ale też modele komunikacji między nimi. Wzorce operacyjne określają złożone przepływy
sterowania, które trudno jest śledzić w czasie wykonywania programu. Pozwala to skoncentrować się na
powiązaniach pomiędzy obiektami, a nie na przepływie sterowania.”

Gamma E., Helm R., Johnson R., Vlissides J. M., ”Wzorce projektowe. Elementy oprogramowania obiektowego wielokrotnego
użytku”,Helion, 2010

## Wzorce w naszym projekcie
Celem naszego projektu było utworzenie narzędzia, pozwalającego użytkownikowi na dostosowanie danego wzorca do własnych potrzeb. Przy minimalnej znajomości składni języków programowania C# oraz Java oraz pewnej wiedzy na temat wzorców projektowych. Rozpoczynając pracę w naszym środowisku należy wybrać z menu kontekstowego jaki wzorzec chcemy badać.

![image](https://github.com/aGrabson/TO-WzorceProjektowe/assets/105043765/97ce8126-5901-4593-beb5-5ff04c7bd446)

Następnie narzędzie pobiera kod źródłowy, oraz dzieli przestrzeń aplikacji na trzy sektory. W pierwszym sektorze (lewa część ekranu) znajduje się menu konfiguracyjne dla obiektów, pól i metod. Nowe klasy, metody oraz pola można dodawać, edytować i usuwać, lecz wartości rdzennych (core) zwracanych jako istotne nie możemy usuwać. Jest to procedura, która ma pomóc w tworzeniu choć minimalnie działającego wzorca projektowego. Drugim sektorem jest menu plików, w którym widoczne są nazwy plików obiektów. Trzecim sektorem jest część kodów znajdująca się pod sektorem plików, jej przeznaczeniem jest wyświetlenie kodu źródłowego danego pliku. 

![image](https://github.com/aGrabson/TO-WzorceProjektowe/assets/105043765/fa6d9157-283f-4680-a2a2-79236c7d83d6)

Zgodnie z założeniami projektu, narzędzie pozwala na dodanie nowego obiektu wzorca, któremu można dodać dynamicznie pola różnego typu oraz metody opcjonalnie z parametrami różnych typów. Poniższe zdjęcie przedstawia stan kodu, do którego dodano klasę wraz z polem oraz metodą. Wszystkie zmiany aktualizują się na żywo oraz są widoczne w części kodu.

![image](https://github.com/aGrabson/TO-WzorceProjektowe/assets/105043765/b4486ecb-e0d6-44f5-8fb8-beaa7cd8d08f)

## Jak to zaimplementowaliśmy?
Utworzyliśmy własny interpreter, który obsługuje poniższe składowe.
- #I1#FajnyInterfejs# - Nazwa interfejsu z core
- #CC1#Klasa# - Nazwa klasy z core
- #AC1#AbstrakcyjnaKlasa# - Nazwa abstrakcyjnej klasy z core
- #C2#KlasaDekoratora# - Nazwa klasy dodawanej przez uzytkownika
- #F1;CC1;int#nazwa9# - Pole danej klasy/interfejsu o podanym typie oraz nazwie
- #M1;I1;int;string.s,int.i,double.x#metka# - Metoda dla danej klasy/interfejsu o podanym typie zwracanym, nazwie oraz parametrach

### Nasz interpreter - w skrócie
Interpreter rozpoczyna analizę kodu od sprawdzenia, ile jest składników oddzielonych znakiem ";".
Na podstawie określonej wartości w środku oznaczenia, interpreter wie, co dany fragment kodu oznacza.
Na przykład, oznaczenie "I1" informuje interpreter, że ma do czynienia z interfejsem.
Jeżeli kod zawiera oznaczenie "F1", interpreter sprawdza dla jakiego obiektu (np. CC1) oraz jakiego typu (np. int) jest dane pole, a następnie zapisuje nazwę tego pola (np. nazwa9).
Podobnie jak w przypadku zmiennych, oznaczenie "M1" wskazuje, że należy analizować metodę. Interpreter rozpoznaje, dla jakiego interfejsu lub klasy (np. I1), jaki typ zwracany (np. int), nazwę metody (np. metka) oraz jej parametry (np. string.s, int.i, double.x), które oznaczają typ parametru oraz jego nazwę.

Utworzony przez nas przykładowy kod z powyższego zdjęcia zapisany w naszej notacji wygląda następująco:

#I1#FajnyInterfejs# #CC1#Klasa# #AC1#AbstrakcyjnaKlasa# #C2#KlasaDekoratora# #C3#Classek# #M1;C3;int;double.Doublek,bool.Boolek,#Metodek# #F1;C3;int#Fieldek# 


















