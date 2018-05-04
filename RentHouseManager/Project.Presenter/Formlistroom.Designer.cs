namespace RentHouseManager.Project.Presenter
{
    partial class Formlistroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlistroom));
            this.listroomlBl = new System.Windows.Forms.Label();
            this.thanhcongcupNl = new System.Windows.Forms.Panel();
            this.khutroLbl = new System.Windows.Forms.Label();
            this.khutroCombobox = new System.Windows.Forms.ComboBox();
            this.daytroCombobox = new System.Windows.Forms.ComboBox();
            this.daytroLbl = new System.Windows.Forms.Label();
            this.phongtroCombobox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.phongLbl = new System.Windows.Forms.Label();
            this.thongtinphongpNl = new System.Windows.Forms.Panel();
            this.songuoitoidaTxt = new System.Windows.Forms.TextBox();
            this.phongtrongkhongRadiobtn = new System.Windows.Forms.RadioButton();
            this.phongtrongcoRadiobtn = new System.Windows.Forms.RadioButton();
            this.dientichTxt = new System.Windows.Forms.TextBox();
            this.chatluongTxt = new System.Windows.Forms.TextBox();
            this.idphongTxt = new System.Windows.Forms.TextBox();
            this.songuoitoidaLbl = new System.Windows.Forms.Label();
            this.phongtrongLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dientichLbl = new System.Windows.Forms.Label();
            this.chatluongLbl = new System.Windows.Forms.Label();
            this.idphonglBl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thanhcongcupNl.SuspendLayout();
            this.thongtinphongpNl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listroomlBl
            // 
            this.listroomlBl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listroomlBl.AutoSize = true;
            this.listroomlBl.BackColor = System.Drawing.SystemColors.Control;
            this.listroomlBl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listroomlBl.ForeColor = System.Drawing.Color.Red;
            this.listroomlBl.Location = new System.Drawing.Point(244, 23);
            this.listroomlBl.Name = "listroomlBl";
            this.listroomlBl.Size = new System.Drawing.Size(366, 31);
            this.listroomlBl.TabIndex = 0;
            this.listroomlBl.Text = "DANH SÁCH PHÒNG TRỌ";
            // 
            // thanhcongcupNl
            // 
            this.thanhcongcupNl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thanhcongcupNl.Controls.Add(this.khutroLbl);
            this.thanhcongcupNl.Controls.Add(this.khutroCombobox);
            this.thanhcongcupNl.Controls.Add(this.daytroCombobox);
            this.thanhcongcupNl.Controls.Add(this.daytroLbl);
            this.thanhcongcupNl.Controls.Add(this.phongtroCombobox);
            this.thanhcongcupNl.Controls.Add(this.searchBtn);
            this.thanhcongcupNl.Controls.Add(this.phongLbl);
            this.thanhcongcupNl.Location = new System.Drawing.Point(22, 67);
            this.thanhcongcupNl.Name = "thanhcongcupNl";
            this.thanhcongcupNl.Size = new System.Drawing.Size(793, 34);
            this.thanhcongcupNl.TabIndex = 1;
            // 
            // khutroLbl
            // 
            this.khutroLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.khutroLbl.AutoSize = true;
            this.khutroLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khutroLbl.Location = new System.Drawing.Point(3, 11);
            this.khutroLbl.Name = "khutroLbl";
            this.khutroLbl.Size = new System.Drawing.Size(68, 16);
            this.khutroLbl.TabIndex = 0;
            this.khutroLbl.Text = "KHU TRỌ";
            // 
            // khutroCombobox
            // 
            this.khutroCombobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.khutroCombobox.AutoCompleteCustomSource.AddRange(new string[] {
            "Dãy A",
            "Dãy B",
            "Dãy C",
            "Dãy D"});
            this.khutroCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.khutroCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.khutroCombobox.FormattingEnabled = true;
            this.khutroCombobox.Items.AddRange(new object[] {
            "Khu A",
            "Khu B",
            "Khu C"});
            this.khutroCombobox.Location = new System.Drawing.Point(77, 9);
            this.khutroCombobox.Name = "khutroCombobox";
            this.khutroCombobox.Size = new System.Drawing.Size(72, 21);
            this.khutroCombobox.Sorted = true;
            this.khutroCombobox.TabIndex = 3;
            // 
            // daytroCombobox
            // 
            this.daytroCombobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.daytroCombobox.AutoCompleteCustomSource.AddRange(new string[] {
            "Dãy 1",
            "Dãy 2",
            "Dãy 3",
            "Dãy 4"});
            this.daytroCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.daytroCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.daytroCombobox.FormattingEnabled = true;
            this.daytroCombobox.Items.AddRange(new object[] {
            "Dãy 1",
            "Dãy 2",
            "Dãy 3",
            "Dãy 4"});
            this.daytroCombobox.Location = new System.Drawing.Point(248, 9);
            this.daytroCombobox.Name = "daytroCombobox";
            this.daytroCombobox.Size = new System.Drawing.Size(72, 21);
            this.daytroCombobox.TabIndex = 4;
            // 
            // daytroLbl
            // 
            this.daytroLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.daytroLbl.AutoSize = true;
            this.daytroLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daytroLbl.Location = new System.Drawing.Point(174, 11);
            this.daytroLbl.Name = "daytroLbl";
            this.daytroLbl.Size = new System.Drawing.Size(68, 16);
            this.daytroLbl.TabIndex = 1;
            this.daytroLbl.Text = "DÃY TRỌ";
            // 
            // phongtroCombobox
            // 
            this.phongtroCombobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phongtroCombobox.AutoCompleteCustomSource.AddRange(new string[] {
            "P.001",
            "P.002",
            "P.003",
            "P.004",
            "P.005",
            "P.006",
            "P.007",
            "P.008",
            "P.009",
            "P.010"});
            this.phongtroCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.phongtroCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.phongtroCombobox.Cursor = System.Windows.Forms.Cursors.Default;
            this.phongtroCombobox.DisplayMember = "All";
            this.phongtroCombobox.FormattingEnabled = true;
            this.phongtroCombobox.Items.AddRange(new object[] {
            "P.001",
            "P.002",
            "P.003",
            "P.004",
            "P.005",
            "P.006",
            "P.007",
            "P.008",
            "P.009",
            "P.010"});
            this.phongtroCombobox.Location = new System.Drawing.Point(415, 9);
            this.phongtroCombobox.Name = "phongtroCombobox";
            this.phongtroCombobox.Size = new System.Drawing.Size(70, 21);
            this.phongtroCombobox.TabIndex = 5;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BackColor = System.Drawing.SystemColors.Control;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(542, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(89, 27);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "TÌM KIẾM";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // phongLbl
            // 
            this.phongLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phongLbl.AutoSize = true;
            this.phongLbl.BackColor = System.Drawing.SystemColors.Control;
            this.phongLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phongLbl.Location = new System.Drawing.Point(352, 11);
            this.phongLbl.Name = "phongLbl";
            this.phongLbl.Size = new System.Drawing.Size(57, 16);
            this.phongLbl.TabIndex = 2;
            this.phongLbl.Text = "PHÒNG";
            // 
            // thongtinphongpNl
            // 
            this.thongtinphongpNl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thongtinphongpNl.Controls.Add(this.songuoitoidaTxt);
            this.thongtinphongpNl.Controls.Add(this.phongtrongkhongRadiobtn);
            this.thongtinphongpNl.Controls.Add(this.phongtrongcoRadiobtn);
            this.thongtinphongpNl.Controls.Add(this.dientichTxt);
            this.thongtinphongpNl.Controls.Add(this.chatluongTxt);
            this.thongtinphongpNl.Controls.Add(this.idphongTxt);
            this.thongtinphongpNl.Controls.Add(this.songuoitoidaLbl);
            this.thongtinphongpNl.Controls.Add(this.phongtrongLbl);
            this.thongtinphongpNl.Controls.Add(this.label4);
            this.thongtinphongpNl.Controls.Add(this.dientichLbl);
            this.thongtinphongpNl.Controls.Add(this.chatluongLbl);
            this.thongtinphongpNl.Controls.Add(this.idphonglBl);
            this.thongtinphongpNl.Controls.Add(this.pictureBox1);
            this.thongtinphongpNl.Controls.Add(this.label1);
            this.thongtinphongpNl.Location = new System.Drawing.Point(533, 119);
            this.thongtinphongpNl.Name = "thongtinphongpNl";
            this.thongtinphongpNl.Size = new System.Drawing.Size(296, 422);
            this.thongtinphongpNl.TabIndex = 2;
            // 
            // songuoitoidaTxt
            // 
            this.songuoitoidaTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.songuoitoidaTxt.Location = new System.Drawing.Point(126, 220);
            this.songuoitoidaTxt.Name = "songuoitoidaTxt";
            this.songuoitoidaTxt.Size = new System.Drawing.Size(149, 20);
            this.songuoitoidaTxt.TabIndex = 13;
            // 
            // phongtrongkhongRadiobtn
            // 
            this.phongtrongkhongRadiobtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phongtrongkhongRadiobtn.AutoSize = true;
            this.phongtrongkhongRadiobtn.Location = new System.Drawing.Point(206, 181);
            this.phongtrongkhongRadiobtn.Name = "phongtrongkhongRadiobtn";
            this.phongtrongkhongRadiobtn.Size = new System.Drawing.Size(56, 17);
            this.phongtrongkhongRadiobtn.TabIndex = 12;
            this.phongtrongkhongRadiobtn.TabStop = true;
            this.phongtrongkhongRadiobtn.Text = "Không";
            this.phongtrongkhongRadiobtn.UseVisualStyleBackColor = true;
            // 
            // phongtrongcoRadiobtn
            // 
            this.phongtrongcoRadiobtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phongtrongcoRadiobtn.AutoSize = true;
            this.phongtrongcoRadiobtn.Location = new System.Drawing.Point(135, 181);
            this.phongtrongcoRadiobtn.Name = "phongtrongcoRadiobtn";
            this.phongtrongcoRadiobtn.Size = new System.Drawing.Size(38, 17);
            this.phongtrongcoRadiobtn.TabIndex = 11;
            this.phongtrongcoRadiobtn.TabStop = true;
            this.phongtrongcoRadiobtn.Text = "Có";
            this.phongtrongcoRadiobtn.UseVisualStyleBackColor = true;
            // 
            // dientichTxt
            // 
            this.dientichTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dientichTxt.Location = new System.Drawing.Point(126, 142);
            this.dientichTxt.Name = "dientichTxt";
            this.dientichTxt.Size = new System.Drawing.Size(149, 20);
            this.dientichTxt.TabIndex = 10;
            // 
            // chatluongTxt
            // 
            this.chatluongTxt.Location = new System.Drawing.Point(126, 93);
            this.chatluongTxt.Name = "chatluongTxt";
            this.chatluongTxt.Size = new System.Drawing.Size(149, 20);
            this.chatluongTxt.TabIndex = 9;
            // 
            // idphongTxt
            // 
            this.idphongTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idphongTxt.Location = new System.Drawing.Point(126, 63);
            this.idphongTxt.Name = "idphongTxt";
            this.idphongTxt.Size = new System.Drawing.Size(149, 20);
            this.idphongTxt.TabIndex = 8;
            // 
            // songuoitoidaLbl
            // 
            this.songuoitoidaLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.songuoitoidaLbl.AutoSize = true;
            this.songuoitoidaLbl.Location = new System.Drawing.Point(21, 223);
            this.songuoitoidaLbl.Name = "songuoitoidaLbl";
            this.songuoitoidaLbl.Size = new System.Drawing.Size(99, 13);
            this.songuoitoidaLbl.TabIndex = 7;
            this.songuoitoidaLbl.Text = "SỐ NGƯỜI TỐI ĐA";
            // 
            // phongtrongLbl
            // 
            this.phongtrongLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phongtrongLbl.AutoSize = true;
            this.phongtrongLbl.Location = new System.Drawing.Point(21, 185);
            this.phongtrongLbl.Name = "phongtrongLbl";
            this.phongtrongLbl.Size = new System.Drawing.Size(88, 13);
            this.phongtrongLbl.TabIndex = 6;
            this.phongtrongLbl.Text = "PHÒNG TRỐNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // dientichLbl
            // 
            this.dientichLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dientichLbl.AutoSize = true;
            this.dientichLbl.Location = new System.Drawing.Point(21, 145);
            this.dientichLbl.Name = "dientichLbl";
            this.dientichLbl.Size = new System.Drawing.Size(61, 13);
            this.dientichLbl.TabIndex = 4;
            this.dientichLbl.Text = "DIỆN TÍCH";
            // 
            // chatluongLbl
            // 
            this.chatluongLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chatluongLbl.AutoSize = true;
            this.chatluongLbl.Location = new System.Drawing.Point(21, 104);
            this.chatluongLbl.Name = "chatluongLbl";
            this.chatluongLbl.Size = new System.Drawing.Size(77, 13);
            this.chatluongLbl.TabIndex = 3;
            this.chatluongLbl.Text = "CHẤT LƯỢNG";
            // 
            // idphonglBl
            // 
            this.idphonglBl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idphonglBl.AutoSize = true;
            this.idphonglBl.Location = new System.Drawing.Point(21, 66);
            this.idphonglBl.Name = "idphonglBl";
            this.idphonglBl.Size = new System.Drawing.Size(60, 13);
            this.idphonglBl.TabIndex = 2;
            this.idphonglBl.Text = "ID PHÒNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN PHÒNG";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.thongtinphongpNl);
            this.panel1.Controls.Add(this.listroomlBl);
            this.panel1.Controls.Add(this.thanhcongcupNl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 553);
            this.panel1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(22, 119);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(505, 422);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Khu trọ";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dãy trọ";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phòng";
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.Width = 194;
            // 
            // Formlistroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 553);
            this.Controls.Add(this.panel1);
            this.Name = "Formlistroom";
            this.Load += new System.EventHandler(this.Formlistroom_Load);
            this.thanhcongcupNl.ResumeLayout(false);
            this.thanhcongcupNl.PerformLayout();
            this.thongtinphongpNl.ResumeLayout(false);
            this.thongtinphongpNl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label listroomlBl;
        private System.Windows.Forms.Panel thanhcongcupNl;
        private System.Windows.Forms.Panel thongtinphongpNl;
        private System.Windows.Forms.ComboBox phongtroCombobox;
        private System.Windows.Forms.ComboBox daytroCombobox;
        private System.Windows.Forms.ComboBox khutroCombobox;
        private System.Windows.Forms.Label phongLbl;
        private System.Windows.Forms.Label daytroLbl;
        private System.Windows.Forms.Label khutroLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox songuoitoidaTxt;
        private System.Windows.Forms.RadioButton phongtrongkhongRadiobtn;
        private System.Windows.Forms.RadioButton phongtrongcoRadiobtn;
        private System.Windows.Forms.TextBox dientichTxt;
        private System.Windows.Forms.TextBox chatluongTxt;
        private System.Windows.Forms.TextBox idphongTxt;
        private System.Windows.Forms.Label songuoitoidaLbl;
        private System.Windows.Forms.Label phongtrongLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dientichLbl;
        private System.Windows.Forms.Label chatluongLbl;
        private System.Windows.Forms.Label idphonglBl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}