# Suma o multiplicación

num1=input("Introduzca el primer número: \n")
num2=input("Introduzca el segundo número: \n")
num3=input("Introduzca el tercer número: \n")
try:
    num1=float(num1)
    num2=float(num2)
    num3=float(num3)
    if(num1<10):
        resul=num1*num2*num3
    else:
        resul=num1+num2+num3
    print(resul)
except ValueError:
    print("Error: los datos deben ser numéricos.")
except:
    print("Error")