# Conversor Celsius-Fahrenheit & Farenheit-Celsius

def fahr_cels():
    fahr = float(input("Introduzca la temperatura en ºF: "))
    cels = round(((fahr-32)*(5.0/9.0)),3)
    return '{} grados Fahrenheit es igual a {} grados Celsius'.format(fahr, cels)

def cels_fahr():
    cels = float(input("Introduzca la temperatura en ºC: "))
    fahr = round((cels * (9.0/5.0) +32),3)
    return '{} grados Celsius es igual a {} grados Fahrenheit'.format(cels, fahr)

while True:
    print("¿QUÉ OPERACIÓN DESEA HACER?\n")
    print("1-> De Fahrenheit a Celsius: ")
    print("2-> De Celsius a Fahrenheit: ")
    print("0-> Presione otra tecla para salir.\n")

    try:
        opt = int(input("Elija una opción: "))
        if opt == 1:
            print(fahr_cels())
        elif opt == 2:
            print(cels_fahr())
        else:
            break
    except ValueError:
        print("Introduzca una opción válida.\n")