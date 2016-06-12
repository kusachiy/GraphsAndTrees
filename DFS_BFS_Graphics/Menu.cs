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

        private void button1_Click(object sender, EventArgs e)
        {
            new SelectSearchAlgorithmForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SelectFindingOstovAlgoForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new BellmanAndDijkstraSelector().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FloydWorshellSelector().Show();
        }
    }
}
