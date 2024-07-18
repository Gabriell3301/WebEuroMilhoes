<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Generate_Key.aspx.cs" Inherits="WebWeb.Generate_Key"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="Images/Logo.png" rel="icon" type="image/png" />
    <title>Generate Key</title>
    <link href="CSSGenerate_Key.css" rel="stylesheet" />
</head>
<body>
    <header id="Text_Top">Generate Keys</header>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label ID="Label_Error1" Text="" runat="server" Visible="false"/>
            <asp:Label ID="Label_Key" Text="Your Key Where" runat="server" CssClass="label" Visible="false"/>

            <asp:Button Text="Generate Random Key" runat="server" CssClass="button" OnClick="GenereateKey"/>
            <asp:Button Text="Save Key" runat="server" CssClass="button" OnClick="SaveKeys"/>                
        </div>
    </form>
</body>
</html>
