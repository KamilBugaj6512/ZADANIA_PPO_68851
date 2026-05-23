using System;

Console.WriteLine("Kalkulator, podaj dwie liczby i wybierz dzialanie");
Console.WriteLine("1 DODAWANIE");
Console.WriteLine("2 ODEJMOWANIE");
Console.WriteLine("3 MNOŻENIE");
Console.WriteLine("4 DZIELENIE");

Console.Write("podaj pierwsza liczbe: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("podaj drugą liczbe: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("wybierz działanie: ");
int wybor = Convert.ToInt32(Console.ReadLine());

if (wybor == 1)
{
    Console.WriteLine("Wynik dodawania: " + (a + b));
}
else if (wybor == 2)
{
    Console.WriteLine("Wynik odejmowania: " + (a - b));
}
else if (wybor == 3)
{
    Console.WriteLine("Wynik mnozenia: " + (a * b));
}
else if (wybor == 4)
{
    if (b == 0)
    {
        Console.WriteLine("Błąd: Nie można dzielić przez zero!");
    }
    else
    {
        Console.WriteLine("wynik dzielenia: " + (a / b));
    }
}
else if (wybor > 4 || wybor < 1)
{
    Console.WriteLine("Nie ma takiego wyboru!!");
}