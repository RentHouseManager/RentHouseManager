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
            
        }

        int i = 10;
        private void timerRun_Tick(object sender, EventArgs e)
        {
            lbChu.Location = new Point(lbChu.Location.X + i, lbChu.Location.Y);
            if(lbChu.Location.X>795||lbChu.Location.Y<=0)
            {
                lbChu.Location = new Point(lbChu.Location.X - 795);
            }
        }
    }
}
