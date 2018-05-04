namespace RentHouseManager
{
    partial class formHeThong
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
            this.lbChu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerRun = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbChu
            // 
            this.lbChu.AutoSize = true;
            this.lbChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChu.Location = new System.Drawing.Point(3, 34);
            this.lbChu.Name = "lbChu";
            this.lbChu.Size = new System.Drawing.Size(556, 33);
            this.lbChu.TabIndex = 0;
            this.lbChu.Text = "Chào bạn đến với hệ thống trọ thông minh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbChu);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 105);
            this.panel1.TabIndex = 1;
            // 
            // timerRun
            // 
            this.timerRun.Interval = 1000;
            // 
            // formHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel1);
            this.Name = "formHeThong";
            this.Text = "formHeThong";
            this.Load += new System.EventHandler(this.formHeThong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbChu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerRun;
    }
}