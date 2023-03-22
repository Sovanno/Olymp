matr = [ 
        [0, 5, 1, 3, 9],
        [5, 0, 2, 0, 1],
        [1, 2, 0, 4, 3],
        [3, 0, 4, 0, 2],
        [9, 1, 3, 2, 0],
       ]
roud = {}
#city = 0
count = 0
citys = {3}
flag = 0
nextcity = 0
for i in range(4):
    for j in range(4):
        if matr[i][j] != 0:
            roud[i, '->', j] = matr[i][j]
#print(roud.items())
while len(citys) != 4:
    for i in citys:
        for j in range(4):
            if (i, '->', j) in roud:
                print((i, '->', j))
                if flag == 0 and j not in citys:
                    mini = i, '->', j
                    revers = j, '->', i
                    nextcity = j
                    flag = flag + 1
                    #print(mini)
                    #print(roud[mini])
                elif (j not in citys) and (roud[i, '->', j] < roud[mini]):
                    nextcity = j
                    mini = i, '->', j
                    revers = j, '->', i
                    #print(mini, "elif")
                    #print(roud[mini])
    citys.add(nextcity)
    #print(citys)
    count = count + roud[mini]
    del roud[mini]
    del roud[revers]
    flag = 0
    #print(mini)
    #print(roud.items())
    #print(nextcity)
print(count)
