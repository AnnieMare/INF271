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
    public partial class DeletePassenger : Form
    {
        public DeletePassenger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The passenger (9801124567081) has been deleted successfully.", "Delete Passenger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The deletion has been cancelled.", "Delete Passenger", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }
    }
}
