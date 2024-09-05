<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Generate_Key.aspx.cs" Inherits="WebWeb.Generate_Key"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="Images/Logo.png" rel="icon" type="image/png" />
    <title>Generate Key</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>
        <link href="CSSHome.css" rel="stylesheet" />
        <link href="CSSGenerate_Key.css" rel="stylesheet" />
</head>
<body>
    <header class="header header-expand-lg header-custom-bg header-dark py-3">
        <div class="container d-flex justify-content-center">
            <div class="text-white text-center fs-1">
                <h6 class="fs-1"><a href="Main.aspx">Euro Milhão</a></h6>
            </div>
        </div>
    </header>
    <form id="form1" runat="server">
        <div class="d-flex justify-content-center vh-100">
            <div class="align-self-center">
                <div class="box-container">
                    <h2 class="box-title text-center">Generate Key</h2>
                    <div class="box-content">
                        <div class="d-flex justify-content-center">
                            <asp:Label ID="Label_Error1" Text="" runat="server" Visible="false"/>
                        </div>

                        <div class="d-flex justify-content-center">
                            <asp:Label ID="Label_Key" Text="Your Key Where" runat="server" CssClass="label" Visible="false"/>
                        </div>

                        <div class="d-flex justify-content-center">
                            <asp:Button Text="Generate Random Key" runat="server" CssClass="button" OnClick="GenereateKey"/>
                        </div>

                        <div class="d-flex justify-content-center">
                            <asp:Button Text="Save Key" runat="server" CssClass="button" OnClick="SaveKeys"/>
                        </div>
                    </div>
                </div>
            </div>              
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
