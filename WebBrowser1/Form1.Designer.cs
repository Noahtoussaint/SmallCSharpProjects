using System;
using System.Windows.Forms;

namespace WebBrowser1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnBack = new System.Windows.Forms.ToolStripButton();
			this.btnForward = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cboLocation = new System.Windows.Forms.ToolStripComboBox();
			this.btnGo = new System.Windows.Forms.ToolStripButton();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnForward,
            this.toolStripSeparator1,
            this.cboLocation,
            this.btnGo});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 38);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnBack
			// 
			this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(52, 33);
			this.btnBack.Text = "Back";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnForward
			// 
			this.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
			this.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnForward.Name = "btnForward";
			this.btnForward.Size = new System.Drawing.Size(81, 33);
			this.btnForward.Text = "Forward";
			this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
			// 
			// cboLocation
			// 
			this.cboLocation.Name = "cboLocation";
			this.cboLocation.Size = new System.Drawing.Size(121, 38);
			this.cboLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboLocation_KeyDown);
			// 
			// btnGo
			// 
			this.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
			this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(39, 33);
			this.btnGo.Text = "Go";
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// webBrowser1
			// 
			this.webBrowser1.ContextMenuStrip = this.contextMenuStrip1;
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
			this.webBrowser1.Location = new System.Drawing.Point(0, 38);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(800, 412);
			this.webBrowser1.TabIndex = 1;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Form1";
			this.Text = "silver/";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			WebBrowser webBrowser = new WebBrowser();
			webBrowser.Dock = DockStyle.Fill; // Dock the WebBrowser control to fill the form
			this.Controls.Add(webBrowser);

			// Set the initial URL to navigate to
			webBrowser.Navigate("https://www.example.com");
			webBrowser.DocumentCompleted += (s, args) =>
			{
				webBrowser.Document.Window.Error += (s2, args2) => args2.Handled = true; // Suppress JavaScript errors
				webBrowser.Navigate("https://example.com");
				webBrowser.ScriptErrorsSuppressed = true;
			};
		}





		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnBack;
		private System.Windows.Forms.ToolStripButton btnForward;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox cboLocation;
		private System.Windows.Forms.ToolStripButton btnGo;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private ContextMenuStrip contextMenuStrip1;
	}
}

