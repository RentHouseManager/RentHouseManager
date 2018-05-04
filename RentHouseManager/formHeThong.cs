using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentHouseManager
{
    public partial class formHeThong : Form
    {
        public formHeThong()
        {
            InitializeComponent();
        }

        private void formHeThong_Load(object sender, EventArgs e)
        {
            timerRun.Enabled = true;
            lbChu.Location = new Point(lbChu.Location.X, lbChu.Location.Y);
            if(lbChu.Location.X>panel1.Location.X||lbChu.Location.X<=0)
            {
                lbChu.Location = new Point(lbChu.Location.X - panel1.Location.X, lbChu.Location.Y);
            }
        }
    }
}
