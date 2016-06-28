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
    public partial class StarbucksRef : Form
    {
        public StarbucksRef()
        {
            InitializeComponent();
        }

        private void StarbucksRef_Load(object sender, EventArgs e)
        {
            
        }

        private void StarbucksRef_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<MenuObject> objects = new List<MenuObject>
            {
                new MenuObject{ ItemName = txtCoolLimeRef.Text, Rating = ratingCoolLimeRef.Value}
            };
            //string jsonString = 
        }
    }
}
