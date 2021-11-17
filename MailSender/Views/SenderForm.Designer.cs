
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
            this.txt_To = new System.Windows.Forms.ComboBox();
            this.lbl_From = new System.Windows.Forms.Label();
            this.txt_From = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.ForeColor = System.Drawing.Color.White;
            this.lbl_To.Location = new System.Drawing.Point(26, 44);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(19, 15);
            this.lbl_To.TabIndex = 1;
            this.lbl_To.Text = "To";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(62, 70);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(365, 23);
            this.txt_Subject.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subject";
            // 
            // txt_Body
            // 
            this.txt_Body.Location = new System.Drawing.Point(12, 108);
            this.txt_Body.Multiline = true;
            this.txt_Body.Name = "txt_Body";
            this.txt_Body.Size = new System.Drawing.Size(483, 311);
            this.txt_Body.TabIndex = 6;
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.LightGray;
            this.btn_Send.FlatAppearance.BorderSize = 0;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send.ForeColor = System.Drawing.Color.Black;
            this.btn_Send.Location = new System.Drawing.Point(12, 435);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 7;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_To
            // 
            this.txt_To.FormattingEnabled = true;
            this.txt_To.Location = new System.Drawing.Point(62, 41);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(67, 23);
            this.txt_To.TabIndex = 9;
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.ForeColor = System.Drawing.Color.White;
            this.lbl_From.Location = new System.Drawing.Point(10, 15);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(35, 15);
            this.lbl_From.TabIndex = 11;
            this.lbl_From.Text = "From";
            // 
            // txt_From
            // 
            this.txt_From.FormattingEnabled = true;
            this.txt_From.Location = new System.Drawing.Point(62, 12);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(365, 23);
            this.txt_From.TabIndex = 12;
            // 
            // SenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(774, 464);
            this.Controls.Add(this.txt_From);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Body);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.lbl_To);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SenderForm";
            this.Text = "Mail Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Body;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.ComboBox txt_To;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.ComboBox txt_From;
    }
}