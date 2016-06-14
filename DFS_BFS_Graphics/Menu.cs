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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void searchesButton_Click(object sender, EventArgs e)
        {
            new SelectSearchAlgorithmForm().Show();
        }

        private void skeletonButton_Click(object sender, EventArgs e)
        {
            new SelectFindingOstovAlgoForm().Show();
        }

        private void minamalPathButton_Click(object sender, EventArgs e)
        {
            new BellmanAndDijkstraSelector().Show();
        }

        private void minamalPathButton2_Click(object sender, EventArgs e)
        {
            new FloydWorshellSelector().Show();
        }
    }
}
