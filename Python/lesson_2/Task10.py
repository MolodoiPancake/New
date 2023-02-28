Coins = int(input('Введите количество монет '))
print('Введите цифру (где 0 - орел, а 1 - решка )')
eagle = 0
tails = 0

for i in range(Coins):
    value = int(input())
    if value == 0:
        eagle += 1
    else:
        tails += 1
        

if eagle > tails:
    print(f'Нужно перевернуть{tails} tails')
else:
    print(f'Нужно перевернуть {eagle} eagle')
