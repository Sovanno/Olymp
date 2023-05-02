from collections import defaultdict

def bellman_ford(graph, start):
    distance = {}
    for node in graph:
        distance[node] = float('inf')
    distance[start] = 0

    for i in range(len(graph) - 1):
        for u in graph:
            for v, w in graph[u].items():
                if distance[u] != float('inf') and distance[u] + w < distance[v]:
                    distance[v] = distance[u] + w

    for u in graph:
        for v, w in graph[u].items():
            if distance[u] != float('inf') and distance[u] + w < distance[v]:
                raise ValueError("Граф содержит отрицательный цикл")

    return distance

graph = defaultdict(dict)
graph['A']['B'] = 1
graph['A']['E'] = 3
graph['B']['C'] = 8
graph['B']['D'] = 7
graph['B']['E'] = 1
graph['C']['D'] = 1
graph['C']['E'] = -5
graph['D']['C'] = 2
graph['E']['D'] = 4

print(bellman_ford(graph, 'A'))
