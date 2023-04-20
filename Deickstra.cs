using System;
using System.CodeDom.Compiler;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность графа");
            int dimension = int.Parse(Console.ReadLine());
            int[,] graph = new int[dimension, dimension];

            Console.WriteLine("Введите граф построчно");
            for (int i = 0; i < dimension; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                for (int j = 0; j < temp.Length; j++)
                {
                    graph[i, j] = int.Parse(temp[j]);
                }
            }

            Console.WriteLine("Введите рассматриваемую вершину графа");
            int startVertex = int.Parse(Console.ReadLine()) - 1;
            if (startVertex + 1 > dimension) Console.WriteLine("Такой вершины нету :)"); Environment.ExitCode = 0;      

            int[] distances = DijkstraAlgorithm(graph, startVertex);

            for (int i = 0; i < dimension; i++)
            {
                Console.WriteLine("Кратчайший путь из вершины " + startVertex + " к вершине" + i + ": " + distances[i]);
            }

            Console.ReadLine();
        }

        static int[] DijkstraAlgorithm(int[,] graph, int startVertex)
        {
            int dimension = graph.GetLength(0);
            int[] distances = new int[dimension];
            bool[] visited = new bool[dimension];

            for (int i = 0; i < dimension; i++)
            {
                distances[i] = int.MaxValue;
                visited[i] = false;
            }

            distances[startVertex] = 0;

            for (int i = 0; i < dimension - 1; i++)
            {
                int minDistance = int.MaxValue;
                int minVertex = 0;

                for (int j = 0; j < dimension; j++)
                {
                    if (!visited[j] && distances[j] < minDistance)
                    {
                        minDistance = distances[j];
                        minVertex = j;
                    }
                }

                visited[minVertex] = true;

                for (int k = 0; k < dimension; k++)
                {
                    if (!visited[k] && graph[minVertex, k] != 0 && distances[minVertex] != int.MaxValue && distances[minVertex] + graph[minVertex, k] < distances[k])
                    {
                        distances[k] = distances[minVertex] + graph[minVertex, k];
                    }
                }
            }
            return distances;
        }
    }
}
