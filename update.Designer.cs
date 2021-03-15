
namespace Lollipop_Bank
{
    partial class update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.aB9DDataSet = new Lollipop_Bank.AB9DDataSet();
            this.useraccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.useraccountsTableAdapter = new Lollipop_Bank.AB9DDataSetTableAdapters.useraccountsTableAdapter();
            this.Caccountid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritialstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aB9DDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(777, 381);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(93, 33);
            this.btnupdate.TabIndex = 53;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caccountid,
            this.cname,
            this.cnumber,
            this.caddress,
            this.cemail,
            this.cgender,
            this.cdateofbirth,
            this.cbalance,
            this.stateDataGridViewTextBoxColumn,
            this.maritialstatusDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.useraccountsBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(2, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1244, 305);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(1010, 381);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(87, 33);
            this.btndelete.TabIndex = 65;
            this.btndelete.Text = "Exit";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // aB9DDataSet
            // 
            this.aB9DDataSet.DataSetName = "AB9DDataSet";
            this.aB9DDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // useraccountsBindingSource
            // 
            this.useraccountsBindingSource.DataMember = "useraccounts";
            this.useraccountsBindingSource.DataSource = this.aB9DDataSet;
            // 
            // useraccountsTableAdapter
            // 
            this.useraccountsTableAdapter.ClearBeforeFill = true;
            // 
            // Caccountid
            // 
            this.Caccountid.DataPropertyName = "account_id";
            this.Caccountid.HeaderText = "Account Id";
            this.Caccountid.Name = "Caccountid";
            this.Caccountid.ReadOnly = true;
            // 
            // cname
            // 
            this.cname.DataPropertyName = "name";
            this.cname.HeaderText = "Name";
            this.cname.Name = "cname";
            // 
            // cnumber
            // 
            this.cnumber.DataPropertyName = "phonenumber";
            this.cnumber.HeaderText = "Number";
            this.cnumber.Name = "cnumber";
            // 
            // caddress
            // 
            this.caddress.DataPropertyName = "address";
            this.caddress.HeaderText = "Address";
            this.caddress.Name = "caddress";
            // 
            // cemail
            // 
            this.cemail.DataPropertyName = "email";
            this.cemail.HeaderText = "Email";
            this.cemail.Name = "cemail";
            // 
            // cgender
            // 
            this.cgender.DataPropertyName = "gender";
            this.cgender.HeaderText = "Gender";
            this.cgender.Name = "cgender";
            // 
            // cdateofbirth
            // 
            this.cdateofbirth.DataPropertyName = "DOB";
            this.cdateofbirth.HeaderText = "Date of Birth";
            this.cdateofbirth.Name = "cdateofbirth";
            // 
            // cbalance
            // 
            this.cbalance.DataPropertyName = "balance";
            this.cbalance.HeaderText = "Balance";
            this.cbalance.Name = "cbalance";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // maritialstatusDataGridViewTextBoxColumn
            // 
            this.maritialstatusDataGridViewTextBoxColumn.DataPropertyName = "maritial_status";
            this.maritialstatusDataGridViewTextBoxColumn.HeaderText = "maritial_status";
            this.maritialstatusDataGridViewTextBoxColumn.Name = "maritialstatusDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1258, 452);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnupdate);
            this.Name = "update";
            this.Text = "update";
            this.Load += new System.EventHandler(this.update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aB9DDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccountsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndelete;
        private AB9DDataSet aB9DDataSet;
        private System.Windows.Forms.BindingSource useraccountsBindingSource;
        private AB9DDataSetTableAdapters.useraccountsTableAdapter useraccountsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caccountid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn caddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgender;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritialstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}