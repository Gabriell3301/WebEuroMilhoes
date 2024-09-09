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
    <!-- Navbar -->
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
                <ul class="navbar-nav ms-auto text-white">
                    <li class="nav-item">
                        <a class="nav-link" href="Create_Keys.aspx">Create Keys</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Generate_Key.aspx">Generate Keys</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Complete_Keys.aspx">Complete Keys</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Amount_Keys.aspx">Amount Keys</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="SeeKeys.aspx">See Keys</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <form id="form1" runat="server">

        <!-- Statistics -->
        <section class="p-5">
            <div class="container">
                <div class="row text-center g-4">
                    <!-- Card 1 -->
                    <div class="col-md">
                        <div class="card bg-dark text-light">
                            <div class="card-body text-center">
                                <h3 class="card-title mb-3">Top 5 Numbers</h3>
                                <ul class="fw-bold">
                                    <li>
                                        <asp:Label id="Top1" Text="text" runat="server" /> <!-- Top 1 -->
                                    </li>                                                  
                                    <li>                                                   
                                        <asp:Label id="Top2" Text="text" runat="server" /> <!-- Top 2 -->
                                    </li>                                                  
                                    <li>                                                   
                                        <asp:Label id="Top3" Text="text" runat="server" /> <!-- Top 3 -->
                                    </li>                                                  
                                    <li>                                                   
                                        <asp:Label id="Top4" Text="text" runat="server" /> <!-- Top 4 -->
                                    </li>                                                  
                                    <li>                                                   
                                        <asp:Label id="Top5" Text="text" runat="server" /> <!-- Top 5 -->
                                    </li>                                
                                </ul>
                            </div>
                        </div>

                    </div>
                
                    <!-- Card 2 -->
                    <div class="col-md">
                        <div class="card bg-secondary text-light">
                            <div class="card-body text-center">
                                <h3 class="card-title mb-3">Last Key</h3>
                                <div class="card-text fw-bold">
                                    <asp:Label id="LastKey" runat="server" />
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- Card 3 -->
                    <div class="col-md">
                        <div class="card bg-dark text-light">
                            <div class="card-body text-center">
                                <h3 class="card-title mb3">Delete Key</h3>
                                <asp:TextBox runat="server" type="text" id="KeyToDelete" class="form-control" placeholder="Number Key" />
                                <asp:Label ID="KeyDeleted" runat="server" />
                                <br />
                                <asp:button runat="server" Text="Delete" class="btn bg-secondary btn-lg text-light" OnClick="Deleting_Key" style="margin:5px" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </form>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>