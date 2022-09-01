# Calculaodra

num1 = float(input("Introduce el primer número: "))
num2 = float(input("Introduce el segundo número: "))

opt = 0
while True:

    print("""\n\n
    ¿Qué operación quieres hacer?
    1-> Sumar
    2-> Restar
    3-> Multiplicar
    4-> Dividir
    5-> Resto
    6-> Cambiar los números
    7-> Salir
    """)

    opt = int(input("Elige una opción: "))

    if opt == 1:
        print(f"Resultado de la suma: {num1} + {num2} = {num1+num2}\n")

    elif opt == 2:
        print(f"Resultado de la resta: {num1} - {num2} = {num1-num2}\n")

    elif opt == 3:
        print(f"Resultado de la multiplicación: {num1} * {num2} = {num1*num2}\n")

    elif opt == 4:
        print(f"Resultado de la división: {num1} / {num2} = {num1/num2}\n")

    elif opt == 5:
        print(f"Resto de la división: {num1} / {num2} = {num1%num2}\n")

    elif opt == 6:
        num1 = float(input("Introduce el primer número: "))
        num2 = float(input("Introduce el segundo número: "))

    elif opt == 7:
        break

    else:
        print("Elija una opción válida.")
        continue

