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
    public partial class ScheduleTrip : Form
    {
        public ScheduleTrip()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
            {
                MessageBox.Show("Please ensure all information fields are filled");
            }
            else
            {
                MessageBox.Show("Trip Succesfully Scheduled");
            }
        }

        private void ScheduleTrip_Load(object sender, EventArgs e)
        {

        }
    }
}
