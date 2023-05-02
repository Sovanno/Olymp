from collections import defaultdict

def ford_fulkerson(graph, source, sink):
    def bfs(graph, s, t, parent):
        visited = [False] * len(graph)
        queue = []
        queue.append(s)
        visited[s] = True

        while queue:
            u = queue.pop(0)

            for ind, val in enumerate(graph[u]):
                if not visited[ind] and val > 0:
                    queue.append(ind)
                    visited[ind] = True
                    parent[ind] = u

        return visited[t]

    max_flow = 0

    residual_graph = [graph[i].copy() for i in range(len(graph))]

    parent = [-1] * len(graph)
    while bfs(residual_graph, source, sink, parent):
        path_flow = float("Inf")
        s = sink

        while s != source:
            path_flow = min(path_flow, residual_graph[parent[s]][s])
            s = parent[s]

        v = sink
        while v != source:
            u = parent[v]
            residual_graph[u][v] -= path_flow
            residual_graph[v][u] += path_flow
            v = parent[v]

        max_flow += path_flow

    return max_flow


graph = [[0, 95, 0, 0, 75, 32, 57, 0],
         [0, 0, 6, 0, 18, 0, 0, 0],
         [0, 0, 0, 7, 0, 0, 11, 0],
         [0, 0, 0, 0, 0, 0, 0, 81],
         [0, 0, 9, 0, 0, 0, 24, 0],
         [0, 5, 0, 0, 0, 0, 20, 16],
         [0, 0, 0, 20, 0, 0, 0, 94],
         [0, 0, 0, 0, 0, 0, 0, 0]]

source = 0
sink = 5

print("Максимальный поток: ", ford_fulkerson(graph, source, sink))
