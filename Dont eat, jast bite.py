import numpy as np

from dijkstra import dijkstra

max_int = float('inf')
n, m = [int(i) for i in input().split()]
graph = [(0, max_int)]
apple = {}
for i in range(n):
    k, l = [int(i) for i in input().split()]
    graph.append((k, l))

arr = np.full((n + 1, n + 1), max_int)
for i in range(1, n + 1):
    arr[i, graph[i][0]] = graph[i][1]
    arr[graph[i][0], i] = arr[i, graph[i][0]]

for i in range(m):
    c, s = [int(i) for i in input().split()]
    apple[c] = s

x, z = [int(i) for i in input().split()]
for i in apple.copy().keys():
    if apple[i] < z:
        del apple[i]

if x in apple.keys():
    del apple[x]
sum_min_way = 0
while len(apple) > 0:
    key_apple = list(apple.keys())
    way = dijkstra(arr.copy(), x)
    min_way = min([way[i] for i in apple.keys()])
    for key in way.copy().keys():
        if key not in apple.keys():
            del way[key]
    index_min_way = list(way.values()).index(min_way)
    del_key = list(way.keys())[index_min_way]
    del apple[del_key]
    sum_min_way += min_way
    x = del_key
print(sum_min_way)
