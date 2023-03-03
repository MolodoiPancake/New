import random
number = int(input('Введите число: '))
my_list = []
n = 0
closest_num = -1

for i in range(20):
    my_list.append(random.randint(1, 101))
    min_d = max(my_list) - number
    if int(my_list[i]) == number:
        n += 1


for i in set(my_list):
    if abs(i - number) < min_d:
        min_d = abs(i - number)
        closest_num = i


print(f'{n} раз встречается в заданном списке число {number}')
print(f'максимально близкое число {closest_num}')
print(f'список {my_list}')
print(f'список без повторных чисел {set(my_list)}')
