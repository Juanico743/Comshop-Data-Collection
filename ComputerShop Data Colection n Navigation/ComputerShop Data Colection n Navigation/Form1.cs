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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num, num1, num2;
        bool csave = false;
        bool add = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.Graph' table. You can move, or remove it, as needed.
            this.graphTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.Graph);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.Transactions);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerShopKeeper' table. You can move, or remove it, as needed.
            this.computerShopKeeperTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerShopKeeper);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerDetails' table. You can move, or remove it, as needed.
            this.computerDetailsTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerDetails);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerShop' table. You can move, or remove it, as needed.
            this.computerShopTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerShop);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.Graph' table. You can move, or remove it, as needed.
            this.graphTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.Graph);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.Transactions);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerShopKeeper' table. You can move, or remove it, as needed.
            this.computerShopKeeperTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerShopKeeper);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerDetails' table. You can move, or remove it, as needed.
            this.computerDetailsTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerDetails);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerShop' table. You can move, or remove it, as needed.
            this.computerShopTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerShop);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.Graph' table. You can move, or remove it, as needed.
            this.graphTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.Graph);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.Transactions);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerShopKeeper' table. You can move, or remove it, as needed.
            this.computerShopKeeperTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerShopKeeper);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerDetails' table. You can move, or remove it, as needed.
            this.computerDetailsTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerDetails);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerShop' table. You can move, or remove it, as needed.
            this.computerShopTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerShop);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.Graph' table. You can move, or remove it, as needed.
            this.graphTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.Graph);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.Transactions);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerShopKeeper' table. You can move, or remove it, as needed.
            this.computerShopKeeperTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerShopKeeper);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerDetails' table. You can move, or remove it, as needed.
            this.computerDetailsTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerDetails);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerShop' table. You can move, or remove it, as needed.
            this.computerShopTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerShop);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.Graph' table. You can move, or remove it, as needed.
            this.graphTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.Graph);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerDetails' table. You can move, or remove it, as needed.
            this.computerDetailsTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerDetails);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerShop' table. You can move, or remove it, as needed.
            this.computerShopTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerShop);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerShopKeeper' table. You can move, or remove it, as needed.
            this.computerShopKeeperTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerShopKeeper);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.Transactions);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.Graph' table. You can move, or remove it, as needed.
            this.graphTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.Graph);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.Transactions);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerShopKeeper' table. You can move, or remove it, as needed.
            this.computerShopKeeperTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerShopKeeper);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerDetails' table. You can move, or remove it, as needed.
            this.computerDetailsTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerDetails);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerDetails' table. You can move, or remove it, as needed.
            this.computerDetailsTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerDetails);
            // TODO: This line of code loads data into the 'antipolo_Computer_ShopsDataSet.ComputerShop' table. You can move, or remove it, as needed.
            this.computerShopTableAdapter.Fill(this.antipolo_Computer_ShopsDataSet.ComputerShop);

            //Form f3 = new Loading();
            //f3.Hide();

            this.Size = new Size(1300, 760);
            this.AutoScroll = false;

            toolTip1.SetToolTip(movefirst_btn,"Move First");
            toolTip1.SetToolTip(movelast_btn, "Move Last");
            toolTip1.SetToolTip(prev_btn, "Previous");
            toolTip1.SetToolTip(next_btn, "Next");
            toolTip1.SetToolTip(add_btn, "Add");
            toolTip1.SetToolTip(print_btn, "Print Record");
            toolTip1.SetToolTip(save_btn, "Save");
            toolTip1.SetToolTip(edit_btn, "Edit");
            toolTip1.SetToolTip(delete_btn, "Cancel");
            toolTip1.SetToolTip(printgraph_btn, "Print Graph");
            toolTip1.SetToolTip(del_btn, "Delete Record");


            data_panel.Hide();
            modification_btn.Location = new Point(8, 172);
            modification_panel.Hide();
            deletedata_btn.Location = new Point(8, 216);
            deletedata_panel.Hide();
            graph_btn.Location = new Point(8, 260);
            exit_btn.Location = new Point(8, 304);

            underline.Hide();
            underline.Location = new Point(666, 192);

            comshop_panel.Hide();
            comdetails_panel.Hide();
            shopkeeper_panel.Hide();
            transaction_panel.Hide();

            modif_panel.Hide();

            del_panel.Hide();
            delbtn_panel.Hide();

            exitmessage_panel.Hide();
            saveexitmessage_panel.Hide();
            income_panel.Hide();
            consumption_panel.Hide();
            profit_panel.Hide();
            graph_img.Hide();
            graphmove_btn.Hide();

            prevmod.Hide();
            nextmod.Hide();

            printgraph_btn.Hide();

            pictureBox2.Hide();
            print_panel.Hide();
        }

        private void data_btn_Click(object sender, EventArgs e)
        {
            TBComShop.Show();
            CBComShop.Show();
            TBComShop.Location = new Point(666, 160);
            CBComShop.Location = new Point(934, 160);
           
            TBComDet.Hide();
            CBComDet.Hide();
            CBSk.Hide();
            TBSk.Hide();
            TBTs.Hide();
            CBTs.Hide();

            TBComShop.Text = "";
            TBComDet.Text = "";
            TBSk.Text = "";
            TBComDet.Text = "";
            TBMcs.Text = "";
            TBCd.Text = "";
            TTBsk.Text = "";
            TBTs.Text = "";
                       
            TBMcs.Hide();
            TBCd.Hide();
            TTBsk.Hide();
            TBTs.Hide();
            MDCs.Hide();
            MDcd.Hide();
            MDsk.Hide();
            MDT.Hide();

            data_panel.Show();
            modification_btn.Location = new Point(8, 314);
            modification_panel.Hide();
            deletedata_btn.Location = new Point(8, 358);
            deletedata_panel.Hide();
            graph_btn.Location = new Point(8, 402);
            exit_btn.Location = new Point(8, 446);

            data_btn.ForeColor = Color.Red;
            modification_btn.ForeColor = Color.Black;
            deletedata_btn.ForeColor = Color.Black;
            graph_btn.ForeColor = Color.Black;
            exit_btn.ForeColor = Color.Black;

            comshop_panel.Location = new Point(288, 208);

            comshop_panel.Show();
            comdetails_panel.Hide();
            shopkeeper_panel.Hide();
            transaction_panel.Hide();

            modif_panel.Hide();

            del_panel.Hide();
            delbtn_panel.Hide();

            comshop_btn.ForeColor = Color.White;
            comshop_btn.FillColor = Color.Black;
            comdetails_btn.ForeColor = Color.Black;
            comdetails_btn.FillColor = Color.LightCoral;
            shopkeeper_btn.ForeColor = Color.Black;
            shopkeeper_btn.FillColor = Color.LightCoral;
            transaction_btn.ForeColor = Color.Black;
            transaction_btn.FillColor = Color.LightCoral;

            exitmessage_panel.Hide();
            saveexitmessage_panel.Hide();

            income_panel.Hide();
            consumption_panel.Hide();
            profit_panel.Hide();
            graph_img.Hide();
            graphmove_btn.Hide();

            underline.Show();

            prevmod.Hide();
            nextmod.Hide();

            printgraph_btn.Hide();

            pictureBox2.Show();
            pictureBox3.Hide();
        }

        private void modification_btn_Click(object sender, EventArgs e)
        {
            TBMcs.Show();
            MDCs.Show();
            TBMcs.Location= new Point(666,160);
            MDCs.Location= new Point(934,160);
           

            TTBsk.Hide();
            CBSk.Hide();
            TBComShop.Hide();
            CBComShop.Hide();
            TBComDet.Hide();
            CBComDet.Hide();
            TBTs.Hide();
            CBTs.Hide();

            TBComShop.Text = "";
            TBComDet.Text = "";
            TBSk.Text = "";
            TBComDet.Text = "";
            TBMcs.Text = "";
            TBCd.Text = "";
            TTBsk.Text = "";
            TBTs.Text = "";
            TBTID.Text = "";
           
            data_panel.Hide();
            modification_btn.Location = new Point(8, 172);
            modification_panel.Show();
            modification_panel.Location = new Point(15, 216);
            deletedata_btn.Location = new Point(8, 494);
            deletedata_panel.Hide();
            graph_btn.Location = new Point(8, 538);
            exit_btn.Location = new Point(8, 582);

            data_btn.ForeColor = Color.Black;
            modification_btn.ForeColor = Color.Red;
            deletedata_btn.ForeColor = Color.Black;
            graph_btn.ForeColor = Color.Black;
            exit_btn.ForeColor = Color.Black;

            comshop_panel.Hide();
            comdetails_panel.Hide();
            shopkeeper_panel.Hide();
            transaction_panel.Hide();

            modif_panel.Show();
            comshoppanel.Show();
            detailspanel.Hide();
            keeperpanel.Hide();
            transpanel.Hide();
            nextmod.Show();
            prevmod.Hide();
            modif_panel.Location = new Point(288, 208);
            comshoppanel.Location = new Point(29, 13);
            detailspanel.Location = new Point(29, 13);
            keeperpanel.Location = new Point(29, 13);
            transpanel.Location = new Point(29, 13);

            prevmod.Hide();

            del_panel.Hide();
            delbtn_panel.Hide();

            exitmessage_panel.Hide();
            saveexitmessage_panel.Hide();

            income_panel.Hide();
            consumption_panel.Hide();
            profit_panel.Hide();
            graph_img.Hide();
            graphmove_btn.Hide();

            detailspanel.Hide();
            keeperpanel.Hide();
            transpanel.Hide();

            underline.Show();

            prevmod.Show();
            nextmod.Show();
            prevmod.Location = new Point(599, 571);
            nextmod.Location = new Point(794, 571);

            printgraph_btn.Hide();
            
            pictureBox2.Show();
            pictureBox3.Hide();
        }

        private void graph_btn_Click(object sender, EventArgs e)
        {
            TBSk.Hide();
            CBSk.Hide();
            TBComShop.Hide();
            CBComShop.Hide();
            TBComDet.Hide();
            CBComDet.Hide();
            TBTs.Hide();
            CBTs.Hide();

            TBMcs.Hide();
            TBCd.Hide();
            TBSk.Hide();
            TBTID.Hide();
            MDCs.Hide();
            MDcd.Hide();
            MDsk.Hide();
            MDT.Hide();

            TBComShop.Text = "";
            TBComDet.Text = "";
            TBSk.Text = "";
            TBComDet.Text = "";
            TBMcs.Text = "";
            TBCd.Text = "";
            TTBsk.Text = "";
            TBTs.Text = "";
            TBTID.Text = "";
          

            data_panel.Hide();
            modification_btn.Location = new Point(8, 172);
            modification_panel.Hide();
            deletedata_btn.Location = new Point(8, 216);
            deletedata_panel.Hide();
            graph_btn.Location = new Point(8, 260);
            exit_btn.Location = new Point(8, 304);

            data_btn.ForeColor = Color.Black;
            modification_btn.ForeColor = Color.Black;
            deletedata_btn.ForeColor = Color.Black;
            graph_btn.ForeColor = Color.Red;
            exit_btn.ForeColor = Color.Black;

            comshop_panel.Hide();
            comdetails_panel.Hide();
            shopkeeper_panel.Hide();
            transaction_panel.Hide();

            modif_panel.Hide();

            del_panel.Hide();
            delbtn_panel.Hide();

            exitmessage_panel.Hide();
            saveexitmessage_panel.Hide();

            income_panel.Location = new Point(338, 208);
            consumption_panel.Location = new Point(338, 208);
            profit_panel.Location = new Point(338, 208);
            graph_img.Location = new Point(1014, 313);
            graphmove_btn.Location = new Point(651, 672);
            graphmove_btn.Location = new Point(651, 672);
            rpn.Location = new Point(57, 14);
            income_panel.Show();
            graph_img.Show();
            graphmove_btn.Show();

            underline.Hide();

            prevmod.Hide();
            nextmod.Hide();

            printgraph_btn.Show();
            printgraph_btn.Location = new Point(1104, 218);

            pictureBox2.Show();
            pictureBox3.Hide();

            income_chrt.Series["Monthly Income"].XValueMember = "CSName";
            income_chrt.Series["Monthly Income"].YValueMembers = "MonthlyIncome";
            income_chrt.DataSource = antipolo_Computer_ShopsDataSet.Graph;
            income_chrt.DataBind();

            consumption_chrt.Series["Monthly Consumption"].XValueMember = "CSName";
            consumption_chrt.Series["Monthly Consumption"].YValueMembers = "MonthlyConsumption";
            consumption_chrt.DataSource = antipolo_Computer_ShopsDataSet.Graph;
            consumption_chrt.DataBind();

            profit_chrt.Series["Monthly Profit"].XValueMember = "CSName";
            profit_chrt.Series["Monthly Profit"].YValueMembers = "Profit";
            profit_chrt.DataSource = antipolo_Computer_ShopsDataSet.Graph;
            profit_chrt.DataBind();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            TBSk.Hide();
            CBSk.Hide();
            TBComShop.Hide();
            CBComShop.Hide();
            TBComDet.Hide();
            CBComDet.Hide();
            TBTs.Hide();
            CBTs.Hide();

            TBMcs.Hide();
            TBCd.Hide();
            TTBsk.Hide();
            TBTID.Hide();
            MDCs.Hide();
            MDcd.Hide();
            MDsk.Hide();
            MDT.Hide();

            TBComShop.Text = "";
            TBComDet.Text = "";
            TBSk.Text = "";
            TBComDet.Text = "";
            TBMcs.Text = "";
            TBCd.Text = "";
            TTBsk.Text = "";
            TBTs.Text = "";
            TBTID.Text = "";
          

            data_panel.Hide();
            modification_btn.Location = new Point(8, 172);
            modification_panel.Hide();
            deletedata_btn.Location = new Point(8, 216);
            deletedata_panel.Hide();
            graph_btn.Location = new Point(8, 260);
            exit_btn.Location = new Point(8, 304);

            data_btn.ForeColor = Color.Black;
            modification_btn.ForeColor = Color.Black;
            deletedata_btn.ForeColor = Color.Black;
            graph_btn.ForeColor = Color.Black;
            exit_btn.ForeColor = Color.Red;

            comshop_panel.Hide();
            comdetails_panel.Hide();
            shopkeeper_panel.Hide();
            transaction_panel.Hide();

            modif_panel.Hide();

            del_panel.Hide();
            delbtn_panel.Hide();

            income_panel.Hide();
            consumption_panel.Hide();
            profit_panel.Hide();
            graph_img.Hide();
            graphmove_btn.Hide();

            underline.Hide();

            prevmod.Hide();
            nextmod.Hide();

            printgraph_btn.Hide();
                
            pictureBox2.Show();
            pictureBox3.Hide();

            if (csave == false)
            {
                exitmessage_panel.Show();
                exitmessage_panel.Location = new Point(338, 208);
            }
            else if (csave == true)
            {
                saveexitmessage_panel.Show();
                saveexitmessage_panel.Location = new Point(338, 208);
            }

        }

        private void comshop_btn_Click(object sender, EventArgs e)
        {
            comshop_panel.Location = new Point(288, 208);
            TBComShop.Show();
            CBComShop.Show();
            TBComShop.Location = new Point(666, 160);
            CBComShop.Location = new Point(934, 160);

            TBComShop.Text = "";
            TBComDet.Text = "";
            TBSk.Text = "";
            TBComDet.Text = "";
            TBMcs.Text = "";
            TBCd.Text = "";
            TTBsk.Text = "";
            TBTs.Text = "";
            

            TBComDet.Hide();
            CBComDet.Hide();
            CBSk.Hide();
            TBSk.Hide();
            TBTs.Hide();
            CBTs.Hide();


            comshop_panel.Show();
            comdetails_panel.Hide();
            shopkeeper_panel.Hide();
            transaction_panel.Hide();

            del_panel.Hide();
            delbtn_panel.Hide();

            comshop_btn.ForeColor = Color.White;
            comshop_btn.FillColor = Color.Black;
            comdetails_btn.ForeColor = Color.Black;
            comdetails_btn.FillColor = Color.LightCoral;
            shopkeeper_btn.ForeColor = Color.Black;
            shopkeeper_btn.FillColor = Color.LightCoral;
            transaction_btn.ForeColor = Color.Black;
            transaction_btn.FillColor = Color.LightCoral;
        }

        private void comdetails_btn_Click(object sender, EventArgs e)
        {
            comdetails_panel.Location = new Point(288, 208);

            TBComDet.Show();
            CBComDet.Show();
            TBComDet.Location = new Point(666, 160);
            CBComDet.Location = new Point(934, 160);

            TBComShop.Text = "";
            TBComDet.Text = "";
            TBSk.Text = "";
            TBComDet.Text = "";
            TBMcs.Text = "";
            TBCd.Text = "";
            TTBsk.Text = "";
            TBTs.Text = "";
            

            TBComShop.Hide();
            CBComShop.Hide();
            CBSk.Hide();
            TBSk.Hide();
            TBTs.Hide();
            CBTs.Hide();

            comshop_panel.Hide();
            comdetails_panel.Show();
            shopkeeper_panel.Hide();
            transaction_panel.Hide();

            del_panel.Hide();
            delbtn_panel.Hide();

            comshop_btn.ForeColor = Color.Black;
            comshop_btn.FillColor = Color.LightCoral;
            comdetails_btn.ForeColor = Color.White;
            comdetails_btn.FillColor = Color.Black;
            shopkeeper_btn.ForeColor = Color.Black;
            shopkeeper_btn.FillColor = Color.LightCoral;
            transaction_btn.ForeColor = Color.Black;
            transaction_btn.FillColor = Color.LightCoral;
        }

        private void shopkeeper_btn_Click(object sender, EventArgs e)
        {
            shopkeeper_panel.Location = new Point(288, 208);

            CBSk.Show();
            TBSk.Show();
            CBSk.Location = new Point(934,160);
            TBSk.Location = new Point(666, 160);

            TBComShop.Text = "";
            TBComDet.Text = "";
            TBSk.Text = "";
            TBComDet.Text = "";
            TBMcs.Text = "";
            TBCd.Text = "";
            TTBsk.Text = "";
            TBTs.Text = "";
           
            CBComShop.Hide();
            TBComShop.Hide();
            CBComDet.Hide();
            TBComDet.Hide();
            TBTs.Hide();
            CBTs.Hide();

            comshop_panel.Hide();
            comdetails_panel.Hide();
            shopkeeper_panel.Show();
            transaction_panel.Hide();

            del_panel.Hide();
            delbtn_panel.Hide();

            comshop_btn.ForeColor = Color.Black;
            comshop_btn.FillColor = Color.LightCoral;
            comdetails_btn.ForeColor = Color.Black;
            comdetails_btn.FillColor = Color.LightCoral;
            shopkeeper_btn.ForeColor = Color.White;
            shopkeeper_btn.FillColor = Color.Black;
            transaction_btn.ForeColor = Color.Black;
            transaction_btn.FillColor = Color.LightCoral;
        }

        private void transaction_btn_Click(object sender, EventArgs e)
        {
            transaction_panel.Location = new Point(288, 208);

            TBTs.Show();
            CBTs.Show();
            TBTs.Location = new Point(666,160);
            CBTs.Location = new Point(934,160);

            TBComShop.Text = "";
            TBComDet.Text = "";
            TBSk.Text = "";
            TBComDet.Text = "";
            TBMcs.Text = "";
            TBCd.Text = "";
            TTBsk.Text = "";
            TBTs.Text = "";
           

            TBSk.Hide();
            CBSk.Hide();
            TBComShop.Hide();
            CBComShop.Hide();
            TBComDet.Hide();
            CBComDet.Hide();
                       

            comshop_panel.Hide();
            comdetails_panel.Hide();
            shopkeeper_panel.Hide();
            transaction_panel.Show();

            del_panel.Hide();
            delbtn_panel.Hide();

            comshop_btn.ForeColor = Color.Black;
            comshop_btn.FillColor = Color.LightCoral;
            comdetails_btn.ForeColor = Color.Black;
            comdetails_btn.FillColor = Color.LightCoral;
            shopkeeper_btn.ForeColor = Color.Black;
            shopkeeper_btn.FillColor = Color.LightCoral;
            transaction_btn.ForeColor = Color.White;
            transaction_btn.FillColor = Color.Black;
        }

        private void movefirst_btn_Click(object sender, EventArgs e)
        {
            computerShopBindingSource.MoveFirst();
            computerDetailsBindingSource.MoveFirst();
            computerShopKeeperBindingSource.MoveFirst();
            transactionsBindingSource.MoveFirst();
            graphBindingSource.MoveFirst();
        }

        private void movelast_btn_Click(object sender, EventArgs e)
        {
            computerShopBindingSource.MoveLast();
            computerDetailsBindingSource.MoveLast();
            computerShopKeeperBindingSource.MoveLast();
            transactionsBindingSource.MoveLast();
            graphBindingSource.MoveLast();
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            computerShopBindingSource.MovePrevious();
            computerDetailsBindingSource.MovePrevious();
            computerShopKeeperBindingSource.MovePrevious();
            transactionsBindingSource.MovePrevious();
            graphBindingSource.MovePrevious();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            computerShopBindingSource.MoveNext();
            computerDetailsBindingSource.MoveNext();
            computerShopKeeperBindingSource.MoveNext();
            transactionsBindingSource.MoveNext();
            graphBindingSource.MoveNext();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            TBMcs.Hide();
            TBCd.Hide();
            TTBsk.Hide();
            TBTs.Hide();
            MDCs.Hide();
            MDcd.Hide();
            MDsk.Hide();
            MDT.Hide();

            computerShopBindingSource.AddNew();
            computerDetailsBindingSource.AddNew();
            computerShopKeeperBindingSource.AddNew();
            transactionsBindingSource.AddNew();
            graphBindingSource.AddNew();

            cSIDTextBox.ReadOnly = false;
            cSNameTextBox.ReadOnly = false;
            cSLocationTextBox.ReadOnly = false;
            ownerFirstNameTextBox.ReadOnly = false;
            ownerLastNameTextBox.ReadOnly = false;
            ownerContactNumTextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;

            cIDTextBox.ReadOnly = false;
            internetProviderTextBox.ReadOnly = false;
            processorTextBox.ReadOnly = false;
            rAM_SizeTextBox.ReadOnly = false;
            storage_SizeTextBox.ReadOnly = false;
            motherboard_BrandTextBox.ReadOnly = false;

            sKIDTextBox.ReadOnly = false;
            firstNameTextBox.ReadOnly = false;
            lastNameTextBox.ReadOnly = false;
            ageTextBox.ReadOnly = false;
            contactNumTextBox.ReadOnly = false;
            emailTextBox1.ReadOnly = false;

            tIDTextBox.ReadOnly = false;
            monthlyIncomeTextBox.ReadOnly = false;
            monthlyConsumptionTextBox.ReadOnly = false;

            underline.Hide();

            add = true;

            csave = true;
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
            printDocument1.Print();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(monthlyIncomeTextBox1.Text);
            num1 = Convert.ToDouble(monthlyConsumptionTextBox1.Text);
            num2 = num - num1;
            profitTextBox.Text = (num2).ToString();

            computerShopBindingSource.EndEdit();
            computerDetailsBindingSource.EndEdit();
            computerShopKeeperBindingSource.EndEdit();
            transactionsBindingSource.EndEdit();
            graphBindingSource.EndEdit();
            
            computerShopTableAdapter.Update(antipolo_Computer_ShopsDataSet.ComputerShop);
            computerDetailsTableAdapter.Update(antipolo_Computer_ShopsDataSet.ComputerDetails);
            computerShopKeeperTableAdapter.Update(antipolo_Computer_ShopsDataSet.ComputerShopKeeper);
            transactionsTableAdapter.Update(antipolo_Computer_ShopsDataSet.Transactions);
            //graphTableAdapter.Update(antipolo_Computer_ShopsDataSet.Graph);

            cSIDTextBox.ReadOnly = true;
            cSNameTextBox.ReadOnly = true;
            cSLocationTextBox.ReadOnly = true;
            ownerFirstNameTextBox.ReadOnly = true;
            ownerLastNameTextBox.ReadOnly = true;
            ownerContactNumTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;

            cIDTextBox.ReadOnly = true;
            internetProviderTextBox.ReadOnly = true;
            processorTextBox.ReadOnly = true;
            rAM_SizeTextBox.ReadOnly = true;
            storage_SizeTextBox.ReadOnly = true;
            motherboard_BrandTextBox.ReadOnly = true;

            sKIDTextBox.ReadOnly = true;
            lastNameTextBox.ReadOnly = true;
            firstNameTextBox.ReadOnly = true;
            ageTextBox.ReadOnly = true;
            contactNumTextBox.ReadOnly = true;
            emailTextBox1.ReadOnly = true;

            tIDTextBox.ReadOnly = true;
            monthlyIncomeTextBox.ReadOnly = true;
            monthlyConsumptionTextBox.ReadOnly = true;

            underline.Show();

            add = false;

            csave = false;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {

            cSIDTextBox.ReadOnly = false;
            cSNameTextBox.ReadOnly = false;
            cSLocationTextBox.ReadOnly = false;
            ownerFirstNameTextBox.ReadOnly = false;
            ownerLastNameTextBox.ReadOnly = false;
            ownerContactNumTextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;

            cIDTextBox.ReadOnly = false;
            internetProviderTextBox.ReadOnly = false;
            processorTextBox.ReadOnly = false;
            rAM_SizeTextBox.ReadOnly = false;
            storage_SizeTextBox.ReadOnly = false;
            motherboard_BrandTextBox.ReadOnly = false;

            sKIDTextBox.ReadOnly = false;
            lastNameTextBox.ReadOnly = false;
            firstNameTextBox.ReadOnly = false;
            ageTextBox.ReadOnly = false;
            contactNumTextBox.ReadOnly = false;
            emailTextBox1.ReadOnly = false;

            tIDTextBox.ReadOnly = false;
            monthlyIncomeTextBox.ReadOnly = false;
            monthlyConsumptionTextBox.ReadOnly = false;

            csave = true;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

            if (add == true)
            {
                computerShopBindingSource.RemoveCurrent();
                computerDetailsBindingSource.RemoveCurrent();
                computerShopKeeperBindingSource.RemoveCurrent();
                transactionsBindingSource.RemoveCurrent();
                graphBindingSource.RemoveCurrent();
            }
            csave = true;
        }

        private void normaldel_rbtn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void lifo_rbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fifo_rbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void prevgraph_btn_Click(object sender, EventArgs e)
        {
            if (profit_panel.Visible)
            {
                income_panel.Hide();
                consumption_panel.Show();
                profit_panel.Hide();
                rpn.Location = new Point(92, 14);
            }
            else if (consumption_panel.Visible)
            {
                income_panel.Show();
                consumption_panel.Hide();
                profit_panel.Hide();
                rpn.Location = new Point(57, 14);
            }
        }

        private void nextgraph_btn_Click(object sender, EventArgs e)
        {
            if (income_panel.Visible)
            {
                income_panel.Hide();
                consumption_panel.Show();
                profit_panel.Hide();
                rpn.Location = new Point(92, 14);
            }
            else if (consumption_panel.Visible)
            {
                income_panel.Hide();
                consumption_panel.Hide();
                profit_panel.Show();
                rpn.Location = new Point(127, 14);
            }
        }

        private void sidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deletedata_btn_Click(object sender, EventArgs e)
        {
            TBMcs.Show();
            MDCs.Show();
            TBMcs.Location = new Point(666, 160);
            MDCs.Location = new Point(934, 160);

            TBSk.Hide();
            CBSk.Hide();
            TBComShop.Hide();
            CBComShop.Hide();
            TBComDet.Hide();
            CBComDet.Hide();
            TBTs.Hide();
            CBTs.Hide();

            
            TBCd.Hide();
            TBSk.Hide();
            TBTs.Hide();
            MDsk.Hide();
            MDT.Hide();
            TBTID.Hide();

            TBComShop.Text = "";
            TBComDet.Text = "";
            TBSk.Text = "";
            TBComDet.Text = "";
            TBMcs.Text = "";
            TBCd.Text = "";
            TTBsk.Text = "";
            TBTs.Text = "";
            TBTID.Text = "";
          

            data_panel.Hide();
            modification_btn.Location = new Point(8, 172);
            modification_panel.Hide();
            deletedata_btn.Location = new Point(8, 216);
            deletedata_panel.Show();
            deletedata_panel.Location = new Point(15, 260);
            graph_btn.Location = new Point(8, 345);
            exit_btn.Location = new Point(8, 389);

            data_btn.ForeColor = Color.Black;
            modification_btn.ForeColor = Color.Black;
            deletedata_btn.ForeColor = Color.Red;
            graph_btn.ForeColor = Color.Black;
            exit_btn.ForeColor = Color.Black;

            comshop_panel.Hide();
            comdetails_panel.Hide();
            shopkeeper_panel.Hide();
            transaction_panel.Hide();

            modif_panel.Hide();

            del_panel.Show();
            del_panel.Location = new Point(288, 208);
            delbtn_panel.Show();
            delbtn_panel.Location = new Point(284, 659);

            comshop_pic.Show();
            nextname_btn.Show();
            nextname_btn.Text = "Computer Details";
            prevname_btn.Hide();
            computerdetails_pic.Hide();
            shopkeeper_pic.Hide();
            transaction_pic.Hide();

            prevname_btn.Hide();

            exitmessage_panel.Hide();
            saveexitmessage_panel.Hide();

            income_panel.Hide();
            consumption_panel.Hide();
            profit_panel.Hide();
            graph_img.Hide();
            graphmove_btn.Hide();

            CSdel.Show();
            cddel.Hide();
            skdel.Hide();
            tdel.Hide();

            underline.Show();
            prevmod.Hide();
            nextmod.Hide();

            printgraph_btn.Hide();

            pictureBox2.Show();
            pictureBox3.Hide();
        }

        private void profit_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void delbtn_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nextmod_Click_1(object sender, EventArgs e)
        {
            if (comshoppanel.Visible)
            {
                comshoppanel.Hide();
                detailspanel.Show();
                prevmod.Show();
                TBMcs.Hide();
                MDCs.Hide();
                TBCd.Show();
                MDcd.Show();
                TBCd.Location = new Point(666, 160);
                MDcd.Location = new Point(934, 160);

            }
            else if (detailspanel.Visible)
            {
                detailspanel.Hide();
                keeperpanel.Show();
                TTBsk.Show();
                MDsk.Show();
                TTBsk.Location = new Point(666, 160);
                MDsk.Location= new Point(934, 160);
                TBCd.Hide();
                MDcd.Hide();
            }
            else if (keeperpanel.Visible)
            {
                keeperpanel.Hide();
                transpanel.Show();
                nextmod.Hide();
                TTBsk.Hide();
                MDsk.Hide();
                TBTID.Show();
                MDT.Show();
                TBTID.Location = new Point(666,160);
                MDT.Location = new Point(934, 160);

            }
            cSNameTextBox1.Text = cSNameTextBox.Text;
            cSIDTextBox1.Text = cSIDTextBox.Text;
            cSIDTextBox2.Text = cSIDTextBox.Text;
            cSIDTextBox3.Text = cSIDTextBox.Text;
            cSIDTextBox4.Text = cSIDTextBox.Text;

            if (add == true)
            {
                TBMcs.Hide();
                TBCd.Hide();
                TTBsk.Hide();
                TBTID.Hide();
                MDCs.Hide();
                MDcd.Hide();
                MDsk.Hide();
                MDT.Hide();
            }
        }

        private void prevmod_Click(object sender, EventArgs e)
        {
            if (transpanel.Visible)
            {
                keeperpanel.Show();
                transpanel.Hide();
                nextmod.Show();
                TBTID.Hide();
                MDT.Hide();
                TTBsk.Show();
                MDsk.Show();


            }
            else if (keeperpanel.Visible)
            {
                detailspanel.Show();
                keeperpanel.Hide();
                TTBsk.Hide();
                MDsk.Hide();
                TBCd.Show();
                MDcd.Show();

            }
            else if (detailspanel.Visible)
            {
                comshoppanel.Show();
                detailspanel.Hide();
                prevmod.Hide();
                TBCd.Hide();
                MDcd.Hide();
                TBMcs.Show();
                MDCs.Show();
                

            }
            if (add == true)
            {
                TBMcs.Hide();
                TBCd.Hide();
                TTBsk.Hide();
                TBTID.Hide();
                MDCs.Hide();
                MDcd.Hide();
                MDsk.Hide();
                MDT.Hide();
            }
        }

        private void nextname_btn_Click(object sender, EventArgs e)
        {

            TBComShop.Text = "";
            TBComDet.Text = "";
            TBSk.Text = "";
            TBComDet.Text = "";
            TBMcs.Text = "";
            TBCd.Text = "";
            TTBsk.Text = "";
            TBTs.Text = "";
            TBTID.Text = "";

            if (comshop_pic.Visible)
            {
                comshop_pic.Hide();
                CSdel.Hide();
                computerdetails_pic.Show();
                cddel.Show();
                prevname_btn.Show();
                nextname_btn.Text = "Shop Keeper";
                prevname_btn.Text = "Computer Shop";
                TBMcs.Hide();
                MDCs.Hide();
                TBCd.Show();
                MDcd.Show();
                TBCd.Location = new Point(666, 160);
                MDcd.Location = new Point(934, 160);

                TBComShop.Text = "";
                TBComDet.Text = "";
                TBSk.Text = "";
                TBComDet.Text = "";
                TBMcs.Text = "";
                TBCd.Text = "";
                TTBsk.Text = "";
                TBTs.Text = "";
                TBTID.Text = "";
            }
            else if (computerdetails_pic.Visible)
            {
                computerdetails_pic.Hide();
                cddel.Hide();
                shopkeeper_pic.Show();
                skdel.Show();
                nextname_btn.Text = "Transaction";
                prevname_btn.Text = "Computer Details";
                TBCd.Hide();
                MDcd.Hide();
                TTBsk.Show();
                MDsk.Show();
                TTBsk.Location = new Point(666, 160);
                MDsk.Location = new Point(934, 160);

                TBComShop.Text = "";
                TBComDet.Text = "";
                TBSk.Text = "";
                TBComDet.Text = "";
                TBMcs.Text = "";
                TBCd.Text = "";
                TTBsk.Text = "";
                TBTs.Text = "";
                TBTID.Text = "";
            }
            else if (shopkeeper_pic.Visible)
            {
                shopkeeper_pic.Hide();
                skdel.Hide();
                transaction_pic.Show();
                tdel.Show();
                nextname_btn.Hide();
                prevname_btn.Text = "Shop Keeper";
                TTBsk.Hide();
                MDsk.Hide();
                TBTID.Show();
                MDT.Show();
                TBTID.Location = new Point(666, 160);
                MDT.Location = new Point(934, 160);

                TBComShop.Text = "";
                TBComDet.Text = "";
                TBSk.Text = "";
                TBComDet.Text = "";
                TBMcs.Text = "";
                TBCd.Text = "";
                TTBsk.Text = "";
                TBTs.Text = "";
                TBTID.Text = "";
            }
        }

        private void prevname_btn_Click(object sender, EventArgs e)
        {

            TBComShop.Text = "";
            TBComDet.Text = "";
            TBSk.Text = "";
            TBComDet.Text = "";
            TBMcs.Text = "";
            TBCd.Text = "";
            TTBsk.Text = "";
            TBTs.Text = "";
            TBTID.Text = "";

            if (transaction_pic.Visible)
            {
                shopkeeper_pic.Show();
                skdel.Show();
                transaction_pic.Hide();
                tdel.Hide();
                nextname_btn.Show();
                nextname_btn.Text = "Transaction";
                prevname_btn.Text = "Computer Details";
                TTBsk.Show();
                MDsk.Show();
                TBTID.Hide();
                MDT.Hide();

                TBComShop.Text = "";
                TBComDet.Text = "";
                TBSk.Text = "";
                TBComDet.Text = "";
                TBMcs.Text = "";
                TBCd.Text = "";
                TTBsk.Text = "";
                TBTs.Text = "";
                TBTID.Text = "";

            }
            else if (shopkeeper_pic.Visible)
            {

                computerdetails_pic.Show();
                cddel.Show();
                shopkeeper_pic.Hide();
                skdel.Hide();
                nextname_btn.Text = "Shop Keeper";
                prevname_btn.Text = "Computer Shop";
                TBCd.Show();
                MDcd.Show();
                TTBsk.Hide();
                MDsk.Hide();

                TBComShop.Text = "";
                TBComDet.Text = "";
                TBSk.Text = "";
                TBComDet.Text = "";
                TBMcs.Text = "";
                TBCd.Text = "";
                TTBsk.Text = "";
                TBTs.Text = "";
                TBTID.Text = "";
            }
            else if (computerdetails_pic.Visible)
            {

                comshop_pic.Show();
                CSdel.Show();
                computerdetails_pic.Hide();
                cddel.Hide();
                prevname_btn.Hide();
                nextname_btn.Text = "Computer Details";
                TBMcs.Show();
                MDCs.Show();
                TBCd.Hide();
                MDcd.Hide();

                TBComShop.Text = "";
                TBComDet.Text = "";
                TBSk.Text = "";
                TBComDet.Text = "";
                TBMcs.Text = "";
                TBCd.Text = "";
                TTBsk.Text = "";
                TBTs.Text = "";
                TBTID.Text = "";
            }
        }

        private void comshop_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap prt = new Bitmap(this.print_panel.Width, this.print_panel.Height);
            print_panel.DrawToBitmap(prt, new Rectangle(7, 7, this.print_panel.Width, this.print_panel.Height));
            e.Graphics.DrawImage(prt, 0, 0);
        }

        private void cSIDTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void monthlyIncomeTextBox_TextChanged(object sender, EventArgs e)
        {
            monthlyIncomeTextBox1.Text = monthlyIncomeTextBox.Text;
        }

        private void monthlyConsumptionTextBox_TextChanged(object sender, EventArgs e)
        {
            monthlyConsumptionTextBox1.Text = monthlyConsumptionTextBox.Text;

            
        }

        private void cSNameTextBox_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (normaldel_rbtn.Checked)
            {
            
                computerShopBindingSource.RemoveCurrent();
                computerDetailsBindingSource.RemoveCurrent();
                computerShopKeeperBindingSource.RemoveCurrent();
                transactionsBindingSource.RemoveCurrent();
                graphBindingSource.RemoveCurrent();
            }
            else if (lifo_rbtn.Checked)
            {
                computerShopBindingSource.MoveLast();
                computerDetailsBindingSource.MoveLast();
                computerShopKeeperBindingSource.MoveLast();
                transactionsBindingSource.MoveLast();
                graphBindingSource.MoveLast();

                computerShopBindingSource.RemoveCurrent();
                computerDetailsBindingSource.RemoveCurrent();
                computerShopKeeperBindingSource.RemoveCurrent();
                transactionsBindingSource.RemoveCurrent();
                graphBindingSource.RemoveCurrent();
            }
            else if (fifo_rbtn.Checked)
            {
                computerShopBindingSource.MoveFirst();
                computerDetailsBindingSource.MoveFirst();
                computerShopKeeperBindingSource.MoveFirst();
                transactionsBindingSource.MoveFirst();
                graphBindingSource.MoveFirst();

                computerShopBindingSource.RemoveCurrent();
                computerDetailsBindingSource.RemoveCurrent();
                computerShopKeeperBindingSource.RemoveCurrent();
                transactionsBindingSource.RemoveCurrent();
                graphBindingSource.RemoveCurrent();
            }
            csave = true;
        }

        private void modif_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (CBComShop.Text == "Computer Shop ID") {
                this.computerShopBindingSource.Filter = "CSID like '%" + TBComShop.Text + "%'";
            }
            else if (CBComShop.Text == "Computer Shop Name")
            {
                this.computerShopBindingSource.Filter = "CSName like '%" + TBComShop.Text + "%'";
            }
            else if (CBComShop.Text == "Computer Shop Location")
            {
                this.computerShopBindingSource.Filter = "CSLocation like '%" + TBComShop.Text + "%'";
            }
            else if (CBComShop.Text == "Owner First Name")
            {
                this.computerShopBindingSource.Filter = "OwnerFirstName like '%" + TBComShop.Text + "%'";
            }
            else if (CBComShop.Text == "Owner Last Name")
            {
                this.computerShopBindingSource.Filter = "OwnerLastName like '%" + TBComShop.Text + "%'";
            }
            else if (CBComShop.Text == "Owner Contact No.")
            {
                this.computerShopBindingSource.Filter = "OwnerContactNum like '%" + TBComShop.Text + "%'";
            }
            else if (CBComShop.Text == "Owner Email")
            {
                this.computerShopBindingSource.Filter = "Email like '%" + TBComShop.Text + "%'";
            }
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (CBComDet.Text == "Computer Shop ID")
            {
                this.computerDetailsBindingSource.Filter = "CSID like '%" + TBComDet.Text + "%'";
            }
            else if (CBComDet.Text == "Computer ID")
            {
                this.computerDetailsBindingSource.Filter = "CID like '%" + TBComDet.Text + "%'";
            }
            else if (CBComDet.Text == "Internet Provider")
            {
                this.computerDetailsBindingSource.Filter = "InternetProvider like '%" + TBComDet.Text + "%'";
            }
            else if (CBComDet.Text == "Processor")
            {
                this.computerDetailsBindingSource.Filter = "Processor like '%" + TBComDet.Text + "%'";
            }
            else if (CBComDet.Text == "RAM Size")
            {
                this.computerDetailsBindingSource.Filter = "RAM_Size like '%" + TBComDet.Text + "%'";
            }
            else if (CBComDet.Text == "Storage Size")
            {
                this.computerDetailsBindingSource.Filter = "Storage_Size like '%" + TBComDet.Text + "%'";
            }
            else if (CBComDet.Text == "Motherboard Brand")
            {
                this.computerDetailsBindingSource.Filter = "Motherboard_Brand like '%" + TBComDet.Text + "%'";
            }
      
        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_2(object sender, EventArgs e)
        {

            if (CBSk.Text == "Computer Shop ID")
            {
                this.computerShopKeeperBindingSource.Filter = "CSID like '%" + TBSk.Text + "%'";
            }
            else if (CBSk.Text == "Shop Keeper ID")
            {
                this.computerShopKeeperBindingSource.Filter = "SKID like '%" + TBSk.Text + "%'";
            }
            else if (CBSk.Text == "Last Name")
            {
                this.computerShopKeeperBindingSource.Filter = "LastName like '%" + TBSk.Text + "%'";
            }
            else if (CBSk.Text == "First Name")
            {
                this.computerShopKeeperBindingSource.Filter = "FirstName like '%" + TBSk.Text + "%'";
            }
            else if (CBSk.Text == "Age")
            {
                this.computerShopKeeperBindingSource.Filter = "Age like '%" + TBSk.Text + "%'";
            }
            else if (CBSk.Text == "Contact No.")
            {
                this.computerShopKeeperBindingSource.Filter = "ContactNum like '%" + TBSk.Text + "%'";
            }
            else if (CBSk.Text == "Email")
            {
                this.computerShopKeeperBindingSource.Filter = "Email like '%" + TBSk.Text + "%'";
            }
        }

        private void TBTs_TextChanged(object sender, EventArgs e)
        {
            if (CBTs.Text == "Monthly Consumption")
            {
                int mc;
                if (int.TryParse(TBTs.Text, out mc))
                {
                    this.transactionsBindingSource.Filter = "Convert(MonthlyConsumption, 'System.String') like '%" + mc.ToString() + "%'";
                }
                else
                {
                    this.transactionsBindingSource.Filter = "";
                }
            }
            else if (CBTs.Text == "Monthly Income")
            {
                int mi;
                if (int.TryParse(TBTs.Text, out mi))
                {
                    this.transactionsBindingSource.Filter = "Convert(MonthlyIncome, 'System.String') like '%" + mi.ToString() + "%'";
                }
                else
                {
                    this.transactionsBindingSource.Filter = "";
                }

            }
            if (CBTs.Text == "Transaction ID") {
                this.transactionsBindingSource.Filter = "TID like '%"+ TBTs.Text +"%'";
            }
            else if (CBTs.Text == "Computer Shop ID")
            {
                this.transactionsBindingSource.Filter = "CID like '%" + TBTs.Text + "%'";
            }


        }

        private void MDCs_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBMcs_TextChanged(object sender, EventArgs e)
        {
            if (MDCs.Text == "            Computer Shop ID") {
                this.computerShopBindingSource.Filter = "CSID like '%" + TBMcs.Text + "%'";
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (MDcd.Text == "                   Computer ID")
            {
                this.computerDetailsBindingSource.Filter = "CID like '%" + TBCd.Text + "%'";
            }
        }

        private void TTBsk_TextChanged(object sender, EventArgs e)
        {
            if (MDsk.Text == "                Shop Keeper ID")
            {
                this.computerShopKeeperBindingSource.Filter = "SKID like '%" + TTBsk.Text + "%'";
            }
        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (MDT.Text == "                 Transaction ID")
            {
                this.transactionsBindingSource.Filter = "TID like '%" + TBTID.Text + "%'";
            }
        }
        private void profitTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void saveexitmessage_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void underline_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (income_panel.Visible)
            {
                Bitmap prt = new Bitmap(this.income_panel.Width, this.income_panel.Height);
                income_panel.DrawToBitmap(prt, new Rectangle(7, 7, this.income_panel.Width, this.income_panel.Height));
                e.Graphics.DrawImage(prt, 0, 0);
            }
            else if (consumption_panel.Visible)
            {
                Bitmap prt = new Bitmap(this.consumption_panel.Width, this.consumption_panel.Height);
                consumption_panel.DrawToBitmap(prt, new Rectangle(7, 7, this.consumption_panel.Width, this.consumption_panel.Height));
                e.Graphics.DrawImage(prt, 0, 0);
            }
            else if (profit_panel.Visible)
            {
                Bitmap prt = new Bitmap(this.profit_panel.Width, this.profit_panel.Height);
                profit_panel.DrawToBitmap(prt, new Rectangle(7, 7, this.profit_panel.Width, this.profit_panel.Height));
                e.Graphics.DrawImage(prt, 0, 0);
            }
        }

        private void printgraph_btn_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.ShowDialog();
            printDocument2.Print();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {

            pictureBox2.Hide();
            pictureBox3.Show();
            exitmessage_panel.Hide();
            exit_btn.ForeColor = Color.Black;
        }

        private void exitmessage_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            //computerShopBindingSource.EndEdit();
            //computerDetailsBindingSource.EndEdit();
            //computerShopKeeperBindingSource.EndEdit();
            //transactionsBindingSource.EndEdit();
            //graphBindingSource.EndEdit();

            //computerShopTableAdapter.Update(antipolo_Computer_ShopsDataSet.ComputerShop);
            //computerDetailsTableAdapter.Update(antipolo_Computer_ShopsDataSet.ComputerDetails);
            //computerShopKeeperTableAdapter.Update(antipolo_Computer_ShopsDataSet.ComputerShopKeeper);
            //transactionsTableAdapter.Update(antipolo_Computer_ShopsDataSet.Transactions);
            //graphTableAdapter.Update(antipolo_Computer_ShopsDataSet.Graph);

            //this.Close();
            Application.Exit(); pictureBox2.Hide();
            exitmessage_panel.Hide();
            exit_btn.ForeColor = Color.Black;
            pictureBox3.Show();
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {

            pictureBox2.Hide();
            pictureBox3.Show();
            saveexitmessage_panel.Hide();
            exit_btn.ForeColor = Color.Black;
        }

        private void print_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prevdel_btn_Click(object sender, EventArgs e)
        {
            computerShopBindingSource.MovePrevious();
            computerDetailsBindingSource.MovePrevious();
            computerShopKeeperBindingSource.MovePrevious();
            transactionsBindingSource.MovePrevious();
            graphBindingSource.MovePrevious();
        }

        private void nextdel_btn_Click(object sender, EventArgs e)
        {
            computerShopBindingSource.MoveNext();
            computerDetailsBindingSource.MoveNext();
            computerShopKeeperBindingSource.MoveNext();
            transactionsBindingSource.MoveNext();
            graphBindingSource.MoveNext();
        }
    }
}
