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
    public partial class FiftyFourthMainMenu : Form
    {
        public FiftyFourthMainMenu()
        {
            InitializeComponent();
        }

        private void FiftyFourthMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMunch_Click(object sender, EventArgs e)
        {
            FiftyFourthMunchies menu = new FiftyFourthMunchies();
            menu.Show();
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            FiftyFourthSalads menu = new FiftyFourthSalads();
            menu.Show();
        }

        private void btnSoup_Click(object sender, EventArgs e)
        {
            FiftyFourthSoup menu = new FiftyFourthSoup();
            menu.Show();
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            FiftyFourthPasta menu = new FiftyFourthPasta();
            menu.Show();
        }

        private void btnCfood_Click(object sender, EventArgs e)
        {
            FiftyFourthSeafood menu = new FiftyFourthSeafood();
            menu.Show();
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            FiftyFourthCombos menu = new FiftyFourthCombos();
            menu.Show();
        }

        private void btn54Fav_Click(object sender, EventArgs e)
        {
            FiftyFourthFiveFour menu = new FiftyFourthFiveFour();
            menu.Show();
        }

        private void btnMileBurg_Click(object sender, EventArgs e)
        {
            FiftyFourthBurgers menu = new FiftyFourthBurgers();
            menu.Show();
        }

        private void btnDeepSfav_Click(object sender, EventArgs e)
        {
            FiftyFourthSouth menu = new FiftyFourthSouth();
            menu.Show();
        }

        private void btnGringoMEX_Click(object sender, EventArgs e)
        {
            FiftyFourthMexican menu = new FiftyFourthMexican();
            menu.Show();
        }

        private void btnSuperS_Click(object sender, EventArgs e)
        {
            FiftyFourthSuperS menu = new FiftyFourthSuperS();
            menu.Show();
        }

        private void btnStea_Click(object sender, EventArgs e)
        {
            FiftyFourthSteak menu = new FiftyFourthSteak();
            menu.Show();
        }
    }
}
