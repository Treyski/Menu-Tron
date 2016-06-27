using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treys_Menu_Troon_5000
{
    public partial class StarbucksMain : Form
    {
        public StarbucksMain()
        {
            InitializeComponent();
        }

        private void StarbucksMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StarbucksCoffee menu = new StarbucksCoffee();
            menu.Show();
        }

        private void btnESp_Click(object sender, EventArgs e)
        {
            StarbucksEspr menu = new StarbucksEspr();
            menu.Show();
        }

        private void btnFrap_Click(object sender, EventArgs e)
        {
            StarbucksFrap menu = new StarbucksFrap();
            menu.Show();
        }

        private void btnTe_Click(object sender, EventArgs e)
        {
            StarbucksTea menu = new StarbucksTea();
            menu.Show();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            StarbucksRef menu = new StarbucksRef();
            menu.Show();
        }

        private void btnSm_Click(object sender, EventArgs e)
        {
            StarbucksSmoo menu = new StarbucksSmoo();
            menu.Show();
        }
    }
}
