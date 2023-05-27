def next_number(arr, value):
    count = 0
    for i in arr:
        if i < value:
            count += 1
        else:
            return count
    return count


first_system = input().split(" ")
n = int(first_system[0])
first_system = [int(first_system[i]) for i in range(len(first_system)) if i != 0]
original_nun = input().split(" ")
original_num = sorted([int(original_nun[i]) for i in range(len(original_nun)) if i != 0])
end_system = input().split(" ")
n_end = int(end_system[0])
end_system = [int(end_system[i]) for i in range(len(end_system)) if i != 0]
end_num = input().split(" ")
end_num = sorted([int(end_num[i]) for i in range(len(end_num)) if i != 0])
count_origin = [int(i) for i in input().split(" ")]

money = 0
money_out = []
take_away_arr = []
for i in range(len(count_origin)):
    take_away_arr.append(next_number(original_num, count_origin[i]))
for i in range(len(count_origin) - 1):
    print(take_away_arr[i])
    count_origin[i + 1] += (count_origin[i] - take_away_arr[i]) * first_system[i]
money += count_origin[-1]
money -= take_away_arr[-1]

if n_end > 1:
    money_out.append(money)
    for i in range(n_end - 2, -1, -1):
        remainder = money // end_system[i]
        money_out[-1] = money % end_system[i]
        money_out[-1] += next_number(end_num, money_out[-1])
        money_out.append(remainder)
        money = remainder
    money_out[-1] += next_number(end_num, money_out[-1])
    for i in reversed(money_out):
        print(i, end=" ")
else:
    print(money + next_number(end_num, money))
