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
    public partial class GenerateIndemnity : Form
    {
        public GenerateIndemnity()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" )
            {
                MessageBox.Show("Not all fields filled in, please insure all fields are filled in. ");
            }
            else
            {
                GenerateTicket GT = new GenerateTicket();
                GT.ShowDialog();
                this.Close();
            }
        }
    }
}
