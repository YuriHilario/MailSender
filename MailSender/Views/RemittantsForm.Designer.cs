
namespace MailSender.Views
{
    partial class RemittantsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemittantsForm));
            this.dataGridView_Remittants = new System.Windows.Forms.DataGridView();
            this.panel_DataGridView = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_CNPJ = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressIII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressIV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Remittants)).BeginInit();
            this.panel_DataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Remittants
            // 
            this.dataGridView_Remittants.AllowUserToAddRows = false;
            this.dataGridView_Remittants.AllowUserToDeleteRows = false;
            this.dataGridView_Remittants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Remittants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.uf,
            this.cnpj,
            this.address,
            this.AddressII,
            this.addressIII,
            this.addressIV,
            this.addressV});
            this.dataGridView_Remittants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Remittants.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Remittants.Name = "dataGridView_Remittants";
            this.dataGridView_Remittants.ReadOnly = true;
            this.dataGridView_Remittants.RowTemplate.Height = 25;
            this.dataGridView_Remittants.Size = new System.Drawing.Size(945, 379);
            this.dataGridView_Remittants.TabIndex = 0;
            // 
            // panel_DataGridView
            // 
            this.panel_DataGridView.Controls.Add(this.dataGridView_Remittants);
            this.panel_DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.panel_DataGridView.Name = "panel_DataGridView";
            this.panel_DataGridView.Size = new System.Drawing.Size(945, 379);
            this.panel_DataGridView.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(13, 386);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(39, 15);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address II";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address III";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address IV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address V";
            // 
            // lbl_CNPJ
            // 
            this.lbl_CNPJ.AutoSize = true;
            this.lbl_CNPJ.Location = new System.Drawing.Point(12, 423);
            this.lbl_CNPJ.Name = "lbl_CNPJ";
            this.lbl_CNPJ.Size = new System.Drawing.Size(34, 15);
            this.lbl_CNPJ.TabIndex = 8;
            this.lbl_CNPJ.Text = "CNPJ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 23);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(365, 383);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 23);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(365, 420);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 23);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(67, 420);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 23);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(666, 383);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(225, 23);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(666, 420);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(225, 23);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(666, 455);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(225, 23);
            this.textBox7.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 235;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 235;
            // 
            // uf
            // 
            this.uf.HeaderText = "UF";
            this.uf.MinimumWidth = 50;
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            this.uf.Width = 50;
            // 
            // cnpj
            // 
            this.cnpj.HeaderText = "CNPJ";
            this.cnpj.MinimumWidth = 117;
            this.cnpj.Name = "cnpj";
            this.cnpj.ReadOnly = true;
            this.cnpj.Width = 117;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // AddressII
            // 
            this.AddressII.HeaderText = "Address II";
            this.AddressII.Name = "AddressII";
            this.AddressII.ReadOnly = true;
            // 
            // addressIII
            // 
            this.addressIII.HeaderText = "Address III";
            this.addressIII.Name = "addressIII";
            this.addressIII.ReadOnly = true;
            // 
            // addressIV
            // 
            this.addressIV.HeaderText = "Address IV";
            this.addressIV.Name = "addressIV";
            this.addressIV.ReadOnly = true;
            // 
            // addressV
            // 
            this.addressV.HeaderText = "Address V";
            this.addressV.Name = "addressV";
            this.addressV.ReadOnly = true;
            // 
            // RemittantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(945, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_CNPJ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.panel_DataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemittantsForm";
            this.Text = "Remittants";
            this.Load += new System.EventHandler(this.Remittants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Remittants)).EndInit();
            this.panel_DataGridView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Remittants;
        private System.Windows.Forms.Panel panel_DataGridView;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_CNPJ;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressII;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIII;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressV;
    }
}