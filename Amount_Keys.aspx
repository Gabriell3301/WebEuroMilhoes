<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Amount_Keys.aspx.cs" Inherits="WebWeb.Amount_Keys"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
                <asp:TextBox ID="NumberOfKeys" runat="server" TextMode="Number" CssClass="input"/>
            </div>
            <div class="pair">
                <asp:Button ID="Generate_Keys" runat="server" Text="Generate Keys" OnClick="GenerateKeys" CssClass="button"/>
                <asp:Button ID="Save" Text="Save Keys" runat="server" OnClick="SaveKeys" CssClass="button"/>
            </div>
            <div class="keys-container">
                <asp:PlaceHolder ID="placeHolderKeys" runat="server"></asp:PlaceHolder>
            </div>
            <asp:Label ID="Label_Error" runat="server" Text="" Visible="false" CssClass="Label_Error" />
        </div>
    </div>
    </form>
</body>
</html>
