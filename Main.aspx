<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebWeb.Main"%>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="Images/Logo.png" rel="icon" type="image/png" />
    <link href="PageStyle.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;700&display=swap" rel="stylesheet"/>
    <link href="CSSHome.css" rel="stylesheet" />
    <link href="CSSMain.css" rel="stylesheet" />
    <title>Web EuroMilhoes</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>
</head>
<body>
    <!-- Header -->
    <navbar class="navbar navbar-expand-lg bg-dark navbar-dark py-3">
        <div class="container d-flex justify-content-center">
            <div class="text-white text-center">
                <h6 class="fs-1">Euro Milhão</h6>
            </div>
        </div>
    </navbar>
    <!-- Buttons -->
     <form id="form1" runat="server">
         <div class="d-flex justify-content-center aling-items-center vh-100">
             <section class="bg-white text-light py-4">
               <div class="btns-container">
                   <div class="btns">
                       <asp:button text="Create Keys" class="btn btn-primary btn-lg animatedButton" runat="server" OnClick="Unnamed1_Click"/>
                       <asp:button text="Generate Keys" class="btn btn-primary btn-lg animatedButton" runat="server" OnClick="Unnamed2_Click"/>
                       <asp:button text="Complete Key" class="btn btn-primary btn-lg animatedButton" runat="server" OnClick="Unnamed3_Click"/>
                       <asp:button text="Amount Keys" class="btn btn-primary btn-lg animatedButton" runat="server" OnClick="Unnamed4_Click"/>
                       <asp:button text="See Keys" class="btn btn-primary btn-lg animatedButton" runat="server" OnClick="Unnamed5_Click"/>
                   </div>
               </div>
            </section>
         </div>
    </form>


    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
  </body>
</html>
