using System;

Console.WriteLine("Konwerter temperatur, wybierz kierunek przeliczenia");
Console.WriteLine("1 Zamiana Celsjusz na Fahrenheit (°C -> °F)");
Console.WriteLine("2 Zamiana Fahrenheit na Celsjusz (°F -> °C)");

Console.Write("wybierz działanie: ");
int wybor = Convert.ToInt32(Console.ReadLine());

if (wybor == 1)
{
    Console.Write("Podaj temperaturę w stopniach Celsjusza: ");
    double celsjusz = Convert.ToDouble(Console.ReadLine());
    double fahrenheit = celsjusz * 1.8 + 32;
    Console.WriteLine("Wynik w stopniach Fahrenheit: " + fahrenheit);
}
else if (wybor == 2)
{
    Console.Write("Podaj temperaturę w stopniach Fahrenheita: ");
    double fahrenheit = Convert.ToDouble(Console.ReadLine());
    double celsjusz = (fahrenheit - 32) / 1.8;
    Console.WriteLine("Wynik w stopniach Celsjusza: " + celsjusz);
}
else if (wybor > 2 || wybor < 1)
{
    Console.WriteLine("Nie ma takiego wyboru!!");
}