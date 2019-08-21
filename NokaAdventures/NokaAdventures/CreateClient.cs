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
    public partial class CreateClient : Form
    {
        public CreateClient()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name;
            string surname;

            name = txtName.Text;
            surname = txtName.Text;

            if (name != null && surname != null)
            {
                MessageBox.Show(name + " " + surname + " " + "has been successfully add as a new client!",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is an error trying to add the client.  Please see that all fields are completed.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
