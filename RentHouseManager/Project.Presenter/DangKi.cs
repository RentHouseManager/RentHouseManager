using RentHouseManager.Project.BLL.AccountRepository;
using RentHouseManager.Project.BLL.RenterRepository;
using RentHouseManager.Project.Common.CommonModels;
using RentHouseManager.Project.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentHouseManager.Project.Presenter
{
    public partial class DangKi : Form
    {
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtNhapLaiMK;
        private Label label3;
        private TextBox txtMatKhau;
        private Label label2;
        private TextBox txtTenDN;
        private Button btnDki;
        private Panel PanelGioiTinh;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label10;
        private TextBox txtCMND;
        private TextBox txtQueQuan;
        private TextBox txtSDT;
        private Label label9;
        private TextBox txtHoTen;
        private Button button2;
        private DateTimePicker birthdayPicker;
        private Label label11;
        private Label label1;
    
        public DangKi()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDki = new System.Windows.Forms.Button();
            this.PanelGioiTinh = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PanelGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.birthdayPicker);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnDki);
            this.panel1.Controls.Add(this.PanelGioiTinh);
            this.panel1.Controls.Add(this.txtCMND);
            this.panel1.Controls.Add(this.txtQueQuan);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNhapLaiMK);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenDN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(600, 514);
            this.panel1.TabIndex = 0;
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(275, 357);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(212, 20);
            this.birthdayPicker.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Ngày tháng năm sinh";
            // 
            // btnDki
            // 
            this.btnDki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDki.Location = new System.Drawing.Point(476, 449);
            this.btnDki.Name = "btnDki";
            this.btnDki.Size = new System.Drawing.Size(97, 37);
            this.btnDki.TabIndex = 32;
            this.btnDki.Text = "Đăng Ký";
            this.btnDki.UseVisualStyleBackColor = true;
            this.btnDki.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelGioiTinh
            // 
            this.PanelGioiTinh.AutoSize = true;
            this.PanelGioiTinh.Controls.Add(this.radioButton3);
            this.PanelGioiTinh.Controls.Add(this.radioButton2);
            this.PanelGioiTinh.Controls.Add(this.radioButton1);
            this.PanelGioiTinh.Controls.Add(this.label10);
            this.PanelGioiTinh.Location = new System.Drawing.Point(49, 415);
            this.PanelGioiTinh.Name = "PanelGioiTinh";
            this.PanelGioiTinh.Size = new System.Drawing.Size(312, 71);
            this.PanelGioiTinh.TabIndex = 31;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(203, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(63, 24);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Khác";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(113, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(12, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Giới tính";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(275, 331);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(212, 20);
            this.txtCMND.TabIndex = 30;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(275, 305);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(212, 20);
            this.txtQueQuan.TabIndex = 29;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(275, 279);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(212, 20);
            this.txtSDT.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "CMND";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(275, 144);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(212, 20);
            this.txtHoTen.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Quê quán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Họ tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "SDT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(102, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 42);
            this.label5.TabIndex = 21;
            this.label5.Text = "ĐĂNG KÝ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(275, 253);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Location = new System.Drawing.Point(275, 222);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.Size = new System.Drawing.Size(212, 20);
            this.txtNhapLaiMK.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(275, 196);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(212, 20);
            this.txtMatKhau.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(275, 170);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(212, 20);
            this.txtTenDN.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên đăng nhập";
            // 
            // DangKi
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 514);
            this.Controls.Add(this.panel1);
            this.Name = "DangKi";
            this.Text = "Dang Ky";
            this.Load += new System.EventHandler(this.DangKi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelGioiTinh.ResumeLayout(false);
            this.PanelGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form fm = new formHeThong();
            fm.Show();
        }

        private void DangKi_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var saveAccountService = new SaveAccountRepository();
            var insertNewRenterService = new InsertRenterRepository();
            var newRenter = new NGTHUE();
            var newAccount = new ACCOUNT();

            newAccount.IDUSER = txtTenDN.Text;
            newAccount.USERPASS = txtMatKhau.Text;
            newAccount.PRIVILIGES = AccountType.Renter.GetHashCode();

            newRenter.CMND = txtCMND.Text;
            newRenter.HOTEN = txtHoTen.Text;
            newRenter.IDNGTHUE = txtCMND.Text;
            newRenter.NGAYSINH = birthdayPicker.Value;
            newRenter.SDT = txtSDT.Text;
            if (radioButton1.Checked)
                newRenter.GIOITINH = radioButton1.Text;
            if (radioButton2.Checked)
                newRenter.GIOITINH = radioButton2.Text;
            if (radioButton3.Checked)
                newRenter.GIOITINH = radioButton3.Text;
            newRenter.EMAIL = txtEmail.Text;

            var accountResult = saveAccountService.SaveAccount(newAccount);
            var renterResult = insertNewRenterService.InsertNewRenter(newRenter);
            if (renterResult == true && accountResult == true)
            {
                string printedResult = string.Format("Tạo tài khoản và người thuê thành công. \nThông tin tài khoản:\nUsername: {0} \nPassword: {1}", txtTenDN.Text, txtMatKhau.Text);
                MessageBox.Show(printedResult, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VerifyData()
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    if(ctrl.Text == string.Empty)
                        ctrl.Text = "Trường này không được để trống";
                }
            }
            if (txtCMND.TextLength > 12)
                txtCMND.Text = "Số CMND không được vượt quá 12 số";
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(txtEmail.Text);
            if (!match.Success)
                txtEmail.Text = "Email không đúng định dạng";
        }
    }
}
