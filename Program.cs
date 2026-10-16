﻿Console.WriteLine("Podaj Imię bohatera: ");
String Imie = Console.ReadLine();

Console.WriteLine("Podaj ilość miejsca w plecaku (MAX 10): ");
int Miejsce_w_plecaku = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj ilość zdrowia (MAX 100) (Tylko liczby całkowite) (Więcej niz jedna cyfra): ");
double Zdrowie = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Podaj ilość siły : ");
int Siła = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj ilość osób w grupie : ");
int Ilosc_osob_w_grupie = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj ilość złota : ");
int Ilosc_zlota = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Czy posiadasz mapę? (tak/nie) : ");
string Posiadanie_mapy = Console.ReadLine();

double mnożnik_obrażeń = 1.5;

int Obrażenia_od_Broni = 10;

double Obrażenia_całkowite = (mnożnik_obrażeń * (Siła + Obrażenia_od_Broni));

char Symbol_na_mapie = 'X';

int złoto_na_osobę = Ilosc_zlota / Ilosc_osob_w_grupie;



Console.WriteLine("+=======================================+");
Console.WriteLine("|            KARTA BOHATERA             |");
Console.WriteLine("+=======================================+");
Console.WriteLine($"| Imię bohatera: {Imie}\t\t\t|");
Console.WriteLine($"| Symbol na mapie: {Symbol_na_mapie}\t\t\t|");
Console.WriteLine($"| Miejsce w plecaku: {Miejsce_w_plecaku}/10\t\t|");
Console.WriteLine($"| HP: {Zdrowie}\t\t\t\t|");
Console.WriteLine($"| Siła: {Siła}\t\t\t\t|");
Console.WriteLine($"| Mnożnik obrażeń: {mnożnik_obrażeń}\t\t\t|");
Console.WriteLine($"| Obrażenia od broni: {Obrażenia_od_Broni}\t\t|");
Console.WriteLine($"| Obrażenia całkowite: {Obrażenia_całkowite}\t\t|");
Console.WriteLine($"| Ilość osób w grupie: {Ilosc_osob_w_grupie}\t\t|");
Console.WriteLine($"| Ilość złota: {Ilosc_zlota}\t\t\t|");
Console.WriteLine($"| Ilość złota na osobę: {złoto_na_osobę} reszta: {Ilosc_zlota % Ilosc_osob_w_grupie}\t|");



Console.WriteLine("+=======================================+");
Console.WriteLine("|                 Info                  |");
Console.WriteLine("+=======================================+");

// if zdriwie
if (Zdrowie < 50)
{
    Console.WriteLine("| Status zdrowia: Słabe\t\t\t|");
}
else if (Zdrowie >= 50 && Zdrowie < 80)
{
    Console.WriteLine("| Status zdrowia: Dobre\t\t\t|");
}
else if (Zdrowie >= 80 && Zdrowie <= 100)
{
    Console.WriteLine("| Status zdrowia: Doskonałe\t\t|");
}
else
{
    Console.WriteLine("| Status zdrowia: Nieprawidłowa wartość\t|");
}


// if plecak
if (Miejsce_w_plecaku < 5)
{
    Console.WriteLine("| Status plecaka: Mało miejsca\t\t|");
}
else if (Miejsce_w_plecaku >= 5 && Miejsce_w_plecaku < 8)
{
    Console.WriteLine("| Status plecaka: Wystarczająco miejsca\t|");
}
else if (Miejsce_w_plecaku >= 8 && Miejsce_w_plecaku <= 10)
{
    Console.WriteLine("| Status plecaka: Dużo miejsca\t\t|");
}
else
{
    Console.WriteLine("| Status plecaka: Nieprawidłowa wartość\t|");
}

// if złoto
if (złoto_na_osobę < 10)
{
    Console.WriteLine("| Status złota: Mało złota\t\t|");
}
else if (złoto_na_osobę >= 10 && złoto_na_osobę < 50)
{
    Console.WriteLine("| Status złota: Wystarczająco złota\t|");
}
else if (złoto_na_osobę >= 50)
{
    Console.WriteLine("| Status złota: Dużo złota\t\t|");
}
else
{
    Console.WriteLine("| Status złota: Nieprawidłowa wartość\t|");
}

// switch mapa
switch (Posiadanie_mapy.ToLower())
{
    case "tak":
        Console.WriteLine("| Status mapy: Posiadasz mapę\t\t|");
        break;
    case "nie":
        Console.WriteLine("| Status mapy: Nie posiadasz mapy\t|");
        break;
    default:
        Console.WriteLine("| Status mapy: Nieprawidłowa wartość\t|");
        break;
}

Console.WriteLine("+=======================================+");
