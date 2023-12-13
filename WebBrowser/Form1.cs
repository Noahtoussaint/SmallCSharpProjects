using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
	public partial class Index : Form
	{
		public Index()
		{
			InitializeComponent();
		}

		private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				webBrowser1.Navigate(toolStripComboBox1.Text);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			webBrowser1.GoBack();
		}

		private void btnForward_Click(object sender, EventArgs e)
		{
			webBrowser1.GoForward();
		}

		private void Go_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate(toolStripComboBox1.Text);
		}

		
	}
}
