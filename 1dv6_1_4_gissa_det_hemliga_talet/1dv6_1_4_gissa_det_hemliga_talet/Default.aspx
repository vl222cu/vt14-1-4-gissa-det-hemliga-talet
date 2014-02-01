<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1dv6_1_4_gissa_det_hemliga_talet.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gissa det hemliga talet</title>
</head>
<body>
    <form id="MyForm" runat="server">
    <div id="maincontainer">
		<h1>
			<asp:Label ID="TitleLabel" runat="server" Text="Gissa det hemliga talet"></asp:Label>
		</h1>
		<asp:Label ID="GuessLabel" runat="server" Text="Ange ett tal mellan 1 och 100:"></asp:Label>
		<asp:TextBox ID="GuessTextBox" runat="server" Width="35"></asp:TextBox>
		<asp:Button ID="SendButton" runat="server" Text="Skicka gissning" />
    </div>
    </form>
</body>
</html>
