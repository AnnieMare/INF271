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
    public partial class DeleteTripPricing : Form
    {
        public DeleteTripPricing()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The trip pricing"  + "\n" + "Trip Type: 2 hours" + "\n" + "Trip Price: R800" + "\n" + "Date added: 27 March 2017" + "\n" + "has been deleted successfully.", "Delete Trip Pricing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The deletion has been cancelled.", "Delete Trip Pricing", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }
    }
}
