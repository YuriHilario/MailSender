
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
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressIII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressIV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_DataGridView = new System.Windows.Forms.Panel();
            this.panel_Control = new System.Windows.Forms.Panel();
            this.btn_LoadData = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_FilterCNPJ = new System.Windows.Forms.TextBox();
            this.lbl_FilterCNPJ = new System.Windows.Forms.Label();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_CNPJ = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_AddressIII = new System.Windows.Forms.TextBox();
            this.txt_CNPJ = new System.Windows.Forms.TextBox();
            this.txt_AddressII = new System.Windows.Forms.TextBox();
            this.txt_AddressIV = new System.Windows.Forms.TextBox();
            this.txt_AddressV = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_UF = new System.Windows.Forms.TextBox();
            this.lbl_UF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Remittants)).BeginInit();
            this.panel_DataGridView.SuspendLayout();
            this.panel_Control.SuspendLayout();
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
            this.dataGridView_Remittants.Location = new System.Drawing.Point(-1, 34);
            this.dataGridView_Remittants.Name = "dataGridView_Remittants";
            this.dataGridView_Remittants.ReadOnly = true;
            this.dataGridView_Remittants.RowTemplate.Height = 25;
            this.dataGridView_Remittants.Size = new System.Drawing.Size(1208, 344);
            this.dataGridView_Remittants.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 248;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 248;
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
            this.address.MinimumWidth = 150;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 150;
            // 
            // AddressII
            // 
            this.AddressII.HeaderText = "Address II";
            this.AddressII.MinimumWidth = 150;
            this.AddressII.Name = "AddressII";
            this.AddressII.ReadOnly = true;
            this.AddressII.Width = 150;
            // 
            // addressIII
            // 
            this.addressIII.HeaderText = "Address III";
            this.addressIII.MinimumWidth = 150;
            this.addressIII.Name = "addressIII";
            this.addressIII.ReadOnly = true;
            this.addressIII.Width = 150;
            // 
            // addressIV
            // 
            this.addressIV.HeaderText = "Address IV";
            this.addressIV.MinimumWidth = 150;
            this.addressIV.Name = "addressIV";
            this.addressIV.ReadOnly = true;
            this.addressIV.Width = 150;
            // 
            // addressV
            // 
            this.addressV.HeaderText = "Address V";
            this.addressV.MinimumWidth = 150;
            this.addressV.Name = "addressV";
            this.addressV.ReadOnly = true;
            this.addressV.Width = 150;
            // 
            // panel_DataGridView
            // 
            this.panel_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_DataGridView.Controls.Add(this.panel_Control);
            this.panel_DataGridView.Controls.Add(this.dataGridView_Remittants);
            this.panel_DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.panel_DataGridView.Name = "panel_DataGridView";
            this.panel_DataGridView.Size = new System.Drawing.Size(1209, 379);
            this.panel_DataGridView.TabIndex = 1;
            // 
            // panel_Control
            // 
            this.panel_Control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Control.Controls.Add(this.btn_LoadData);
            this.panel_Control.Controls.Add(this.btn_Search);
            this.panel_Control.Controls.Add(this.txt_FilterCNPJ);
            this.panel_Control.Controls.Add(this.lbl_FilterCNPJ);
            this.panel_Control.Controls.Add(this.btn_Select);
            this.panel_Control.Controls.Add(this.btn_Add);
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Control.Location = new System.Drawing.Point(0, 0);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(1207, 35);
            this.panel_Control.TabIndex = 1;
            // 
            // btn_LoadData
            // 
            this.btn_LoadData.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_LoadData.FlatAppearance.BorderSize = 0;
            this.btn_LoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadData.ForeColor = System.Drawing.Color.White;
            this.btn_LoadData.Location = new System.Drawing.Point(150, 0);
            this.btn_LoadData.Name = "btn_LoadData";
            this.btn_LoadData.Size = new System.Drawing.Size(75, 33);
            this.btn_LoadData.TabIndex = 5;
            this.btn_LoadData.Text = "Load Data";
            this.btn_LoadData.UseVisualStyleBackColor = true;
            this.btn_LoadData.Click += new System.EventHandler(this.btn_LoadData_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1130, 0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 33);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_FilterCNPJ
            // 
            this.txt_FilterCNPJ.Location = new System.Drawing.Point(853, 6);
            this.txt_FilterCNPJ.Name = "txt_FilterCNPJ";
            this.txt_FilterCNPJ.Size = new System.Drawing.Size(261, 23);
            this.txt_FilterCNPJ.TabIndex = 3;
            // 
            // lbl_FilterCNPJ
            // 
            this.lbl_FilterCNPJ.AutoSize = true;
            this.lbl_FilterCNPJ.ForeColor = System.Drawing.Color.White;
            this.lbl_FilterCNPJ.Location = new System.Drawing.Point(813, 11);
            this.lbl_FilterCNPJ.Name = "lbl_FilterCNPJ";
            this.lbl_FilterCNPJ.Size = new System.Drawing.Size(34, 15);
            this.lbl_FilterCNPJ.TabIndex = 2;
            this.lbl_FilterCNPJ.Text = "CNPJ";
            // 
            // btn_Select
            // 
            this.btn_Select.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Select.FlatAppearance.BorderSize = 0;
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Select.ForeColor = System.Drawing.Color.White;
            this.btn_Select.Location = new System.Drawing.Point(75, 0);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 33);
            this.btn_Select.TabIndex = 1;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(0, 0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 33);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_name.Location = new System.Drawing.Point(13, 386);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(39, 15);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(298, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(602, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address II";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(298, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address III";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(602, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address IV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(898, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address V";
            // 
            // lbl_CNPJ
            // 
            this.lbl_CNPJ.AutoSize = true;
            this.lbl_CNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_CNPJ.Location = new System.Drawing.Point(12, 423);
            this.lbl_CNPJ.Name = "lbl_CNPJ";
            this.lbl_CNPJ.Size = new System.Drawing.Size(34, 15);
            this.lbl_CNPJ.TabIndex = 8;
            this.lbl_CNPJ.Text = "CNPJ";
            // 
            // txt_Name
            // 
            this.txt_Name.ForeColor = System.Drawing.Color.Black;
            this.txt_Name.Location = new System.Drawing.Point(67, 383);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(225, 23);
            this.txt_Name.TabIndex = 9;
            // 
            // txt_Address
            // 
            this.txt_Address.ForeColor = System.Drawing.Color.Black;
            this.txt_Address.Location = new System.Drawing.Point(365, 383);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(225, 23);
            this.txt_Address.TabIndex = 10;
            // 
            // txt_AddressIII
            // 
            this.txt_AddressIII.ForeColor = System.Drawing.Color.Black;
            this.txt_AddressIII.Location = new System.Drawing.Point(365, 420);
            this.txt_AddressIII.Name = "txt_AddressIII";
            this.txt_AddressIII.Size = new System.Drawing.Size(225, 23);
            this.txt_AddressIII.TabIndex = 11;
            // 
            // txt_CNPJ
            // 
            this.txt_CNPJ.ForeColor = System.Drawing.Color.Black;
            this.txt_CNPJ.Location = new System.Drawing.Point(67, 420);
            this.txt_CNPJ.Name = "txt_CNPJ";
            this.txt_CNPJ.Size = new System.Drawing.Size(225, 23);
            this.txt_CNPJ.TabIndex = 12;
            // 
            // txt_AddressII
            // 
            this.txt_AddressII.ForeColor = System.Drawing.Color.Black;
            this.txt_AddressII.Location = new System.Drawing.Point(666, 383);
            this.txt_AddressII.Name = "txt_AddressII";
            this.txt_AddressII.Size = new System.Drawing.Size(225, 23);
            this.txt_AddressII.TabIndex = 13;
            // 
            // txt_AddressIV
            // 
            this.txt_AddressIV.ForeColor = System.Drawing.Color.Black;
            this.txt_AddressIV.Location = new System.Drawing.Point(666, 420);
            this.txt_AddressIV.Name = "txt_AddressIV";
            this.txt_AddressIV.Size = new System.Drawing.Size(225, 23);
            this.txt_AddressIV.TabIndex = 14;
            // 
            // txt_AddressV
            // 
            this.txt_AddressV.ForeColor = System.Drawing.Color.Black;
            this.txt_AddressV.Location = new System.Drawing.Point(962, 383);
            this.txt_AddressV.Name = "txt_AddressV";
            this.txt_AddressV.Size = new System.Drawing.Size(225, 23);
            this.txt_AddressV.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Save.Location = new System.Drawing.Point(1128, 420);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(69, 23);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_UF
            // 
            this.txt_UF.ForeColor = System.Drawing.Color.Black;
            this.txt_UF.Location = new System.Drawing.Point(962, 420);
            this.txt_UF.Name = "txt_UF";
            this.txt_UF.Size = new System.Drawing.Size(33, 23);
            this.txt_UF.TabIndex = 18;
            // 
            // lbl_UF
            // 
            this.lbl_UF.AutoSize = true;
            this.lbl_UF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_UF.Location = new System.Drawing.Point(935, 423);
            this.lbl_UF.Name = "lbl_UF";
            this.lbl_UF.Size = new System.Drawing.Size(21, 15);
            this.lbl_UF.TabIndex = 17;
            this.lbl_UF.Text = "UF";
            // 
            // RemittantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1209, 451);
            this.Controls.Add(this.txt_UF);
            this.Controls.Add(this.lbl_UF);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_AddressV);
            this.Controls.Add(this.txt_AddressIV);
            this.Controls.Add(this.txt_AddressII);
            this.Controls.Add(this.txt_CNPJ);
            this.Controls.Add(this.txt_AddressIII);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_Name);
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
            this.Text = "Mail Sender - Remittants";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Remittants)).EndInit();
            this.panel_DataGridView.ResumeLayout(false);
            this.panel_Control.ResumeLayout(false);
            this.panel_Control.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_AddressIII;
        private System.Windows.Forms.TextBox txt_CNPJ;
        private System.Windows.Forms.TextBox txt_AddressII;
        private System.Windows.Forms.TextBox txt_AddressIV;
        private System.Windows.Forms.TextBox txt_AddressV;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressII;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIII;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressV;
        private System.Windows.Forms.TextBox txt_FilterCNPJ;
        private System.Windows.Forms.Label lbl_FilterCNPJ;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_LoadData;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_UF;
        private System.Windows.Forms.Label lbl_UF;
    }
}