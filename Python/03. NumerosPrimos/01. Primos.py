# Determinar si un número introducido es primo.

numero = int(input("Introduzca un número: "))
esPrimo=True

for i in range (2, numero):
    if (numero % i == 0):
        esPrimo=False
        break
if esPrimo:
    print("Es PRIMO")
else:
    print("NO es primo")




    













