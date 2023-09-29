namespace Ont2030_Project
{
    partial class frmLecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLecturer));
            this.grbLecturer = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblLecturerLogin = new System.Windows.Forms.Label();
            this.lblLecturerPassword = new System.Windows.Forms.Label();
            this.txtLecturerLogin = new System.Windows.Forms.TextBox();
            this.txtLecturerPassword = new System.Windows.Forms.TextBox();
            this.btnLecturerLogin = new System.Windows.Forms.Button();
            this.grbLecturer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbLecturer
            // 
            this.grbLecturer.Controls.Add(this.panel1);
            this.grbLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLecturer.Location = new System.Drawing.Point(12, 12);
            this.grbLecturer.Name = "grbLecturer";
            this.grbLecturer.Size = new System.Drawing.Size(776, 462);
            this.grbLecturer.TabIndex = 0;
            this.grbLecturer.TabStop = false;
            this.grbLecturer.Text = "Lecturer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLecturerLogin);
            this.panel1.Controls.Add(this.txtLecturerPassword);
            this.panel1.Controls.Add(this.txtLecturerLogin);
            this.panel1.Controls.Add(this.lblLecturerPassword);
            this.panel1.Controls.Add(this.lblLecturerLogin);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(6, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 430);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(734, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(14, 293);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(126, 40);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Go to menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblLecturerLogin
            // 
            this.lblLecturerLogin.AutoSize = true;
            this.lblLecturerLogin.Location = new System.Drawing.Point(390, 304);
            this.lblLecturerLogin.Name = "lblLecturerLogin";
            this.lblLecturerLogin.Size = new System.Drawing.Size(105, 20);
            this.lblLecturerLogin.TabIndex = 2;
            this.lblLecturerLogin.Text = "Lecturer ID:";
            // 
            // lblLecturerPassword
            // 
            this.lblLecturerPassword.AutoSize = true;
            this.lblLecturerPassword.Location = new System.Drawing.Point(404, 338);
            this.lblLecturerPassword.Name = "lblLecturerPassword";
            this.lblLecturerPassword.Size = new System.Drawing.Size(91, 20);
            this.lblLecturerPassword.TabIndex = 3;
            this.lblLecturerPassword.Text = "Password:";
            // 
            // txtLecturerLogin
            // 
            this.txtLecturerLogin.Location = new System.Drawing.Point(515, 298);
            this.txtLecturerLogin.Name = "txtLecturerLogin";
            this.txtLecturerLogin.Size = new System.Drawing.Size(178, 26);
            this.txtLecturerLogin.TabIndex = 4;
            // 
            // txtLecturerPassword
            // 
            this.txtLecturerPassword.Location = new System.Drawing.Point(515, 338);
            this.txtLecturerPassword.Name = "txtLecturerPassword";
            this.txtLecturerPassword.Size = new System.Drawing.Size(178, 26);
            this.txtLecturerPassword.TabIndex = 5;
            // 
            // btnLecturerLogin
            // 
            this.btnLecturerLogin.Location = new System.Drawing.Point(515, 370);
            this.btnLecturerLogin.Name = "btnLecturerLogin";
            this.btnLecturerLogin.Size = new System.Drawing.Size(109, 40);
            this.btnLecturerLogin.TabIndex = 6;
            this.btnLecturerLogin.Text = "Login";
            this.btnLecturerLogin.UseVisualStyleBackColor = true;
            // 
            // frmLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.grbLecturer);
            this.Name = "frmLecturer";
            this.Text = "frmLecturer";
            this.grbLecturer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLecturer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLecturerLogin;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblLecturerPassword;
        private System.Windows.Forms.Button btnLecturerLogin;
        private System.Windows.Forms.TextBox txtLecturerPassword;
        private System.Windows.Forms.TextBox txtLecturerLogin;
    }
}