﻿using System;
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
    public partial class CreateTripPricing : Form
    {
        public CreateTripPricing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trip pricing 2 HOURS - R1000p/p is created on 18 AUGUST 2019", "Create Trip Pricing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trip pricing creation cancelled", "Create Trip Pricing", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }
    }
}
