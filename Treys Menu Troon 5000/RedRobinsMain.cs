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
    public partial class RedRobinsMain : Form
    {
        public RedRobinsMain()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RedRobinsWrap menu = new RedRobinsWrap();
            menu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RedRobinsAppetizers menu = new RedRobinsAppetizers();
            menu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RedRobinsEntrees menu = new RedRobinsEntrees();
            menu.Show();
        }

        private void btnMunch_Click(object sender, EventArgs e)
        {
            RedRobinsFine menu = new RedRobinsFine();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RedRobinsTavern menu = new RedRobinsTavern();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RedRobinsGourment menu = new RedRobinsGourment();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RedRobinsOther menu = new RedRobinsOther();
            menu.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RedRobinsSoup menu = new RedRobinsSoup();
            menu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RedRobinsSalad menu = new RedRobinsSalad();
            menu.Show();
        }
    }
}
