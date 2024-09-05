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
    <nav class="navbar navbar-expand-none bg-custom navbar-dark py-3">
        <div class="container d-flex justify-content-between align-items-center">
            <div class="text-white mx-auto">
                <h6 class="fs-1 text-center">Euro Milhão</h6>
            </div>
            <button class="navbar-toggler" type="button"
                    data-bs-toggle="collapse"
                    data-bs-target="#navmenu"
                    aria-expanded="true">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div id="navmenu" class="collapse navbar-collapse">
                <ul class="navbar-nav ms-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="Create_Keys.aspx">See Keys</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Generate_Key.aspx">See Keys</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Complete_Keys.aspx">See Keys</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Amount_Keys.aspx">See Keys</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="SeeKeys.aspx">See Keys</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <!-- Buttons -->
     <form id="form1" runat="server">
         <div class="d-flex justify-content-center aling-items-center vh-100">
             <section class="bg-white text-light py-4">
               <div class="btns-container">
                   <div class="btns">
                       
                   </div>
               </div>
            </section>
         </div>
    </form>


    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
  </body>
</html>
