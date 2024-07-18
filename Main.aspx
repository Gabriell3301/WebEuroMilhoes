<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebWeb.Main"%>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="Images/Logo.png" rel="icon" type="image/png" />
    <link href="PageStyle.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;700&display=swap" rel="stylesheet"/>
    <link href="CSSHome.css" rel="stylesheet" />
    <link href="CSSFormation.css" rel="stylesheet" />
    <title>Web EuroMilhoes</title> 
</head>
<body>
    <header id="Text_Home_Top" runat="server">Euro Milhão</header>
     <form id="form1" runat="server">
        <div class="container">
		    <asp:button text="Create Keys" class="button top-left" runat="server" OnClick="Unnamed1_Click"/>
		    <asp:button text="Generate Keys" class="button top-right " runat="server" OnClick="Unnamed2_Click"/>
		    <asp:button text="Complete Key" class="button bottom-left " runat="server" OnClick="Unnamed3_Click"/>
		    <asp:button text="Amount Keys" class="button bottom-right " runat="server" OnClick="Unnamed4_Click"/>
		    <asp:button text="See Keys" class="button center " runat="server" OnClick="Unnamed5_Click"/>
	</div>
    </form>
</body>
</html>
