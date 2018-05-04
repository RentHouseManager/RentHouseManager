using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentHouseManager.Project.Presenter
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formlogin fm = new Formlogin();
            fm.Show();
        }

        private void khuTrọToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Formlistroom fm = new Formlistroom();
            fm.MdiParent = this;
            fm.Show();            
        }

        private void FormParent_Load(object sender, EventArgs e)
        {
            formHeThong fm = new formHeThong();
            fm.MdiParent = this;
            fm.Show();
        }
        private void HIDE()
        {
            formHeThong fm = new formHeThong();
            fm.Hide();
        }

        private void MenuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            HIDE();
        }
    }
}
