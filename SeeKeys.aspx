<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeeKeys.aspx.cs" Inherits="WebWeb.SeeKeys"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Images/Logo.png" rel="icon" type="image/png" />
    <title>See Keys</title>
    <link href="CSSSee_Keys.css" rel="stylesheet" />
</head>
<body>
    <header ID="Text_Top">See Keys</header>
    <form ID="form1" runat="server">
    <div class="container">
        <asp:Label ID="Label_Error" Text="" runat="server" CssClass="Label_Error"/>
        <div class="placeholder">
            <div class="keys-container">
                <asp:PlaceHolder ID="placeHolderKeys" runat="server"></asp:PlaceHolder>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
