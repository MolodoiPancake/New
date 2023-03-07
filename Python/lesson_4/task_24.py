n = int(input('Введите число'))
my_list = list()
for i in range(n):
    x = int(input())
    my_list.append(x)

list_count = list()
for i in range(len(my_list) - 1):
    list_count.append(my_list[i - 1] + my_list[i] + my_list[i + 1])
list_count.append(my_list[-2] + my_list[-1] + my_list[0])
print(max(list_count))