using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1dv6_1_4_gissa_det_hemliga_talet
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			PlaceHolder1.Visible = false;
			PlaceHolder2.Visible = false;
			PlaceHolder3.Visible = false;
			GuessTextBox.Focus();
		}

		protected void SendButton_Click(object sender, EventArgs e)
		{
			if (IsValid) 
			{
				PlaceHolder1.Visible = true;
				PlaceHolder3.Visible = true;
				ShowGuessLabel.Text = String.Format(" <img src='Images/close16.png' /> U did it!");

			}
		}

		protected void NewSecretNoButton_Click(object sender, EventArgs e)
		{

		}
	}
}