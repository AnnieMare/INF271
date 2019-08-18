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
    public partial class SearchTripPricing : Form
    {
        public SearchTripPricing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Searched trip pricing does not exist in the database", "Search Trip Pricing", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
