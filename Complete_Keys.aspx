<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Complete_Keys.aspx.cs" Inherits="WebWeb.Complete_Keys"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Images/Logo.png" rel="icon" type="image/png" />
    <title>Complete Keys</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>
    <link href="CSSComplete_Key.css" rel="stylesheet" />
</head>
<body>
    <!-- Header -->
    <header class="header header-expand-lg header-custom-bg header-dark py-3">
        <div class="header-container d-flex justify-content-center">
            <div class="text-white text-center fs-1">
                <h6 class="fs-1"><a href="Main.aspx">Euro Milhão</a></h6>
            </div>
        </div>
    </header>
    <!-- Body -->
    <form id="form1" runat="server">
        <div class="container mt-5 p-4 border rounded bg-light">
            <h2 class="text-center mb-4">Generate Key</h2>
            <div class="d-flex mb-3 justify-content-center">
                <asp:Textbox id="txtNumber1" runat="server" Class="input-field" placeholder="Number 1"/>
            </div>
            <div class="d-flex mb-3 justify-content-center">
                <asp:Textbox id="txtNumber2" runat="server" Class="input-field" placeholder="Number 2"/>
            </div>
            <div class="d-flex mb-3 justify-content-center">
                <asp:Textbox id="txtNumber3" runat="server" Class="input-field" placeholder="Number 3"/>
            </div>
            <div class="d-flex mb-3 justify-content-center">
                <asp:Textbox id="txtNumber4" runat="server" Class="input-field" placeholder="Number 4"/>
            </div>
            <div class="d-flex mb-3 justify-content-center">
                <asp:Textbox id="txtNumber5" runat="server" Class="input-field" placeholder="Number 5"/>
            </div>
            <div class="d-flex mb-3 justify-content-center">
                <asp:Button id="btnGenerate" runat="server" Class="btn btn-primary btn-block" Text="Generate Key" OnClick="GenerateKey"/>
            </div>
            <div class="d-flex mb-3 justify-content-center">
                <asp:Label id="Label" Text="" runat="server" Class="mt-3 d-block"/>
            </div>
            <div id="result" runat="server" class="result mt-3" Visible="false"></div>
        </div>
    </form>


    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
