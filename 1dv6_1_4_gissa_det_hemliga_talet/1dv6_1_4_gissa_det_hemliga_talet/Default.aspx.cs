using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _1dv6_1_4_gissa_det_hemliga_talet.Model;

namespace _1dv6_1_4_gissa_det_hemliga_talet
{
	public partial class Default : System.Web.UI.Page
	{
		// Egenskap
		private SecretNumber SecretNumber
		{
			get
			{
				if (Session["SecretNumber"] == null)
				{
					Session["SecretNumber"] = new SecretNumber();
					return (SecretNumber)Session["SecretNumber"];
				}
				else
				{
					return (SecretNumber)Session["SecretNumber"];
				}
			}
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			GuessTextBox.Focus();
		}

		protected void SendButton_Click(object sender, EventArgs e)
		{
			if (IsValid) 
			{
				int choice = int.Parse(GuessTextBox.Text);
				Outcome answer = SecretNumber.MakeGuess(choice);
				ShowGuessLabel.Text = string.Join(", ", SecretNumber.PreviousGuesses);
				
				if (answer == Outcome.High)
				{
					ShowGuessLabel.Text = String.Format(" {0} <img src='Images/up16.png' /> För högt!", choice);
				}
				else if (answer == Outcome.Low)
				{
					ShowGuessLabel.Text = String.Format(" {0} <img src='Images/down16.png' /> För lågt!", choice);
				}
				else if (answer == Outcome.Correct)
				{
					ShowResultLabel.Text = String.Format(" <img src='Images/check1.png' /> Grattis! Du klarade det på {0} försök", SecretNumber.Count);
					GuessTextBox.Enabled = false;
					SendButton.Enabled = false;
					PlaceHolder2.Visible = true;
					PlaceHolder3.Visible = true;
				}
				else if (answer == Outcome.PreviousGuess)
				{
					ShowGuessLabel.Text = String.Format(" {0} <img src='Images/alert16.png' /> Du har redan gissat på talet", choice);
				}
				else if (answer == Outcome.NoMoreGuesses)
				{
					ShowResultLabel.Text = String.Format(" <img src='Images/close16.png' /> Du har inga gissningar kvar. Det hemliga talet var {0}", SecretNumber.Number);
					GuessTextBox.Enabled = false;
					SendButton.Enabled = false;
					PlaceHolder2.Visible = true;
					PlaceHolder3.Visible = true;
				}
				PlaceHolder1.Visible = true;
			}
		}

		protected void NewSecretNoButton_Click(object sender, EventArgs e)
		{

		}
	}
}