/*
 * Created by SharpDevelop.
 * User: joilma
 * Date: 27/09/2022
 * Time: 20:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TesteVideo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.CheckBox chkAutoplay;
		private System.Windows.Forms.Button btnCarregar;
		private System.Windows.Forms.ListView lvlVideo;
		private System.Windows.Forms.WebBrowser wbVideo;
		
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.chkAutoplay = new System.Windows.Forms.CheckBox();
			this.btnCarregar = new System.Windows.Forms.Button();
			this.lvlVideo = new System.Windows.Forms.ListView();
			this.wbVideo = new System.Windows.Forms.WebBrowser();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lvlVideo, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.wbVideo, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 470);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.Controls.Add(this.txtURL, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.chkAutoplay, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnCarregar, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(898, 41);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// txtURL
			// 
			this.txtURL.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtURL.Location = new System.Drawing.Point(3, 3);
			this.txtURL.Multiline = true;
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(622, 35);
			this.txtURL.TabIndex = 0;
			// 
			// chkAutoplay
			// 
			this.chkAutoplay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chkAutoplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkAutoplay.Location = new System.Drawing.Point(631, 3);
			this.chkAutoplay.Name = "chkAutoplay";
			this.chkAutoplay.Size = new System.Drawing.Size(173, 35);
			this.chkAutoplay.TabIndex = 1;
			this.chkAutoplay.Text = "AutoPlay";
			this.chkAutoplay.UseVisualStyleBackColor = true;
			// 
			// btnCarregar
			// 
			this.btnCarregar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCarregar.Location = new System.Drawing.Point(810, 3);
			this.btnCarregar.Name = "btnCarregar";
			this.btnCarregar.Size = new System.Drawing.Size(85, 35);
			this.btnCarregar.TabIndex = 2;
			this.btnCarregar.Text = "Carregar";
			this.btnCarregar.UseVisualStyleBackColor = true;
			this.btnCarregar.Click += new System.EventHandler(this.BtnCarregarClick);
			// 
			// lvlVideo
			// 
			this.lvlVideo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvlVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvlVideo.Location = new System.Drawing.Point(3, 50);
			this.lvlVideo.Name = "lvlVideo";
			this.lvlVideo.Size = new System.Drawing.Size(898, 88);
			this.lvlVideo.TabIndex = 1;
			this.lvlVideo.UseCompatibleStateImageBehavior = false;
			// 
			// wbVideo
			// 
			this.wbVideo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbVideo.Location = new System.Drawing.Point(3, 144);
			this.wbVideo.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbVideo.Name = "wbVideo";
			this.wbVideo.Size = new System.Drawing.Size(898, 323);
			this.wbVideo.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(904, 470);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MainForm";
			this.Text = "TesteVideo";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
