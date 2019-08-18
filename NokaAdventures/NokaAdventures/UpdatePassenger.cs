using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NokaAdventures
{
    public partial class UpdatePassenger : Form
    {
        public UpdatePassenger()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The update of passenger (9801124567081) is successfull.", "Update Passenger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The update of passenger (9801124567081) has been cancelled.", "Update Passenger", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }
    }
}
