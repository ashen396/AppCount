/*
 * Created by SharpDevelop.
 * User: Ashen Renon
 * Date: 9/1/2021
 * Time: 10:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AppCount
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel = new System.Windows.Forms.Panel();
			this.pb_logo = new System.Windows.Forms.PictureBox();
			this.pb_add = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_add)).BeginInit();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.AutoScroll = true;
			this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.panel.Location = new System.Drawing.Point(0, 75);
			this.panel.Margin = new System.Windows.Forms.Padding(0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(990, 500);
			this.panel.TabIndex = 0;
			// 
			// pb_logo
			// 
			this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
			this.pb_logo.Location = new System.Drawing.Point(3, 12);
			this.pb_logo.Name = "pb_logo";
			this.pb_logo.Size = new System.Drawing.Size(453, 110);
			this.pb_logo.TabIndex = 1;
			this.pb_logo.TabStop = false;
			// 
			// pb_add
			// 
			this.pb_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pb_add.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb_add.Image = ((System.Drawing.Image)(resources.GetObject("pb_add.Image")));
			this.pb_add.Location = new System.Drawing.Point(800, 53);
			this.pb_add.Name = "pb_add";
			this.pb_add.Size = new System.Drawing.Size(100, 40);
			this.pb_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_add.TabIndex = 2;
			this.pb_add.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(989, 583);
			this.Controls.Add(this.pb_add);
			this.Controls.Add(this.pb_logo);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AppCount";
			this.Activated += new System.EventHandler(this.MainFormShown);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.MouseHover += new System.EventHandler(this.MainFormShown);
			((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_add)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pb_add;
		private System.Windows.Forms.PictureBox pb_logo;
		private System.Windows.Forms.Panel panel;
	}
}
