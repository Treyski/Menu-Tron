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
    }
}
