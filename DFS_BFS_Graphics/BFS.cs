using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_BFS_Graphics
{
    static class BFS
    {
        public static List<int> Search(int[,] matrix,int start, int search)
        {
            int size = matrix.GetLength(0);
            bool[] visited = new bool[size];
            List<int> listik = new List<int>();
            Queue<int> queue = new Queue<int>();
            visited[start] = true;

            queue.Enqueue(start);
            listik.Add(start);
            while (queue.Count != 0)
            {

                start = queue.Peek();
                queue.Dequeue();
                List<int> iteration = new List<int>();
                for (int i = 0; i < size; i++)
                {

                    if (matrix[start, i] != 0)
                    {
                        int buf = i;
                        if (!visited[buf])
                        {
                            iteration.Add(buf);
                            if (buf == search)
                            {
                                listik.AddRange(iteration);
                                return listik;
                            }
                            visited[buf] = true;
                            queue.Enqueue(buf);
                        }
                    }
                }
                listik.AddRange(iteration);
            }
            return listik;
        }
    }
}
