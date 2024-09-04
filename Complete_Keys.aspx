﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Complete_Keys.aspx.cs" Inherits="WebWeb.Complete_Keys"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Images/Logo.png" rel="icon" type="image/png" />
    <title>Complete Keys</title>
    <link href="CSSComplete_Key.css" rel="stylesheet" />
</head>
<body>
    <form ID="form1" runat="server">
        <div class="container">
            <h2>Generate Key</h2>
            <label ID="txtNumber1" runat="server" CssClass="input-field" placeholder="Number 1"></label>
            <label ID="txtNumber2" runat="server" CssClass="input-field" placeholder="Number 2"></label>
            <label ID="txtNumber3" runat="server" CssClass="input-field" placeholder="Number 3"></label>
            <label ID="txtNumber4" runat="server" CssClass="input-field" placeholder="Number 4"></label>
            <label ID="txtNumber5" runat="server" CssClass="input-field" placeholder="Number 5"></label>
            <asp:Button ID="btnGenerate" runat="server" CssClass="button" Text="Generate Key" OnClick="GenerateKey"/>
            <asp:Label ID="Label" Text="" runat="server" />
            <div ID="result" runat="server" class="result" Visible="false"></div>
        </div>
    </form>
</body>
</html>
