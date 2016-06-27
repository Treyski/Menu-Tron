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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DQMenu dqMenu = new DQMenu();
            dqMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btn54th_Click(object sender, EventArgs e)
        {
            FiftyFourthMainMenu menu = new FiftyFourthMainMenu();
            menu.Show();
        }

        private void btnRedRobins_Click(object sender, EventArgs e)
        {
            RedRobinsMain menu = new RedRobinsMain();
            menu.Show();
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            StarbucksMain menu = new StarbucksMain();
            menu.Show();
        }
    }
}
