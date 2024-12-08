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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.Show();
			this.Hide();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3();
			form3.Show();
			this.Hide();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Form4 form4 = new Form4();
			form4.Show();
			this.Hide();

		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
