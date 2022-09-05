# Divisores de un número

num = input("¿De qué número quiere saber los divisores? ")
if (num.isdigit()):
    num = int(num)
    div = 1
    for div in range (1, num + 1):
        if num % div == 0:
            print(div)
else: print("Introduzca un número válido.")