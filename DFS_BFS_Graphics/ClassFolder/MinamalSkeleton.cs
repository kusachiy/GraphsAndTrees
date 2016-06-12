using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_BFS_Graphics
{
    public static class MinamalSkeleton
    {
        public static int[,] Prima(int[,] matrix)
        {
            int count = matrix.GetLength(0);
            int[,] skeleton = new int[count, count];
            bool[] used = new bool[count];
            int[] min_e = new int[count], sel_e = new int[count]; // (n, INF), sel_e(n, -1);
            min_e.For((e) => { return int.MaxValue; });
            sel_e.For((e) => { return -1; });
            min_e[0] = 0;
            int sum = 0;
            for (int i = 0; i < count; ++i)
            {
                int v = -1;
                for (int j = 0; j < count; ++j)
                    if (!used[j] && (v == -1 || min_e[j] < min_e[v]))
                        v = j;

                used[v] = true;
                if (sel_e[v] != -1)
                {
                    Console.WriteLine(v + 1 + " " + (sel_e[v] + 1));
                    sum += skeleton[v, sel_e[v]] = matrix[v, sel_e[v]];
                    skeleton[sel_e[v], v] = matrix[sel_e[v], v];
                }
                for (int to = 0; to < count; ++to)
                    if (matrix[v, to] < min_e[to])
                    {
                        min_e[to] = matrix[v, to];
                        sel_e[to] = v;
                    }
            }
            return skeleton;
        }

        public static int[,] Kruskala(int[,] matrix)
        {
            KeyValuePair<int, KeyValuePair<int, int>>[] g = ArrayToPairs(matrix);
            int count = matrix.GetLength(0);
            int[,] ostov = new int[count, count];
            int cost = 0;
            List<KeyValuePair<int, int>> res = new List<KeyValuePair<int, int>>();
            g = SortArray(g);
            int[] tree_id = new int[count];
            for (int i = 0; i < count; ++i)
                tree_id[i] = i;
            for (int i = 0; i < count * count; ++i)
            {
                int a = g[i].Value.Key, b = g[i].Value.Value, l = g[i].Key;
                if (tree_id[a] != tree_id[b])
                {
                    cost += l;
                    ostov[a, b] = matrix[a, b];
                    ostov[b, a] = matrix[a, b];
                    res.Add(new KeyValuePair<int, int>(a, b));
                    int old_id = tree_id[b], new_id = tree_id[a];
                    for (int j = 0; j < count; ++j)
                        if (tree_id[j] == old_id)
                            tree_id[j] = new_id;
                }
            }
            return ostov;
        }

        static int[] Deikstra(int[,] matrix, KeyValuePair<int, int>[][] g, int s)
        {
            int count = matrix.GetLength(0);
            int[] d = new int[count], p = new int[count];
            FillArray(d, int.MaxValue);
            d[s] = 0;
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

        static KeyValuePair<int, KeyValuePair<int, int>>[] SortArray(KeyValuePair<int, KeyValuePair<int, int>>[] a)
        {
            for (int k = a.Length - 1; k > 0; k--)
                for (int i = 0; i < k; i++)
                    if (a[i].Key > a[i + 1].Key)
                    {
                        var buf = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = buf;
                    }
            return a;
        }
        static KeyValuePair<int, KeyValuePair<int, int>>[] ArrayToPairs(int[,] matrix)
        {
            List<KeyValuePair<int, KeyValuePair<int, int>>> pairs = new List<KeyValuePair<int, KeyValuePair<int, int>>>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    pairs.Add(new KeyValuePair<int, KeyValuePair<int, int>>(matrix[i, j], new KeyValuePair<int, int>(i, j)));
                }
            }
            return pairs.ToArray();
        }
    }

    static class Extensions
    {
        public static void For<T>(this T[] arr, Func<T, T> func)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = func(arr[i]);
            }
        }

    }
        
    
}
