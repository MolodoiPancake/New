number = int(input('Введите число '))
degree = 0
while 2 ** degree <= number:
    print(2 ** degree)
    degree += 1
