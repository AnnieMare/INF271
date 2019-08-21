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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Trip t = new Trip();
            t.ShowDialog();
            this.Close();
        }
    }
}
