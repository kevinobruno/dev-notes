print('Welcome to the tip calculator')

bill = float(input('What was the total bill? $'))
tip = int(input('What percentage tip would you like to give? 10, 12, or 15? '))
people = int(input('How many people to split the bill? '))

tip_as_percent = ((tip / 100) + 1)
bill_with_tip = bill * tip_as_percent
bill_per_person = round(bill_with_tip / people, 2)
bill_per_person_formatted = '{:.2f}'.format(bill_per_person)

print(f'Each person should pay ${bill_per_person_formatted}')
