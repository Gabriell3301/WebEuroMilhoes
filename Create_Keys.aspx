<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create_Keys.aspx.cs" Inherits="WebWeb.Create_Keys"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Images/Logo.png" rel="icon" type="image/png" />
    <title>Create keys</title>
    <link href="CSSCreate_Keys.css" rel="stylesheet" />
</head>
<body>
    <header id="Text_Top" runat="server">Create Keys</header>
    <form id="form1" runat="server">
      <div class="container BoxNumber">
            <div class="content">
                <div class="pair">
                    <label class="labels">Estrela 1:</label>
                    <asp:TextBox ID="Estrela1" runat="server" TextMode="Number" MaxLength="2" CssClass="input" />
                </div>
                <div class="pair">
                    <label class="labels">Estrela 2:</label>
                    <asp:TextBox ID="Estrela2" runat="server" TextMode="Number" MaxLength="2" CssClass="input" />
                </div>
                <div class="pair">
                    <label class="labels">Numero 1:</label>
                    <asp:TextBox ID="Numero1" runat="server" TextMode="Number" MaxLength="2" CssClass="input" />
                </div>
                <div class="pair">
                    <label class="labels">Numero 2:</label>
                    <asp:TextBox ID="Numero2" runat="server" TextMode="Number" MaxLength="2" CssClass="input" />
                </div>
                <div class="pair">
                    <label class="labels">Numero 3:</label>
                    <asp:TextBox ID="Numero3" runat="server" TextMode="Number" MaxLength="2" CssClass="input" />
                </div>
                <div class="pair">
                    <label class="labels">Numero 4:</label>
                    <asp:TextBox ID="Numero4" runat="server" TextMode="Number" MaxLength="2" CssClass="input" />
                </div>
                <div class="pair">
                    <label class="labels">Numero 5:</label>
                    <asp:TextBox ID="Numero5" runat="server" TextMode="Number" MaxLength="2" CssClass="input" />
                </div>
            </div>
        </div>
        <div class="container">
            <asp:Label ID="Label_Error1" Text="" runat="server" CssClass="Label_Error" Visible="false"/>
            <asp:Label ID="Label_Error2" Text="" runat="server" CssClass="Label_Error" Visible="false"/>
            <div id="result" runat="server" class="result" Visible="false"></div>        
        </div>
        <div class="container">
            <asp:Button ID="btnEnviar" runat="server" Text="Create" OnClick="SendKeyUser" CssClass="button"/>
        </div>
</form>
</body>
</html>
