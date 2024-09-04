<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create_Keys.aspx.cs" Inherits="WebWeb.Create_Keys"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Images/Logo.png" rel="icon" type="image/png" />
    <title>Create keys</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet"/>
    <link href="CSSHome.css" rel="stylesheet" />
    <link href="CSSCreate_Keys.css" rel="stylesheet" />
</head>
<body>
    <!-- Header -->
    <navbar class="navbar navbar-expand-lg bg-dark navbar-dark py-3">
        <div class="container d-flex justify-content-center">
            <div class="text-white text-center">
                <h6 class="fs-1">Create Key</h6>
            </div>
        </div>
    </navbar>
    
    <form id="form1" runat="server">
      <div class="container d-flex justify-content-center">
        <div class="">
            <div class="form-group pair">
                <label for="Estrela1" class="col-form-label">Estrela 1:</label>
                <asp:TextBox type="number" runat="server" id="Estrela1" class="form-control input" max="2"/>
            </div>
            <div class="form-group pair">
                <label for="Estrela2" class="col-form-label">Estrela 2:</label>
                <asp:TextBox type="number" runat="server" id="Estrela2" class="form-control input" max="2"/>
            </div>
            <div class="form-group pair">
                <label for="Numero1" class="col-form-label">Numero 1:</label>
                <asp:TextBox type="number" runat="server" id="Numero1" class="form-control input" max="2"/>
            </div>
            <div class="form-group pair">
                <label for="Numero2" class="col-form-label">Numero 2:</label>
                <asp:TextBox type="number" runat="server" id="Numero2" class="form-control input" max="2"/>
            </div>
            <div class="form-group pair">
                <label for="Numero3" class="col-form-label">Numero 3:</label>
                <asp:TextBox type="number" runat="server" id="Numero3" class="form-control input" max="2"/>
            </div>
            <div class="form-group pair">
                <label for="Numero4" class="col-form-label">Numero 4:</label>
                <asp:TextBox type="number" runat="server" id="Numero4" class="form-control input" max="2"/>
            </div>
            <div class="form-group pair">
                <label for="Numero5" class="col-form-label">Numero 5:</label>
                <asp:TextBox type="number" runat="server" id="Numero5" class="form-control input" max="2" />
            </div>
            <asp:label id="Label_Error1" runat="server" class="Label_Error"></asp:label>
            <asp:label id="Label_Error2" runat="server" class="Label_Error"></asp:label>

            <div id="result" runat="server" class="result" style="display: none;"></div>
            <button id="btnEnviar" class="btn button">Create</button>
        </div>
    </div>

    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.3/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</form>
</body>
</html>
