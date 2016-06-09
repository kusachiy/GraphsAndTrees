using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLab3Semestr
{
  /*  class BFS
    {
        int size;
        Queue<int> queue = new Queue<int>();
        bool[] visited;
        double[,] matrix;
        public BFS(int size, double[,] matrix)
        {
            this.size = size;
            visited = new bool[size];
            this.matrix = matrix;
        }

        public List<List<int>> Search(int start, int search)
        {
            List<List<int>> listik = new List<List<int>>();
            visited[start] = true;

            queue.Enqueue(start);
            listik.Add(new List<int> { start });
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
                            visited[buf] = true;
                            queue.Enqueue(buf);
                        }
                    }
                }
                listik.Add(iteration);
            }
            return listik;
        }
    }
    class DFS
    {
        int size;
        //Queue<int> queue = new Queue<int>();
        bool[] visited;
        double[,] matrix;
        public DFS(int size, double[,] matrix)
        {
            this.size = size;
            visited = new bool[size];
            this.matrix = matrix;
        }

        public List<int> Search(int start, int search)
        {
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
    public class GrafSearchTest : IRunnable
    {
        public void Run()
        {
            StreamReader sr = new StreamReader(@"graf2.txt");
            string[] filetext = sr.ReadToEnd().Split();
            int size = int.Parse(filetext[0]);
            double[,] matrix = new double[size,size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i,j] = int.Parse(filetext[i * (size + 1) + j + 2]);
                }
            }
            BFS bfs = new BFS(size, matrix);
            Console.WriteLine("Поиск в ширину:");
            PrintList(bfs.Search(7,1));
            DFS dfs = new DFS(size, matrix);
            Console.WriteLine("Поиск в глубину:");
            PrintList(dfs.Search(7, 1));
        }
        public void PrintList(List<int> list)
        {
            Console.WriteLine("Порядок обхода:");
            for (int i = 0; i < list.Count-1; i++)
            {
                Console.Write(i + "->");
            }
            Console.Write(list.Count - 1);
        }
        public void PrintList(List<List<int>> list)
        {
            Console.WriteLine("Порядок обхода:");
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    Console.Write(i + "->");
                }                
            }
            
        }
    }*/
}
