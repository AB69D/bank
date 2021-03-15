using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lollipop_Bank
{
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
        }

        private void textuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            AB9DEntities1 dbe = new AB9DEntities1();
            if (textuser.Text != string.Empty || textpassword.Text != string.Empty)
            {
                var user1 = dbe.admin_tb.FirstOrDefault(a => a.username.Equals(textuser.Text));
                if(user1 != null)
                {
                    if(user1.password.Equals(textpassword.Text))
                    {
                        menu m1 = new menu();
                        m1.ShowDialog();
                        textuser.Clear();
                        textpassword.Clear();
                    }
                   else
                    {
                        MessageBox.Show("Invalied Username or Password");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Insert Value");
            }
            
        }

        private void Log_In_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminsignup obb = new adminsignup();
            obb.Show();
        }
    }
}
