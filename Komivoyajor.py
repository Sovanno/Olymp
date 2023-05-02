import itertools


def tsp(cities):
    all_permutations = itertools.permutations(cities)

    shortest_distance = float("inf")

    for permutation in all_permutations:
        distance = 0
        for i in range(len(permutation) - 1):
            distance += cities[permutation[i]][permutation[i + 1]]

        shortest_distance = min(shortest_distance, distance)
        #print(shortest_distance)

    return shortest_distance


cities = {
    "A": {"B": 6, "C": 4, "D": 8, "E": 7},
    "B": {"A": 6, "C": 7, "D": 11, "E": 7},
    "C": {"A": 4, "B": 7, "D": 4, "E": 3},
    "D": {"A": 8, "B": 11, "C": 4, "E": 5},
    "E": {"A": 7, "B": 7, "C": 3, "D": 5}
}
print(tsp(cities))
