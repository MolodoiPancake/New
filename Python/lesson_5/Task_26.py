number = int(input("Введите число--> "))
power = int(input("Введите его степень--> "))

def rate(number, power):
    if (power == 1):
        return (number)
    if (power != 1):
        return (number * power(number, power - 1))

print("Ответ", power(number, power))