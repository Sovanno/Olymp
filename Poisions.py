des = {"MIX": ["MX", "XM"],
       "WATER": ["WT", "TW"],
       "DUST": ["DT", "TD"],
       "FIRE": ["FR", "RF"]}

answ = []
count = int(input())
for i in range(count):
    spel = input().split(" ")
    s = des[spel[0]][0]
    for i in range(1, len(spel)):
        if spel[i].isdigit():
            s += answ[int(spel[i]) - 1]
        else:
            s += spel[i]
    s += des[spel[0]][1]
    answ.append(s)
print(answ[-1])
