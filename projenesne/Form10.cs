﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projenesne
{
	public partial class Form10 : Form
	{
		public Form10()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form7 form7 = new Form7();
			form7.Show();
			this.Hide();

		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}

