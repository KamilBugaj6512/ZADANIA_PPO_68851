print("Program do obliczania średniej ocen ucznia")

liczba_ocen = int(input("Podaj ile ocen chcesz wprowadzic: "))
suma_ocen = 0

# Pętla for zapyta o ocenę dokładnie tyle razy, ile wpisałeś powyżej
for i in range(liczba_ocen):
    ocena = float(input("Podaj kolejną ocenę (1-6): "))
    suma_ocen = suma_ocen + ocena

srednia = suma_ocen / liczba_ocen
print("Średnia ocen wynosi: ", round(srednia, 2))

if srednia >= 3.0:
    print("Uczeń zdał.")
else:
    print("Uczeń nie zdał.")
