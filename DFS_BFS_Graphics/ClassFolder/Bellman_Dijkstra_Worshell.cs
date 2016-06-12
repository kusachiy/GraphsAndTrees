using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_BFS_Graphics
{
    public static class Bellman_Dijkstra_Worshell
    {
        private struct Edge
        {
            public int a, b, cost;

            public Edge(int _a, int _b, int _cost)
            {
                a = _a;
                b = _b;
                cost = _cost;
            }
        }

        public static int[] FordBellman(int[,] matrix, int startVertex)
        {
            int n = matrix.GetLength(0);
            int m = matrix.Length;
            int[] result = new int[n];
            Edge[] e = MatrixToEdgesList(matrix);
            FillArray(result, int.MaxValue);
            result[startVertex] = 0;
            for (int i = 0; i < n - 1; ++i)
                for (int j = 0; j < m; ++j)
                    if (result[e[j].a] < int.MaxValue)
                        result[e[j].b] = Math.Min(result[e[j].b], result[e[j].a] + e[j].cost);
            return result;
        }

        public static int[,] FloydWorschell(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int k = 0; k < n; ++k)
                for (int i = 0; i < n; ++i)
                    for (int j = 0; j < n; ++j)
                        matrix[i, j] = Math.Min(matrix[i, j], matrix[i, k] + matrix[k, j]);
            return matrix;
        }

        public static int[] Deikstra(int[,] matrix, int startVertex)
        {
            KeyValuePair<int, int>[][] g = ArrayToPairs(matrix);
            int count = matrix.GetLength(0);
            int[] d = new int[count], p = new int[count];
            FillArray(d, int.MaxValue);
            d[startVertex] = 0;
            bool[] u = new bool[count];
            for (int i = 0; i < count; ++i)
            {
                int v = -1;
                for (int j = 0; j < count; ++j)
                    if (!u[j] && (v == -1 || d[j] < d[v]))
                        v = j;
                if (d[v] == int.MaxValue)
                    break;
                u[v] = true;

                for (int j = 0; j < g[v].Length; ++j)
                {
                    int to = g[v][j].Key,
                    len = g[v][j].Value;
                    if (d[v] + len < d[to])
                    {
                        d[to] = d[v] + len;
                        p[to] = v;
                    }
                }
            }
            return d;
        }

        static void FillArray(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = value;
        }

        static KeyValuePair<int, int>[][] ArrayToPairs(int[,] matrix)
        {
            List<KeyValuePair<int, int>[]> pairs = new List<KeyValuePair<int, int>[]>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                KeyValuePair<int, int>[] list = new KeyValuePair<int, int>[matrix.GetLength(0)];
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    list[j] = new KeyValuePair<int, int>(j, matrix[i, j]);
                }
                pairs.Add(list);
            }
            return pairs.ToArray();
        }

        static Edge[] MatrixToEdgesList(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            List<Edge> list = new List<Edge>();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    list.Add(new Edge(i, j, matrix[i, j]));
            return list.ToArray();
        }
    }
}

