# WHILE loop version

i = 1
while i <= 100:
    if (i%15) == 0:
        print ("fizzbuzz\n")
        i = i + 1
    elif (i%5) == 0:
        print ("buzz\n")
        i = i + 1
    elif (i%3) == 0:
        print ("fizz\n")
        i = i + 1
    else:
        print (i)
        i = i + 1