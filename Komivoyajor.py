import numpy as np

max_int = np.inf
arr = np.array([
    [0, 3, 1, 8],
    [3, 0, 4, 4],
    [1, 4, 0, 7],
    [8, 4, 7, 0]
])
arr = np.where(arr == 0, max_int, arr)
arr_copy = arr.copy()
col = [i for i in range(arr.shape[0])]
row = col.copy()
way = {}
output = 0
while arr_copy.shape[0] > 1:
    arr_min_line = []
    arr_min_col = []
    for i in range(arr_copy.shape[0]):
        arr_min_line.append(np.min(arr_copy[i, :]))
        arr_copy[i , :] -= arr_min_line[-1]

    for i in range(arr_copy.shape[1]):
        arr_min_col.append(np.min(arr_copy[:, i]))
        arr_copy[:, i] -= arr_min_col[-1]

    index_max_num, sum_max_degree = [0, 0], 0
    for i in range(arr_copy.shape[0]):
        for j in range(arr_copy.shape[1]):
            sum_degree = arr_min_col[i] + arr_min_line[j]
            if sum_degree > sum_max_degree and i != j:
                index_max_num = [j, i]
                sum_max_degree = sum_degree
    arr_copy = np.delete(arr_copy, index_max_num[0], axis=0)
    arr_copy = np.delete(arr_copy, index_max_num[1], axis=1)
    way[row[index_max_num[0]]] = col[index_max_num[1]]
    row.pop(index_max_num[0])
    col.pop(index_max_num[1])
    output += np.sum(arr_min_col)
    output += np.sum(arr_min_line)

print(output)
