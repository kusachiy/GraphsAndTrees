using System;
using System.IO;
using System.Windows.Forms;

namespace DFS_BFS_Graphics
{
    public partial class BellmanAndDijkstraSelector : Form
    {
        int[,] matrix;
        public BellmanAndDijkstraSelector()
        {
            InitializeComponent();
        }

        private void Bellman_Button_Click(object sender, EventArgs e)
        {
            new VisualizerBelDij(matrix,Bellman_Dijkstra_Worshell.FordBellman).Show();
        }

        private void Dijkstra_Button_Click(object sender, EventArgs e)
        {
            new VisualizerBelDij(matrix, Bellman_Dijkstra_Worshell.Deikstra).Show();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sReader = new StreamReader(openFileDialog1.OpenFile());

                int size = int.Parse(sReader.ReadLine());
                matrix = new int[size, size];
                for (int i = 0; i < size; i++)
                {
                    string[] temp = sReader.ReadLine().Split();
                    for (int j = 0; j < size; j++)
                        matrix[i, j] = int.Parse(temp[j]);
                }
                selectFileButton.Text = "graph loaded";
                sReader.Close();
            }
        }
    }
}
