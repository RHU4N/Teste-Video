/*
 * Created by SharpDevelop.
 * User: joilma
 * Date: 27/09/2022
 * Time: 20:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TesteVideo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			//Exibe detalhes
			lvlVideo.View = View.Details;
			//permite selecionar a linha toda
			lvlVideo.FullRowSelect = true;
			//exibie linhas de grade no listView
			lvlVideo.GridLines=true;
			
			lvlVideo.Columns.Add("Videos", 400, HorizontalAlignment.Left);
			lvlVideo.Columns.Add("Horario", 200, HorizontalAlignment.Right);
						
			txtURL.Select();
		}
		void BtnCarregarClick(object sender, EventArgs e)
		{
			//Verificar se Url foi informado
			if(txtURL.Text.Trim().Equals(string.Empty))
			{
				MessageBox.Show("Voce deve informar a URL do Video",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			//add no listView
			ListViewItem lvl = new ListViewItem(txtURL.Text.Trim());
			lvl.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy 'às' HH:mm:ss", new CultureInfo("pt-BR")));
			lvlVideo.Items.Add(lvl);
			
			//Exibir Video
			string html = "<html><head>";
			html += "<meta content='IE=EDGE' http-equiv='X-UA-Compatible'/>";
			html += "<center><iframe id='video' src='https://www.youtube.com/autoplay/{0}' width='{1}' height='{2}' frameborder='0'allowfullscreen='true'></iframe><center>";
			html += "</body></html>";
			
			wbVideo.DocumentText = string.Format(html, txtURL.Text.Trim().Split('=')[1], wbVideo.Width -30,wbVideo.Height-30 );
			
			
			
			txtURL.Text= string.Empty;
		}
	}
}
