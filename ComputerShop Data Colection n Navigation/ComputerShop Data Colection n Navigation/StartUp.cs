using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop_Data_Colection_n_Navigation
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void Start_Label_Click(object sender, EventArgs e)
        {
            Form f3 = new Loading();
            f3.Show();
            this.Hide();
        }

        private void StartUp_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Start_Label, "Click To Start");

            this.Size = new Size(612, 489);
            about_panel.Hide();
            members_panel.Hide();
        }
        private void About_Label_MouseHover(object sender, EventArgs e)
        {
            members_panel.Hide();
            about_panel.Show();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void StartUp_MouseHover(object sender, EventArgs e)
        {
            about_panel.Hide();
            members_panel.Hide();
        }

        private void Info_Label_Click(object sender, EventArgs e)
        {

        }

        private void Info_Label_MouseHover(object sender, EventArgs e)
        {
            about_panel.Hide();
            members_panel.Show();
        }
    }
}
