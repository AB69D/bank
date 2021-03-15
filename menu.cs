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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update obb = new update();
            //MdiParent =  this;
            obb.Show();
        }

        private void creatnewaccountstrip_Click(object sender, EventArgs e)
        {
            creataccount obb = new creataccount();
            //MdiParent = this;
            obb.Show();
        }

        private void allCoustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allcoustomer obb = new allcoustomer();
            //MdiParent = this;
            obb.Show();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changepassword obb = new changepassword();
            //MdiParent = this ;
            obb.Show();
        }

        private void currentBlanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentbalance obb = new currentbalance();
            // MdiParent = this ;
            obb.Show();
        }

        private void depositToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fdeposit obb = new fdeposit();
            //MdiParent = this ;
            obb.Show();
        }

        private void tresferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftransfer obb = new ftransfer();
            //MdiParent = this;
            obb.Show();
        }

        private void withdrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fwithdraw obb = new fwithdraw();
            // MdiParent = this; 
            obb.Show();
        }
    }
}
