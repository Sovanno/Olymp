import numpy as np
n = int(input())
arr = np.array([])
count = 0
count_res = 0
answer = np.zeros((n, 2))
comb = np.array([[[0, 1, 2], [0, 3, 2]], [[1, 2, 3], [1, 0, 3]], [[2, 1, 0], [2, 3, 0]], [[3, 2, 1], [3, 0, 1]]])
combinations = np.array([[0, 1, 2], [0, 3, 2], [1, 2, 3], [1, 0, 3]])
for i in range(n):
    a = np.array(list(map(int, input().split(" "))))
    arr = np.append(arr, a)
arr = arr.reshape((n, 4, 5)).astype("int").astype("str")
partition = []
for i in range(2 * n):
    a = ''.join(input().split(" "))
    partition.append(a)
i = 0
while i < n:
    for j in range(4):
        num = ''.join(list(np.concatenate((arr[i, comb[j, 0, 0], :], arr[i, comb[j, 0, 1], :], arr[i, comb[j, 0, 2], :]))))
        num_rev = ''.join(list(np.concatenate((arr[i, comb[j, 1, 0], :][::-1], arr[i, comb[j, 1, 1], :][::-1], arr[i, comb[j, 1, 2], :][::-1]))))
        if num not in partition:
            num = ''.join(list(np.concatenate((arr[i, comb[j, 0, 2], :], arr[i, comb[j, 0, 1], :], arr[i, comb[j, 0, 0], :]))))
            if num not in partition:
                num = ''.join(list(np.concatenate((arr[i, comb[j, 0, 2], :][::-1], arr[i, comb[j, 0, 1], :][::-1], arr[i, comb[j, 0, 0], :][::-1]))))
                if num not in partition:
                    num = ''.join(list(np.concatenate((arr[i, comb[j, 0, 0], :][::-1], arr[i, comb[j, 0, 1], :][::-1], arr[i, comb[j, 0, 2], :][::-1]))))
        if num_rev not in partition:
            num_rev = ''.join(list(np.concatenate((arr[i, comb[j, 1, 2], :][::-1], arr[i, comb[j, 1, 1], :][::-1], arr[i, comb[j, 1, 0], :][::-1]))))
            if num_rev not in partition:
                num_rev = ''.join(list(np.concatenate((arr[i, comb[j, 1, 0], :][::-1], arr[i, comb[j, 1, 1], :][::-1], arr[i, comb[j, 1, 2], :][::-1]))))
                if num_rev not in partition:
                    num_rev = ''.join(list(np.concatenate((arr[i, comb[j, 1, 2], :], arr[i, comb[j, 1, 1], :], arr[i, comb[j, 1, 0], :]))))
        try:
            index = partition.index(num)
            index_rev = partition.index(num_rev)
            answer[i, 0] = index + 1
            answer[i, 1] = index_rev + 1
        except ValueError:
            continue
    i += 1
for i in range(answer.shape[0]):
    print(sorted(answer[i, :]))
