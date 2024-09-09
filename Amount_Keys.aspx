<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Amount_Keys.aspx.cs" Inherits="WebWeb.Amount_Keys"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Images/Logo.png" rel="icon" type="image/png" />
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>
    <title>Generate Amount Keys</title>
    <link href="CSSAmount_Keys.css" rel="stylesheet" />
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
        <div class="container">
            <div class="placeholder">
                <div class="pair">
                    <label for="NumberOfKeys" class="label fw-bold">Number of Keys:</label>
                    <asp:Textbox id="NumberOfKeys" runat="server" TextMode="Number" Class="input form-control"/>
                </div>
                <div class="pair">
                    <asp:Button id="Generate_Keys" runat="server" Text="Generate Keys" OnClick="GenerateKeys" Class="button btn"/>
                    <asp:Button id="Save" Text="Save Keys" runat="server" OnClick="SaveKeys" Class="button btn"/>
                </div>
                <div class="keys-container">
                    <asp:PlaceHolder id="placeHolderKeys" runat="server"></asp:PlaceHolder>
                </div>
                <asp:Label id="Label_Error" runat="server" Text="" Visible="false" Class="Label_Error" />
            </div>
        </div>
    </form>


    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
