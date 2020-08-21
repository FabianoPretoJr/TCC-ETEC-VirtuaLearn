<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCarrinho.aspx.cs" Inherits="VirtuaLearn.UI.EXTERNO.AddCarrinho" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
   <link href="MDB-Free/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="../css/style.css" />
    <link href="../css/FaleConosco.css" rel="stylesheet" />
    <link rel="shortcut icon" href="../img/cubo.png" type="../image/x-png" />
    <link href="../css/icons.css" rel="stylesheet" />
    <link href="../css/AddCart.css" rel="stylesheet" />
    <script src="../js/CarinhoList.js"></script>
    <title>Virtua Learn</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <!--CABEÇALHO-->
                <header>
                    <!--MENU-->
                    <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
                        <asp:ImageButton ID="btnIndex" class="navbar-brand" runat="server" Height="50px" ImageUrl="../img/LogoExterno.png" OnClick="btnIndex_Click" Width="165px" />
                        <div class="collapse navbar-collapse" id="navbarCollapse">
                            <ul class="navbar-nav mr-auto">
                                <li class="nav-item active">
                                    <asp:LinkButton ID="btnIndex1" class="nav-link" runat="server" OnClick="btnIndex1_Click">Home</asp:LinkButton>
                                </li>
                                <li class="nav-item active">
                                    <asp:LinkButton ID="btnCursos" class="nav-link" runat="server" OnClick="btnCursos_Click">Cursos</asp:LinkButton>
                                </li>

                                <li class="nav-item active">
                                    <asp:LinkButton ID="btnContato" class="nav-link" runat="server" OnClick="btnContato_Click">Contato</asp:LinkButton>
                                </li>

                            </ul>
                            <div class="form-inline mt-2 mt-md-0">
                                <asp:Button ID="btnLogin" class="btn btn-outline-light my-2 my-sm-0" runat="server" Text="Login" OnClick="btnLogin_Click" />
                            </div>
                        </div>
                    </nav>
                </header>


            <div class="card-product">    
    <div class="share">
        <h3><span class="fa fa-twitter"></span></h3>
        <h3><span class="fa fa-facebook"></span></h3>
        <h3><span class="fa fa-google-plus"></span></h3>
        <h3><span class="fa fa-send"></span></h3>
    </div>  
    <div class="img-product">            
        <div class="slideshow-container">
            <div class="slides fade">
                <div class="number-text">1 / 4</div>
                 <img src="../cart_img/direito.jpg" style="width:100%"/>
            </div>
            <div class="slides fade">
                <div class="number-text">2 / 4</div>
                <img src="../cart_img/bolsa.jpg" style="width:100%"/>
            </div>
            <div class="slides fade">
                <div class="number-text">3 / 4</div>
                 <img src="../cart_img/trovadorismo.jpg" style="width:100%"/>
            </div>
            <div class="slides fade">
                    <div class="number-text">4 / 4</div>
                  <img src="../cart_img/negociacoes.jpg" style="width:100%"/>
            </div>                            
        </div>
        <br /> 
        <div class="container-dots">
            <span class="dot" onclick="currentSlide(1)"></span> 
            <span class="dot" onclick="currentSlide(2)"></span> 
            <span class="dot" onclick="currentSlide(3)"></span> 
            <span class="dot" onclick="currentSlide(4)"></span> 
        </div>
    </div>      
    <div class="data-product">
        <h2>KALITA WAVE #185 STAINLESS STEEL DRIPPER</h2>
        <span class="fa fa-star checked"></span>
        <span class="fa fa-star checked"></span>
        <span class="fa fa-star checked"></span>
        <span class="fa fa-star"></span>
        <span class="fa fa-star"></span>
        <h3>$27.91 USD</h3>
        <div class="tab">
            <button class="tablinks" onclick="openData(event, 'description')" id="defaultOpen">DESCRIPTION</button>
            <button class="tablinks" onclick="openData(event, 'details')">DETAILS</button>
            <button class="tablinks" onclick="openData(event, 'features')">FEATURES</button>
        </div>
        <div id="description" class="tabcontent">
            <p>Kalita Wave drippers feature a flat-bottomed brew bed for even extraction, and a filter design that reduces contact between the brewing space.</p>
            <p>Used by top specialty cafes around the world and in professional coffee-making competitions, the Kalita Wave allows you to brew your favorite coffee more evenly, which directly contributes to fuller flavor and a more balanced extraction.
                </p>
        </div>

        <div id="details" class="tabcontent">
        <p>Material: Stainless <br />
                Dishwasher safe <br />
                Size: #155: Height 5.7x Diameter 10.5cm #185: Height 6.6×Width 11.5×Depth 13.8cm<br />
                Weight: #155: 82 g (Postage weight 200g) #185:160g Postage weight 400g) <br />
                Made in Japan.</p> 
        </div>
        <div id="features" class="tabcontent">
            <p>#155 brews 1-2 cups of beautifully smooth filtered coffee <br />
                #185 brews up to 4 cups <br />
                Use Kalita wave filters sold seperatly.</p>
        </div>
        <br />
        <div class="cart">
            Qty: &nbsp;
            <input type="number" placeholder="1" maxlength="3">&nbsp; &nbsp; &nbsp;
            <button class="btn-add-cart"><span class="fa fa-shopping-cart"></span>&nbsp; Add to Cart </button>
        </div>
    </div>  
</div>


        </div>
    </form>
</body>
    <script defer src="https://use.fontawesome.com/releases/v5.0.7/js/all.js"></script>
<script src="JS/search.js"></script>
<!-- Optional JavaScript -->
<!-- jQuery first, then Popper.js, then Bootstrap JS -->
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

</html>
