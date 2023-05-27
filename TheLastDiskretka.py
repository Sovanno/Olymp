Matr = [[1, 1, 1, 0, 0],
        [1, 1, 1, 0, 0],
        [1, 1, 1, 1, 0],
        [0, 0, 1, 1, 1],
        [0, 0, 0, 1, 1]]

citys = [0, 1, 2, 3, 4]

comp = [0]

answer = [0, 0]

count = 1

MatrFikts = [[1, 1, 1, 0, 0],
             [1, 1, 1, 0, 0],
             [1, 1, 1, 1, 0],
             [0, 0, 1, 1, 1],
             [0, 0, 0, 1, 1]]

for i in range(5):
    print(i)
    for j in range(5):
        print(j)
        if i != j:
            MatrFikts[i][j] = 0
            MatrFikts[j][i] = 0
        while len(citys) != 0:
            for i in range(5):
                if Matr[comp[0]][i] == 1 and i in citys:
                    comp.append(i)
                    Matr[comp[0]][i] = 0
                    Matr[i][comp[0]] = 0
                    citys.remove(i)
            comp.remove(comp[0])
            if len(comp) == 0 and len(citys) != 0:
                comp.append(citys[0])
                count += 1
        #print(count)
        if count > 1:
            answer = [i, j]
            break
        else:
            count = 1
            comp = [0]
            citys = [0, 1, 2, 3, 4]
            MatrFikts = Matr
    if count > 1:
        break
    else:
        continue
print(answer[0], answer[1])
