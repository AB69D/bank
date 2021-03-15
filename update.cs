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
    public partial class update : Form
    {
        SqlConnection cnnt;
        public update()
        {
            InitializeComponent();
            cnnt = new SqlConnection(@"Data Source =DESKTOP-JQOPVV4; Initial Catalog = AB9D; Integrated security = True;");
            cnnt.Open();
            //Display();
            cnnt.Close();
        }

        public void Display()

        {

            SqlDataAdapter sqladapter = new SqlDataAdapter("select * from useraccounts", cnnt);
            DataTable dt = new DataTable();
            sqladapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are You Sure want to delete this data ? ", "message",  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    useraccountsBindingSource.RemoveCurrent();
            }
        }

        private void update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aB9DDataSet.useraccounts' table. You can move, or remove it, as needed.
            this.useraccountsTableAdapter.Fill(this.aB9DDataSet.useraccounts);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                useraccountsBindingSource.EndEdit();
                useraccountsTableAdapter.Update(this.aB9DDataSet.useraccounts);
                MessageBox.Show("Data Update Successfully");
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Cursor.Current = Cursors.Default;

        }
    }
}
