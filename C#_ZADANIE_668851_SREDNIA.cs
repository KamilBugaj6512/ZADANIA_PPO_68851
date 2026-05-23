using System;

Console.WriteLine("Program do obliczania średniej ocen ucznia");

Console.Write("Podaj ile ocen chcesz wprowadzic: ");
int liczbaOcen = Convert.ToInt32(Console.ReadLine());
double sumaOcen = 0;

for (int i = 0; i < liczbaOcen; i++)
{
    Console.Write("Podaj kolejną ocenę (1-6): ");
    double ocena = Convert.ToDouble(Console.ReadLine());
    sumaOcen = sumaOcen + ocena;
}

double srednia = sumaOcen / liczbaOcen;
Console.WriteLine("Średnia ocen wynosi: " + Math.Round(srednia, 2));

if (srednia >= 3.0)
{
    Console.WriteLine("Uczeń zdał.");
}
else
{
    Console.WriteLine("Uczeń nie zdał.");
}