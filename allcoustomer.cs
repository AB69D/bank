using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lollipop_Bank
{
    public partial class allcoustomer : Form
    {
        SqlConnection cnnt;
        public allcoustomer()
        {
            InitializeComponent();
            cnnt = new SqlConnection(@"Data Source =DESKTOP-JQOPVV4; Initial Catalog = AB9D; Integrated security = True;");
            cnnt.Open();
            Display();
            cnnt.Close();
        }

        public void Display()

        {
            
            SqlDataAdapter sqladapter = new SqlDataAdapter("select * from useraccounts", cnnt);
            DataTable dt = new DataTable();
            sqladapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void allcoustomer_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
