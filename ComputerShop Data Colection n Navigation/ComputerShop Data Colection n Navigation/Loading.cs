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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Loading_Load(object sender, EventArgs e)
        {
            //Form f1 = new StartUp();
            //f1.Hide();

            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToDouble(label1.Text) + 1).ToString();
            if (label1.Text == "100")
            {
                timer1.Stop();
                Form f2 = new Form1();
                f2.Show();
                this.Hide();
            }
        }
    }
}
