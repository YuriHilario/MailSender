
namespace MailSender
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panelControllers = new System.Windows.Forms.Panel();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Config = new System.Windows.Forms.Button();
            this.btn_Remittants = new System.Windows.Forms.Button();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_Background = new System.Windows.Forms.PictureBox();
            this.panel_BackgoundImg = new System.Windows.Forms.Panel();
            this.panel_Main.SuspendLayout();
            this.panelControllers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Background)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.Transparent;
            this.panel_Main.Controls.Add(this.panelControllers);
            this.panel_Main.Controls.Add(this.pictureBox_Background);
            this.panel_Main.Controls.Add(this.panel_BackgoundImg);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(850, 450);
            this.panel_Main.TabIndex = 0;
            // 
            // panelControllers
            // 
            this.panelControllers.BackColor = System.Drawing.Color.DimGray;
            this.panelControllers.Controls.Add(this.btn_Start);
            this.panelControllers.Controls.Add(this.btn_Config);
            this.panelControllers.Controls.Add(this.btn_Remittants);
            this.panelControllers.Controls.Add(this.pictureBox_Logo);
            this.panelControllers.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControllers.Location = new System.Drawing.Point(0, 0);
            this.panelControllers.Name = "panelControllers";
            this.panelControllers.Size = new System.Drawing.Size(81, 450);
            this.panelControllers.TabIndex = 3;
            // 
            // btn_Start
            // 
            this.btn_Start.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Start.Location = new System.Drawing.Point(0, 56);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(81, 28);
            this.btn_Start.TabIndex = 8;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Config.FlatAppearance.BorderSize = 0;
            this.btn_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Config.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Config.Location = new System.Drawing.Point(0, 28);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(81, 28);
            this.btn_Config.TabIndex = 7;
            this.btn_Config.Text = "Config";
            this.btn_Config.UseVisualStyleBackColor = true;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // btn_Remittants
            // 
            this.btn_Remittants.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Remittants.FlatAppearance.BorderSize = 0;
            this.btn_Remittants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remittants.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Remittants.Location = new System.Drawing.Point(0, 0);
            this.btn_Remittants.Name = "btn_Remittants";
            this.btn_Remittants.Size = new System.Drawing.Size(81, 28);
            this.btn_Remittants.TabIndex = 5;
            this.btn_Remittants.Text = "Remittants";
            this.btn_Remittants.UseVisualStyleBackColor = true;
            this.btn_Remittants.Click += new System.EventHandler(this.btn_Remittants_Click);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Logo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.Location = new System.Drawing.Point(0, 400);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(81, 50);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 2;
            this.pictureBox_Logo.TabStop = false;
            // 
            // pictureBox_Background
            // 
            this.pictureBox_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Background.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Background.Image")));
            this.pictureBox_Background.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Background.Name = "pictureBox_Background";
            this.pictureBox_Background.Size = new System.Drawing.Size(850, 450);
            this.pictureBox_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Background.TabIndex = 0;
            this.pictureBox_Background.TabStop = false;
            // 
            // panel_BackgoundImg
            // 
            this.panel_BackgoundImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_BackgoundImg.Location = new System.Drawing.Point(0, 0);
            this.panel_BackgoundImg.Name = "panel_BackgoundImg";
            this.panel_BackgoundImg.Size = new System.Drawing.Size(850, 450);
            this.panel_BackgoundImg.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.panel_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Mail Sender";
            this.panel_Main.ResumeLayout(false);
            this.panelControllers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.PictureBox pictureBox_Background;
        private System.Windows.Forms.Panel panelControllers;
        private System.Windows.Forms.Panel panel_BackgoundImg;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Config;
        private System.Windows.Forms.Button btn_Remittants;
    }
}

