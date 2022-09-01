# Mostrar n primeros primos.

numprim=int(input("¿Cuántos números quieres mostrar?"))

k=1     # Contador de números
i=3     # Número a comprobar

if numprim==1:
    print("1 -> 2")

elif numprim>=1:
    while k<numprim:
        for j in range(2,i):
            if i%j == 0:
                break
            if j==i-1:
                k = k + 1
                print(f"{k} -> {i}")
        i = i + 1

else:print("Introduce un número válido.")