
namespace MailSender.Views
{
    partial class SenderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenderForm));
            this.lbl_To = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Body = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_Answer = new System.Windows.Forms.DataGridView();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remittee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_To = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Answer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.ForeColor = System.Drawing.Color.White;
            this.lbl_To.Location = new System.Drawing.Point(30, 9);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(19, 15);
            this.lbl_To.TabIndex = 1;
            this.lbl_To.Text = "To";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(60, 35);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(365, 23);
            this.txt_Subject.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subject";
            // 
            // txt_Body
            // 
            this.txt_Body.Location = new System.Drawing.Point(12, 76);
            this.txt_Body.Multiline = true;
            this.txt_Body.Name = "txt_Body";
            this.txt_Body.Size = new System.Drawing.Size(590, 311);
            this.txt_Body.TabIndex = 6;
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.LightGray;
            this.btn_Send.FlatAppearance.BorderSize = 0;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send.ForeColor = System.Drawing.Color.Black;
            this.btn_Send.Location = new System.Drawing.Point(12, 405);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 7;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_Answer);
            this.panel1.Location = new System.Drawing.Point(620, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 311);
            this.panel1.TabIndex = 8;
            // 
            // dataGridView_Answer
            // 
            this.dataGridView_Answer.AllowUserToAddRows = false;
            this.dataGridView_Answer.AllowUserToDeleteRows = false;
            this.dataGridView_Answer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Answer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.answer,
            this.remittee});
            this.dataGridView_Answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Answer.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Answer.Name = "dataGridView_Answer";
            this.dataGridView_Answer.ReadOnly = true;
            this.dataGridView_Answer.RowTemplate.Height = 25;
            this.dataGridView_Answer.Size = new System.Drawing.Size(296, 311);
            this.dataGridView_Answer.TabIndex = 1;
            // 
            // answer
            // 
            this.answer.HeaderText = "Answer";
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            // 
            // remittee
            // 
            this.remittee.HeaderText = "Remittee";
            this.remittee.MinimumWidth = 152;
            this.remittee.Name = "remittee";
            this.remittee.ReadOnly = true;
            this.remittee.Width = 152;
            // 
            // txt_To
            // 
            this.txt_To.FormattingEnabled = true;
            this.txt_To.Location = new System.Drawing.Point(60, 6);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(365, 23);
            this.txt_To.TabIndex = 9;
            // 
            // SenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(928, 440);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Body);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.lbl_To);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SenderForm";
            this.Text = "Sender";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Answer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Body;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn remittee;
        private System.Windows.Forms.ComboBox txt_To;
    }
}