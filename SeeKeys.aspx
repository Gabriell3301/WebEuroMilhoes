<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeeKeys.aspx.cs" Inherits="WebWeb.SeeKeys"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Images/Logo.png" rel="icon" type="image/png" />
    <title>See Keys</title>    
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>
    <link href="CSSSee_Keys.css" rel="stylesheet" />
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


<form id="form1" runat="server">
    <!-- Search Section -->
    <div class="search-container d-flex justify-content-center align-items-center mb-4">
        <!-- Search Box with Magnifying Glass Icon -->
        <div class="input-group w-50">
            <asp:Textbox id="BuscarKey" runat="server" Class="form-control" placeholder="Search by Number Key" />
            <div class="input-group-append">
                <asp:button runat="server" class="btn btn-outline-secondary" type="button" onclick="BtnSearch_click">
                </asp:button>
                
            </div>
        </div>

        <!-- Sort by Date Dropdown with Arrow Icons -->
        <div class="dropdown">
            <button class="btn btn-secondary dropdown-toggle" type="button" id="dropdownSort" data-bs-toggle="dropdown" aria-expanded="false">
                Sort by Date <i class="fas fa-sort"></i> <!-- Font Awesome Sort Icon -->
            </button>
            <ul class="dropdown-menu" aria-labelledby="dropdownSort">
                <li><a class="dropdown-item" href="#" onclick="sortByDate('asc')">Oldest to Newest <i class="fas fa-arrow-up"></i></a></li>
                <li><a class="dropdown-item" href="#" onclick="sortByDate('desc')">Newest to Oldest <i class="fas fa-arrow-down"></i></a></li>
            </ul>
        </div>
    </div>
    <div class="container">   
        <!-- Error Label -->
        <asp:Label ID="Label_Error" Text="" runat="server" CssClass="alert alert-danger" />

        <!-- Placeholder for Keys -->
        <div class="placeholder">
            <div class="keys-container">
                <asp:PlaceHolder ID="placeHolderKeys" runat="server"></asp:PlaceHolder>
            </div>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</form>
</body>
</html>
