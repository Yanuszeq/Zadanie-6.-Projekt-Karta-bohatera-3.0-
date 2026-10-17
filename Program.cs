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

Console.WriteLine("Czy posiadasz mikstury leczenia? (tak/nie) : ");
string leczenie = Console.ReadLine();

Console.WriteLine("Czy posiadasz jedzenie? (tak/nie) : ");
string jedzenie = Console.ReadLine();

double mnożnik_obrażeń = 1.5;

int Obrażenia_od_Broni = 10;

double Obrażenia_całkowite = (mnożnik_obrażeń * (Siła + Obrażenia_od_Broni));

int złoto_na_osobę = Ilosc_zlota / Ilosc_osob_w_grupie;


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("+=======================================+");
Console.Write("|            ");
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.Write("KARTA BOHATERA");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("             |");
Console.WriteLine("+=======================================+");
Console.ResetColor(); 

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine($"| Imię bohatera: {Imie}\t\t\t|");

if (Miejsce_w_plecaku > 10)
{
    Console.WriteLine($"| Miejsce w plecaku: zła wartość\t|");
}
else
{
Console.WriteLine($"| Miejsce w plecaku: {Miejsce_w_plecaku}/10\t\t|");
}

if (Zdrowie > 100)
{
    Console.WriteLine($"| HP: Zła wartość\t\t\t|");
}
else 
{
Console.WriteLine($"| HP: {Zdrowie}\t\t\t\t|");
}

Console.WriteLine($"| Siła: {Siła}\t\t\t\t|");
Console.WriteLine($"| Mnożnik obrażeń: {mnożnik_obrażeń}\t\t\t|");
Console.WriteLine($"| Obrażenia od broni: {Obrażenia_od_Broni}\t\t|");
Console.WriteLine($"| Obrażenia całkowite: {Obrażenia_całkowite}\t\t|");
Console.WriteLine($"| Ilość osób w grupie: {Ilosc_osob_w_grupie}\t\t|");
Console.WriteLine($"| Ilość złota: {Ilosc_zlota}\t\t\t|");
Console.WriteLine($"| Ilość złota na osobę: {złoto_na_osobę} reszta: {Ilosc_zlota % Ilosc_osob_w_grupie}\t|");


// switch leczenie
switch (leczenie.ToLower())
{
    
case "tak":
Console.WriteLine("| Mikstury leczenia: tak\t\t|");
break;
    
case "nie":
Console.WriteLine("| Mikstury leczenia: nie\t\t|");
break;

default:
Console.WriteLine("| Mikstury: nieprawidłowa wartość\t|");
break;
}


//switch jedzenie
switch (jedzenie.ToLower())
{
    
case "tak":
Console.WriteLine("| Jedzenie: tak\t\t\t\t|");
break;
    
case "nie":
Console.WriteLine("| Jedzenie: nie\t\t\t\t|");
break;

default:
Console.WriteLine("| Jedzenie: nieprawidłowa wartość\t|");
break;
}

if (leczenie.ToLower() == "tak" || jedzenie.ToLower() == "tak")
{
    Console.WriteLine("| Leczenie: możliwe\t\t\t|");
}
else 
{
    Console.WriteLine("| Leczenie: niemożliwe\t\t\t|");
}

Console.ResetColor(); 
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("+=======================================+");


Console.Write("|                 ");
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.Write("Info");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("                  |");


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("+=======================================+");


Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Blue;

// if zdrowie
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
string status_plecaka = ( Miejsce_w_plecaku > 5)? "| Plecak: mało miejsca\t\t\t|" : "| Plecak: dużo miejsca\t\t\t|";
Console.WriteLine($"{status_plecaka}");
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

// mapa
if (Posiadanie_mapy.ToLower() != "nie")
{
    Console.WriteLine("| Status mapy: Posiadasz mapę\t\t|");
}
else
{
    Console.WriteLine("| Status mapy: Nie posiadasz mapy\t|");
}

Console.WriteLine("+=======================================+");
Console.ResetColor(); 