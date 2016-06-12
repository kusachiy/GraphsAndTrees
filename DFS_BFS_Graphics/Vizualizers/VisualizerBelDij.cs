using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFS_BFS_Graphics
{
    public partial class VisualizerBelDij : Form
    {
        public delegate int[] Algo(int[,] matrix, int startVertex);
        Algo algo;
        public VisualizerBelDij()
        {
            InitializeComponent();
        }
        int[,] matrix;      
        
        Point[] vertices;
        int countOfVertex;
        int pointRadius = 23;
        int figureRadius = 200;

        Graphics g;

        public VisualizerBelDij(int[,] mainMatrix, Algo algo)
        {
            InitializeComponent();
            matrix = mainMatrix;            
            this.algo = algo;
            countOfVertex = matrix.GetLength(0);
            vertices = new Point[countOfVertex];            
            Point center = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            g = pictureBox1.CreateGraphics();

            for (int i = 0; i < countOfVertex; i++)
            {
                vertices[i] = new Point((int)(center.X + figureRadius * Math.Sin(Math.PI * 2 * i / countOfVertex)), (int)(center.Y + figureRadius * Math.Cos(Math.PI * 2 * i / countOfVertex)));
            }
            //g = pictureBox1.CreateGraphics();
        }

        private void Drawing_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        void DrawLines()
        {
            for (int i = 0; i < countOfVertex; i++)
            {
                for (int j = i + 1; j < countOfVertex; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        DrawLine(Pens.Black, i, j);
                    }
                }
            }
        }
        void DrawLine(Pen pen, int p1, int p2)
        {
            g.DrawLine(pen, vertices[p1], vertices[p2]);
            Point center = new Point((vertices[p2].X + vertices[p1].X) / 2, (vertices[p2].Y + vertices[p1].Y) / 2);
            g.DrawString(matrix[p1, p2].ToString(), SystemFonts.CaptionFont, Brushes.Brown, center);
        }


        private void button1_Click(object sender, EventArgs e)
        {            
            Drawing();
            listBox1.Items.Clear();
            int[] result = algo(matrix, int.Parse(textBox1.Text));
            for (int i = 0; i < countOfVertex; i++)
            {
                listBox1.Items.Add(string.Format("Vertex{0} -> {1}", i,result[i]));
            }

        }       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void Drawing()
        {
            g.Clear(Color.White);
            for (int i = 0; i < countOfVertex; i++)
            {
                g.FillEllipse(Brushes.Black, vertices[i].X - pointRadius, vertices[i].Y - pointRadius, 2 * pointRadius, 2 * pointRadius);
            }
            DrawLines();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

