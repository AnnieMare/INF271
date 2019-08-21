using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_in
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking Exists, may proceed with Check-in");
            MessageBox.Show("Booking Does not exist, please re-enter booking ID");
            button2.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            GenerateIndemnity GI = new GenerateIndemnity();
            GI.ShowDialog();
            this.Close();
        }
    }
}
