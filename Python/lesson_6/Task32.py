list_1 = [3, 5, 1, 7, -4, 0, -1, 9, 6, -8]
min_number = int(input('Введите максимальное число '))
max_number = int(input('Введите минимальное число '))
for i in range(len(list_1)):
    if min_number <= list_1[i] <= max_number:
        print(i)
