R = [(5, 1, 2), (1, 1, 3), (3, 1, 4), (9, 1, 5), (2, 2, 3),
     (1, 2, 5), (4, 3, 4), (3, 3, 4), (2, 4, 5)]

Rs = sorted(R, key=lambda x: x[0])
U = set()
D = {}
T = []
count = 0

for r in Rs:
    if r[1] not in U or r[2] not in U:
        if r[1] not in U and r[2] not in U:
            D[r[1]] = [r[1], r[2]]
            D[r[2]] = D[r[1]]
        else:
            if not D.get(r[1]):
                D[r[2]].append(r[1])
                D[r[1]] = D[r[2]]
            else:
                D[r[1]].append(r[2])
                D[r[2]] = D[r[1]]

        T.append(r)
        U.add(r[1])
        U.add(r[2])

for r in Rs:
    if r[2] not in D[r[1]]:
        T.append(r)
        gr1 = D[r[1]]
        D[r[1]] += D[r[2]]
        D[r[2]] += gr1

for i in T:
    count = count + i[0]

print(T)
print(count)
