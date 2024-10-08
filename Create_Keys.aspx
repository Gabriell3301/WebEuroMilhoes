﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create_Keys.aspx.cs" Inherits="WebWeb.Create_Keys"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Images/Logo.png" rel="icon" type="image/png" />
    <title>Create keys</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>
    <link href="CSSCreate_Keys.css" rel="stylesheet" />
</head>
<body>
    <!-- Header -->
    <header class="header header-expand-lg header-custom-bg header-dark py-3">
        <div class="container d-flex justify-content-center">
            <div class="text-white text-center fs-1">
                <h6 class="fs-1"><a href="Main.aspx">Euro Milhão</a></h6>
            </div>
        </div>
    </header>
    
    <form id="form1" runat="server">
      <div class="container d-flex justify-content-center">
            <div class="col-md-6 card p-4 shadow-lg">
                <h4 class="text-center mb-4">Create Your Keys</h4>
                <div class="row">
                    <div class="form-group col-6">
                        <label for="Estrela1" class="col-form-label">Estrela 1:</label>
                        <asp:TextBox type="number" runat="server" id="Estrela1" class="form-control" max="12" min="1"/>
                    </div>
                    <div class="form-group col-6">
                        <label for="Estrela2" class="col-form-label">Estrela 2:</label>
                        <asp:TextBox type="number" runat="server" id="Estrela2" class="form-control" max="12" min="1"/>
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="form-group col-6">
                        <label for="Numero1" class="col-form-label">Número 1:</label>
                        <asp:TextBox type="number" runat="server" id="Numero1" class="form-control" max="50" min="1"/>
                    </div>
                    <div class="form-group col-6">
                        <label for="Numero2" class="col-form-label">Número 2:</label>
                        <asp:TextBox type="number" runat="server" id="Numero2" class="form-control" max="50" min="1"/>
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="form-group col-6">
                        <label for="Numero3" class="col-form-label">Número 3:</label>
                        <asp:TextBox type="number" runat="server" id="Numero3" class="form-control" max="50" min="1"/>
                    </div>
                    <div class="form-group col-6">
                        <label for="Numero4" class="col-form-label">Número 4:</label>
                        <asp:TextBox type="number" runat="server" id="Numero4" class="form-control" max="50" min="1"/>
                    </div>
                </div>

                <div class="row mt-3">
                    <div class="form-group col-12">
                        <label for="Numero5" class="col-form-label">Número 5:</label>
                        <asp:TextBox type="number" runat="server" id="Numero5" class="form-control" max="50" min="1"/>
                    </div>
                </div>

                <div id="result" runat="server" class="result mt-4" style="display: none;"></div>

                <div class="d-flex justify-content-center mt-4">
                    <asp:Button id="btnEnviar" runat="server" Text="Create" class="btn btn-primary btn-lg" onclick="SendKeyUser" />
                </div>

                <div class="mt-3 text-center">
                    <asp:Label id="Label_Error1" runat="server" class="alert alert-danger" style="display:none;"></asp:Label>
                    <asp:Label id="Label_Error2" runat="server" class="alert alert-danger" style="display:none;"></asp:Label>
                </div>
            </div>
        </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</form>
</body>
</html>
