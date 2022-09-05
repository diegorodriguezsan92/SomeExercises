# Suma de los n primeros números naturales.

num = int(input("Indique hasta qué número natural quiere sumar: "))
resul = 0
for i in range (1, num+1):
    resul = resul + i
print(resul)
