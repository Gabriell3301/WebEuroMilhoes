<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Amount_Keys.aspx.cs" Inherits="WebWeb.Amount_Keys"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Images/Logo.png" rel="icon" type="image/png" />
    <title>Generate Amount Keys</title>
    <link href="CSSAmount_Keys.css" rel="stylesheet" />
</head>
<body>
    <header id="Text_Top">Amount Keys</header>
    <form id="form1" runat="server">
        <div class="container">
        <div class="placeholder">
            <div class="pair">
                <label for="NumberOfKeys">Number of Keys:</label>
                <asp:Textbox id="NumberOfKeys" runat="server" TextMode="Number" CssClass="input"/>
            </div>
            <div class="pair">
                <asp:Button id="Generate_Keys" runat="server" Text="Generate Keys" OnClick="GenerateKeys" CssClass="button"/>
                <asp:Button id="Save" Text="Save Keys" runat="server" OnClick="SaveKeys" CssClass="button"/>
            </div>
            <div class="keys-container">
                <asp:PlaceHolder id="placeHolderKeys" runat="server"></asp:PlaceHolder>
            </div>
            <asp:Label id="Label_Error" runat="server" Text="" Visible="false" CssClass="Label_Error" />
        </div>
    </div>
    </form>
</body>
</html>
