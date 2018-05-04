namespace RentHouseManager.Project.Presenter
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.typeLbl = new System.Windows.Forms.Label();
            this.quanlivienRadiobtn = new System.Windows.Forms.RadioButton();
            this.nguoiquanliRadiobtn = new System.Windows.Forms.RadioButton();
            this.dangnhapLbl = new System.Windows.Forms.Label();
            this.dangnhapBtn = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.loginpic = new System.Windows.Forms.PictureBox();
            this.khachRadiobtn = new System.Windows.Forms.RadioButton();
            this.loginPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginpic)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.panel1);
            this.loginPanel.Controls.Add(this.dangnhapLbl);
            this.loginPanel.Controls.Add(this.dangnhapBtn);
            this.loginPanel.Controls.Add(this.passwordTxt);
            this.loginPanel.Controls.Add(this.passwordLbl);
            this.loginPanel.Controls.Add(this.usernameLbl);
            this.loginPanel.Controls.Add(this.usernameTxt);
            this.loginPanel.Controls.Add(this.loginpic);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(510, 362);
            this.loginPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.typeLbl);
            this.panel1.Controls.Add(this.quanlivienRadiobtn);
            this.panel1.Controls.Add(this.khachRadiobtn);
            this.panel1.Controls.Add(this.nguoiquanliRadiobtn);
            this.panel1.Location = new System.Drawing.Point(176, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 119);
            this.panel1.TabIndex = 16;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLbl.Location = new System.Drawing.Point(3, 18);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(171, 20);
            this.typeLbl.TabIndex = 14;
            this.typeLbl.Text = "Đăng nhập với tư cách:";
            // 
            // quanlivienRadiobtn
            // 
            this.quanlivienRadiobtn.AutoSize = true;
            this.quanlivienRadiobtn.Location = new System.Drawing.Point(7, 53);
            this.quanlivienRadiobtn.Name = "quanlivienRadiobtn";
            this.quanlivienRadiobtn.Size = new System.Drawing.Size(85, 17);
            this.quanlivienRadiobtn.TabIndex = 13;
            this.quanlivienRadiobtn.TabStop = true;
            this.quanlivienRadiobtn.Text = "Quản trị viên";
            this.quanlivienRadiobtn.UseVisualStyleBackColor = true;
            // 
            // nguoiquanliRadiobtn
            // 
            this.nguoiquanliRadiobtn.AutoSize = true;
            this.nguoiquanliRadiobtn.Location = new System.Drawing.Point(7, 76);
            this.nguoiquanliRadiobtn.Name = "nguoiquanliRadiobtn";
            this.nguoiquanliRadiobtn.Size = new System.Drawing.Size(89, 17);
            this.nguoiquanliRadiobtn.TabIndex = 11;
            this.nguoiquanliRadiobtn.TabStop = true;
            this.nguoiquanliRadiobtn.Text = "Người quản lí";
            this.nguoiquanliRadiobtn.UseVisualStyleBackColor = true;
            // 
            // dangnhapLbl
            // 
            this.dangnhapLbl.AutoSize = true;
            this.dangnhapLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhapLbl.ForeColor = System.Drawing.Color.Red;
            this.dangnhapLbl.Location = new System.Drawing.Point(170, 27);
            this.dangnhapLbl.Name = "dangnhapLbl";
            this.dangnhapLbl.Size = new System.Drawing.Size(185, 31);
            this.dangnhapLbl.TabIndex = 15;
            this.dangnhapLbl.Text = "ĐĂNG NHẬP";
            // 
            // dangnhapBtn
            // 
            this.dangnhapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhapBtn.Location = new System.Drawing.Point(364, 242);
            this.dangnhapBtn.Name = "dangnhapBtn";
            this.dangnhapBtn.Size = new System.Drawing.Size(119, 49);
            this.dangnhapBtn.TabIndex = 10;
            this.dangnhapBtn.Text = "Đăng nhập";
            this.dangnhapBtn.UseVisualStyleBackColor = true;
            this.dangnhapBtn.Click += new System.EventHandler(this.dangnhapBtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(297, 152);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(186, 20);
            this.passwordTxt.TabIndex = 9;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(186, 152);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(69, 18);
            this.passwordLbl.TabIndex = 8;
            this.passwordLbl.Text = "Mật khẩu";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(186, 96);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(105, 18);
            this.usernameLbl.TabIndex = 7;
            this.usernameLbl.Text = "Tên đăng nhập";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(297, 94);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(186, 20);
            this.usernameTxt.TabIndex = 6;
            // 
            // loginpic
            // 
            this.loginpic.Image = ((System.Drawing.Image)(resources.GetObject("loginpic.Image")));
            this.loginpic.Location = new System.Drawing.Point(12, 94);
            this.loginpic.Name = "loginpic";
            this.loginpic.Size = new System.Drawing.Size(150, 175);
            this.loginpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginpic.TabIndex = 5;
            this.loginpic.TabStop = false;
            // 
            // khachRadiobtn
            // 
            this.khachRadiobtn.AutoSize = true;
            this.khachRadiobtn.Location = new System.Drawing.Point(7, 99);
            this.khachRadiobtn.Name = "khachRadiobtn";
            this.khachRadiobtn.Size = new System.Drawing.Size(56, 17);
            this.khachRadiobtn.TabIndex = 12;
            this.khachRadiobtn.TabStop = true;
            this.khachRadiobtn.Text = "Khách";
            this.khachRadiobtn.UseVisualStyleBackColor = true;
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 362);
            this.Controls.Add(this.loginPanel);
            this.Name = "Formlogin";
            this.Text = "Đăng nhập";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.RadioButton quanlivienRadiobtn;
        private System.Windows.Forms.RadioButton nguoiquanliRadiobtn;
        private System.Windows.Forms.Button dangnhapBtn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.PictureBox loginpic;
        private System.Windows.Forms.Label dangnhapLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton khachRadiobtn;
    }
}

