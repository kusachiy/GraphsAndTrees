using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DFS_BFS_Graphics
{
    public partial class Drawing : Form
    {
        public delegate List<int> SearchAlgo(int[,] matrix, int start, int search);
        SearchAlgo sa;
        int[,] matrix;
        bool[] visited;
        Point[] vertices;
        int countOfVertex;
        int pointRadius = 25;
        int figureRadius = 200;

        Graphics g;

        public Drawing(int[,] inp,SearchAlgo sa)
        {
            InitializeComponent();
            matrix = inp;
            this.sa = sa;
            countOfVertex = matrix.GetLength(0);
            vertices = new Point[countOfVertex];
            visited = new bool[countOfVertex];
            Point center = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            for (int i = 0; i < countOfVertex; i++)
            {
                vertices[i] = new Point((int)(center.X + figureRadius * Math.Sin(Math.PI * 2 * i / countOfVertex)), (int)(center.Y + figureRadius * Math.Cos(Math.PI * 2 * i / countOfVertex)));
            }
            //g = pictureBox1.CreateGraphics();
        }

        void DrawLines()
        {
            for (int i = 0; i < countOfVertex; i++)
                for (int j = i+1; j < countOfVertex; j++)
                    if (matrix[i, j] > 0)
                        DrawLine(Pens.Black,i, j);
        }
        void DrawLine(Pen pen,int p1,int p2)
        {
            g.DrawLine(pen, vertices[p1],vertices[p2]);
            Point center = new Point((vertices[p2].X + vertices[p1].X) / 2, (vertices[p2].Y + vertices[p1].Y) / 2);
            g.DrawString(matrix[p1, p2].ToString(),SystemFonts.CaptionFont,Brushes.Brown,center);
        }
        void DrawNumbers()
        {
            for (int i = 0; i < countOfVertex; i++)
                g.DrawString(i.ToString(), SystemFonts.IconTitleFont, Brushes.White, vertices[i]);
        }
        

        private void vizualizeButton_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            for (int i = 0; i < countOfVertex; i++)
            {
                g.FillEllipse(Brushes.Black, vertices[i].X-pointRadius, vertices[i].Y-pointRadius, 2*pointRadius, 2*pointRadius);
            }
            DrawLines();
            DrawNumbers();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            int start=int.Parse(textBox1.Text), search=int.Parse(textBox2.Text);
            var list = sa(matrix, start, search);
            int prev = -1;
            foreach (var item in list)
            {
                if (item == search)
                {
                    DrawLine(new Pen(Color.Red, 2f), item, prev);
                    g.FillEllipse(Brushes.Green, vertices[item].X - pointRadius, vertices[item].Y - pointRadius, 2 * pointRadius, 2 * pointRadius);
                    MessageBox.Show("Конец пути");
                    break;
                }
                if (!visited[item])
                {
                    if (prev >= 0)
                        DrawLine(new Pen(Color.Red,2f), item, prev);
                    g.FillEllipse(Brushes.Red, vertices[item].X - pointRadius, vertices[item].Y - pointRadius, 2 * pointRadius, 2 * pointRadius);
                    visited[item] = true;
                    Thread.Sleep(1000);
                    prev = item;
                }
                else
                {
                    g.FillEllipse(Brushes.Yellow, vertices[item].X - pointRadius, vertices[item].Y - pointRadius, 2 * pointRadius, 2 * pointRadius);
                    Thread.Sleep(1000);

                }
            }
        }
    }
}
