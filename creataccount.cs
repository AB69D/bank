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
    public partial class creataccount : Form
    {
        SqlConnection cnnt;
        public creataccount()
        {
            InitializeComponent();
            cnnt = new SqlConnection(@"Data Source =DESKTOP-JQOPVV4; Initial Catalog = AB9D; Integrated security = True;");
        }

        private void creataccount_Load(object sender, EventArgs e)
        {

        }
        private void Dataclear()
        {
            textusername.Clear();
            textname.Clear();
            textemail.Clear();
            textaddress.Clear();
            textpassword.Clear();
            textconfirmpassword.Clear();
            textnumber.Clear();
            combostate.Items.Clear();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            cnnt.Open();
            string sqlQuery = " INSERT INTO useraccounts (name, phonenumber, email, address, DOB, gender, maritial_status ,balance, state,username,password) VALUES (@P1,@P2,@P3,@p4,@P5,@P6,@P7,@P8,@p9,@p10,@p11)";
            cmd = new SqlCommand(sqlQuery, cnnt);
            cmd.Parameters.AddWithValue("@P1", textname.Text);
            cmd.Parameters.AddWithValue("@P2", int.Parse(textnumber.Text));
            cmd.Parameters.AddWithValue("@P3", textemail.Text);
            cmd.Parameters.AddWithValue("@P4", textaddress.Text);
            cmd.Parameters.AddWithValue("@P8", int.Parse(textbalace.Text));
            cmd.Parameters.AddWithValue("@P6", groupBoxgender.Text);
            cmd.Parameters.AddWithValue("@P7", groupBoxmerit.Text);
            cmd.Parameters.AddWithValue("@P5", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@P9", combostate.Text);
            cmd.Parameters.AddWithValue("@P10", textusername.Text);
            cmd.Parameters.AddWithValue("@P11", textpassword.Text);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Save Successfully");
            //Display();
            Dataclear();
            cnnt.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textbalace_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
