# Cree una lista idéntica a partir de la list1 utilizando la comprensión de listas.

# 1st way
list1=[1,2,3,4,5]

list2= [n for n in list1]
print(list2)

# 2nd way
list3=[6,7,8,9]

list4=[]
for n in list3:
    list4.append(n)
print(list4)