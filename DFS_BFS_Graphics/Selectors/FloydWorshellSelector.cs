using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFS_BFS_Graphics
{
    public partial class FloydWorshellSelector : Form
    {
        int[,] original;
        int[,] matrix;

        public FloydWorshellSelector()
        {
            InitializeComponent();            
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            new VisualizerFloyd(original,Bellman_Dijkstra_Worshell.FloydWorschell(matrix)).Show();
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
                original =(int[,])matrix.Clone();
                selectFileButton.Text = "graph loaded";
                sReader.Close();
            }
        }
    }
}
