using System;
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
	public partial class Form7 : Form
	{
		public Form7()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Form9 form = new Form9();
			form.Show();
			this.Hide();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Form8 form = new Form8();
			form.Show();
			this.Hide();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Form10 form = new Form10();
			form.Show(); this.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
