first_number = int(input('Введите первое число--> '))
second_number = int(input('Введите второе число--> '))
def summa(a, b):
    a += 1
    b -= 1
    if b > 0:
        return summa(a, b)
    else:
        return a


print (summa(first_number, second_number))