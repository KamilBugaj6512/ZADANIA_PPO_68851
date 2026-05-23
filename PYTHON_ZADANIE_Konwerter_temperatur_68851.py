print("Konwerter temperatur, wybierz kierunek przeliczenia")
print("1 Zamiana Celsjusz na Fahrenheit (°C -> °F)")
print("2 Zamiana Fahrenheit na Celsjusz (°F -> °C)")

wybor = int(input("wybierz działanie: "))

if wybor == 1:
    celsjusz = float(input("Podaj temperaturę w stopniach Celsjusza: "))
    fahrenheit = celsjusz * 1.8 + 32
    print("Wynik w stopniach Fahrenheit: ", fahrenheit)
elif wybor == 2:
    fahrenheit = float(input("Podaj temperaturę w stopniach Fahrenheita: "))
    celsjusz = (fahrenheit - 32) / 1.8
    print("Wynik w stopniach Celsjusza: ", celsjusz)
elif wybor > 2 or wybor < 1:
    print("Nie ma takiego wyboru!!")