# Suma de números pares

from re import I


num = int(input("¿Hasta qué número quieres sumar?: "))
resul = 0

for i in range (1, num + 1):
    if (i%2==0):
        resul = resul + i
print(f"La suma de los números pares entre 0 y {num} es: {resul}.")