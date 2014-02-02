<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1dv6_1_4_gissa_det_hemliga_talet.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gissa det hemliga talet</title>
	<link href="~/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="MyForm" runat="server">
    <div id="maincontainer">
		<h1>
			<asp:Label ID="TitleLabel" runat="server" Text="Gissa det hemliga talet"></asp:Label>
		</h1>
		<%--Textinput för det hemliga talet--%>
		<asp:Label ID="GuessLabel" runat="server" Text="Ange ett tal mellan 1 och 100:"></asp:Label>
		<asp:TextBox ID="GuessTextBox" runat="server" Width="35"></asp:TextBox>
		<%-- Validering--%>
		<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
			ControlToValidate="GuessTextBox" ErrorMessage="Ett tal måste anges"
			Display="None"></asp:RequiredFieldValidator>
		<asp:RangeValidator ID="RangeValidator1" runat="server" 
			ControlToValidate="GuessTextBox" Type="Integer" 
			ErrorMessage="Ange ett tal mellan 1 och 100"
			MaximumValue="100" MinimumValue="1" Display="None"></asp:RangeValidator>
		<%-- Skickaknapp--%>
		<asp:Button ID="SendButton" runat="server" Text="Skicka gissning" OnClick="SendButton_Click" />
		
		<%-- Presentation av gissningar och resultat--%>
		<asp:PlaceHolder ID="PlaceHolder1" runat="server">
			<p>
				<asp:Label ID="ShowGuessLabel" runat="server" Text="Test1"></asp:Label>
			</p>
		</asp:PlaceHolder>
		<asp:PlaceHolder ID="PlaceHolder2" runat="server">
			<p>
				<asp:Label ID="ShowResultLabel" runat="server" Text="Test2"></asp:Label>
			</p>
		</asp:PlaceHolder>
		<asp:PlaceHolder ID="PlaceHolder3" runat="server">
			<p>
				<asp:Button ID="NewSecretNoButton" runat="server" Text="Slumpa nytt hemligt tal" OnClick="NewSecretNoButton_Click" />
			</p>
		</asp:PlaceHolder>
		
		<%-- Valideringsfelmeddelanden--%>
		<p>
			<asp:ValidationSummary ID="ValidationSummary1" runat="server"
				HeaderText="Ett fel inträffade! Korrigera felet och gör ett nytt försök." />
		</p>
    </div>
    </form>
</body>
</html>
