using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_BFS_Graphics
{
    static class DFS
    {
        //Queue<int> queue = new Queue<int>();
        public static List<int> Search(int[,] matrix,int start, int search)
        {
            int size = matrix.GetLength(0);
            bool[] visited = new bool[size];
            List<int> listik = new List<int>();
            Stack<int> stack = new Stack<int>();
            visited[start] = true;
            bool offset = true;
            int current = start;
            stack.Push(start);

            while (true)
            {
                offset = false;
                start = current;
                listik.Add(start);
                for (int i = 0; i < size; i++)
                {
                    if (matrix[start, i] != 0)
                    {
                        int buf = i;
                        if (!visited[buf])
                        {
                            stack.Push(buf);
                            visited[buf] = true;
                            offset = true;
                            current = buf;
                            break;

                        }
                    }
                }
                if (current == search)
                {
                    listik.Add(search);
                    break;
                }
                if (offset == false)
                {
                    if (stack.Count > 0)
                    {
                        current = stack.Pop();
                        offset = true;
                    }
                    else
                        break;
                }
            }
            return listik;
        }
    }
}
