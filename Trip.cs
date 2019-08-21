using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleTrip
{
    public partial class Trip : Form
    {
        public Trip()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.ShowDialog();
            this.Close();
        }
    }
}
