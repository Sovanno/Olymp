Matr = [
    [0, 10, 18, 8, 2**62, 2**62],
    [10, 0, 16, 9, 21, 2**62],
    [2**62, 16, 0, 2**62, 2**62, 15],
    [7, 9, 2**62, 0, 2**62, 12],
    [2**62, 2**62, 2**62, 2**62, 0, 23],
    [2**62, 2**62, 15, 2**62, 23, 0]
]

for k in range(len(Matr)):
    for i in range(len(Matr)):
        for j in range(len(Matr)):
            Matr[i][j] = min(Matr[i][j], Matr[i][k] + Matr[k][j]);

print(Matr)
