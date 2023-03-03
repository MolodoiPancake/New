eng = 'qwertyuiopasdfghjklzxcvbnm'
rus = 'йцукенгшщзхъыфвапролджэячсмитьбюё'

eng_list = {1: 'AELOULNSTR', 2: 'DG', 3: 'BCMP', 4: 'FHVWY', 5: 'K', 8: 'JX', 10: 'QZ'}
rus_list = {1: 'АВЕИНОРСТ', 2: 'ДКЛМПУ', 3: 'БГЁЬЯ', 4:'ЙЫ', 5:'ЖЗХЦЧ', 8:'ШЭЮ', 10:'ФЩЪ'}

word = input('Введите слово ')

if word[0].lower() in eng:
    summa = 0
    for letter in word:
        for key, value in eng_list.items():
            if letter.upper() in value:
                summa += key
    print(f'Стоймость английского слова - {summa}')

else:
    if word[0].lower() in rus:
        summa = 0
        for letter in word:
            for key, value in rus_list.items():
                if letter.upper() in value:
                    summa += key
    print(f'Стоймость русского слова - {summa}')

