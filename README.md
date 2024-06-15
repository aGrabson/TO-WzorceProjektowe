# Temat projeku: 18. Wzorce projektowe
## Członkowie zespołu projektowego
### Artur Graba s092265@student.tu.kielce.pl

### Jan Dyrduł s091920@student.tu.kielce.pl

## Tematy prac inżynierskich
### AG – Projekt i implementacja aplikacji wędkarskiej

### JD – Projekt i implementacja systemu prognozującego szansę wygrania meczu piłki nożnej

## Temat projektu z przedmiotu "Programowanie systemów rozproszonych": Warcaby

## Technologie:
### ASP .NET, React

## Funkcjonalności:
Marzec – prototyp interfejsu użytkownika wraz z szkieletem aplikacji webowej✅

Kwiecień – Tworzenie schematu wzorca oraz wyświetlenie go na stronie, Baza danych✅

Maj – Kompletna obsługa aplikacji oraz wybór, tworzenie i edycję wzorców strukturalnych i konstrukcyjnych✅

Czerwiec – Dokumentacja techniczna✅

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

### Przykłady wzorców konstrukcyjnych
**Budowniczy** - umożliwia tworzenie skomplikowanych obiektów krok po kroku. Dzięki temu wzorcowi można wytwarzać różne rodzaje i wersje obiektów przy użyciu tego samego kodu konstrukcyjnego.

**Singleton** - zapewnia istnienie wyłącznie jednej instancji danej klasy. Pozwala na globalny dostęp do tej instancji.

### Wzorce strukturalne
”Wzorce strukturalne dotyczą składania klas i obiektów w większe struktury. Klasowe wzorce strukturalne są oparte na wykorzystaniu dziedziczenia do składania interfejsów lub implementacji. (...) Strukturalne
wzorce obiektowe nie polegają na składaniu interfejsów lub implementacji, ale opisują sposób składania obiektów w celu obsługi nowych funkcji.”

Gamma E., Helm R., Johnson R., Vlissides J. M., ”Wzorce projektowe. Elementy oprogramowania obiektowego wielokrotnego
użytku”,Helion, 2010

### Przykłady wzorców strukturalnych
**Dekorator** - umożliwia dodawanie nowych funkcji do obiektów przez umieszczanie ich w specjalnych obiektach opakowujących, które zawierają dodatkowe zachowania. Dzięki temu można rozszerzać możliwości obiektów bez konieczności modyfikowania ich kodu źródłowego.

**Fasada** - upraszcza interakcję z bardziej złożonym systemem, dostarczając uproszczony interfejs. Umożliwia ona ukrycie skomplikowanych zależności i logiki wewnętrznej systemu, oferując klientowi jednolity i łatwiejszy w użyciu punkt dostępu do funkcjonalności systemu.

### Wzorce czynnościowe
”Wzorce operacyjne dotyczą algorytmów i podziału zadań między obiekty. Opisują nie tylko modele
obiektów i klas, ale też modele komunikacji między nimi. Wzorce operacyjne określają złożone przepływy
sterowania, które trudno jest śledzić w czasie wykonywania programu. Pozwala to skoncentrować się na
powiązaniach pomiędzy obiektami, a nie na przepływie sterowania.”

Gamma E., Helm R., Johnson R., Vlissides J. M., ”Wzorce projektowe. Elementy oprogramowania obiektowego wielokrotnego
użytku”,Helion, 2010

### Przykłady wzorców czynnościowych
**Łańcuch zobowiązań** - umożliwia przekazywanie żądań przez serię obiektów, z których każdy może je obsłużyć. Każdy obiekt w łańcuchu decyduje, czy przetworzy żądanie, czy przekaże je dalej do następnego obiektu w łańcuchu, aż żądanie zostanie obsłużone lub dotrze do końca łańcucha.

**Obserwator** - umożliwia utworzenie mechanizmu subskrypcji. Dzięki niemu wiele obiektów może być powiadamianych o zdarzeniach zachodzących w obiekcie, który jest obserwowany.

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

Po rozpoznaniu wszystkich danych z interpretera, podmieniamy odpowiednie miejsca we wzorcu. Wzorzec jest skonstruowany z myślą o naszych potrzebach związanych z działaniem interpretera. Zawiera on pewne kluczowe znaki, dzięki którym wiemy, co mamy podstawiać i co te podstawienia mają reprezentować. Istnieją również linijki odpowiedzialne za podział klas. Każda klasa ma swoje określone miejsce, w którym dodawane są pola i metody dynamicznie.

W kodzie rozpoznajemy, jaka część należy do podstawy na której bazuje wzorzec a co jest częścią modyfikowalną, którą użytkownik dostosowuje w celu rozwinięcia przykładu wybranego wzorca projektowego. Zwracany kod użytkownikowi jest częściowo niemożliwy do modyfikacji w celu zapewnienia działania wzorca. Część core (niemodyfikowalna) wzorca jest rozpoznawana przy pomocy tagu "CC" - Core Class, dla porównania tag "C" oznacza Class, czyli klasę. Każda "AC" - Abstract Class oraz "I" - interfejs jest uznawana za rdzenną i nie podlega usunięciu. Poniżej w kodzie źródłowym aplikacji przedstawiono sposób użycia tagów, które następnie zostaną zamienione na nazwy klas, bądź pola i metody danej klasy.

```C#
class #CC1# : #AC1#
{
    #F;#CC1#

    #M;#CC1#
    public override object Handle(object request)
    {
        if ((request as string) == ""Pizza"")
        {
            Console.Write($""Johny: I'll eat the {request.ToString()}.\n"");
            return """";
        }
        else
        {
            Console.Write($""Johny: I'm hungry!\n"");
            return base.Handle(request);
        }
    }
}
```

Pierwszym krokiem działania interpretera jest wyciągnięcie danych z naszego ciągu znaków. Następnie uwzględniamy klasy dodane przez użytkownika, później wszystkie tagi są zamieniane na elementy, które użytkownik podał tj. nazwa klas, pól i metod. W poniższym kodzie przedstawiamy jak wyekstraktować dla przykładu pola danej klasy z ciągu znaków toInterpret.

```C#
else if (Regex.IsMatch(trimmedLine, separator + "F.*" + separator) && trimmedLine.EndsWith(separator))
{
    //#F1;I1;int#nazwa#
    string[] parts = trimmedLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);
    if (parts.Length == 2)
    {
        string[] parts2 = parts[0].Split(";", StringSplitOptions.RemoveEmptyEntries);
        if (parts2.Length == 3)
        {
            string dest = parts2[1].Trim();
            string type = parts2[2].Trim();
            string name = parts[1].Trim();
            dynamicFields.Add(new DynamicFields(name, type, dest));
            tmpReplacements[i] = null;
        }
    }
}
```

Później dla każdego odczytanego pola z naszego kodu, tworzymy deklarację zmiennej dla danej klasy, a następnie podmieniamy tag odpowiadający za miejsce zmiennej dla danej klasy na deklarację zmiennych. Jest to rozwiązane w ten sposób dla każdego tagu.

```C#
foreach (var tmp in groupByKeyDynamicFields)
{
    string fieldReplacement = string.Empty;
    string key = tmp.Key;
    
    foreach (var x in tmp)
    {
        if (isJava && x.Type == "string")
        {
            fieldReplacement += $"public String {x.Name};\n    ";
        }
        else if(isJava && x.Type == "bool")
        {
            fieldReplacement += $"public boolean {x.Name};\n    ";
        }
        else
        {
            fieldReplacement += $"public {x.Type} {x.Name};\n    ";
        }
        
    }
    template = template.Replace(separator + "F;" + separator + key + separator, fieldReplacement);
}
```
<br/>
<br/>


## "Jeśli chcesz gdzieś dojść, najlepiej znajdź kogoś, kto już tam doszedł." ~ Robert Kiyosaki













