print("Kalkulator,podaj dwie liczby i  wybierz dzialanie")
print("1 DODAWANIE")
print("2 ODEJMOWANIE")
print("3 MNOŻENIE")
print("4 DZIELIENIE")
a = int(input("podaj pierwsza liczbe: "))
b = int(input("podaj drugą liczbe: "))
wybor = int(input("wybierz działanie "))


if wybor == 1:
  print("Wynik dodawania: ",a+b)
elif wybor == 2:
  print("Wynik odejmowania: ",a-b)
elif wybor == 3:
   print("Wynik mnozenia: ", a*b)
elif wybor == 4:
    print("wynik dzielenia: ", a/b)
elif wybor >4 or wybor < 1:
    print("Nie ma takiego wyboru!!")


