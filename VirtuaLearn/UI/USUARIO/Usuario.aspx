﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="VirtuaLearn.UI.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">

    <link href="CSS/nucleo-icons.css" rel="stylesheet" />
    <link href="bootstrap-4.3.1-dist/css/bootstrap.css" rel="stylesheet" />   
    <link rel="shortcut icon" href="../img/cubo.png" type="../image/x-png" />
    <link href="CSS/Style.css?Version=1" rel="stylesheet" />  
    <link href="CSS/paginacao.css" rel="stylesheet" />
    <link href="CSS/pesquisa.css" rel="stylesheet" />    
    <link href="https://use.fontawesome.com/releases/v5.0.6/css/all.css" rel="stylesheet" />
    <link href="CSS/cardCurso.css" rel="stylesheet" />
    <link href="CSS/breadcrumb.css" rel="stylesheet" />
    <link href="//netdna.bootstrapcdn.com/font-awesome/3.2.1/css/font-awesome.css" rel="stylesheet"/>
    <title>Virtua Learn</title>


    <style>
       
    </style>
</head>
<body >
    <form id="form1" runat="server">
      <div>
            
            <header>
                <div class="container">

                    <img src="../img/LogoP.png" alt="logo" class="foto" />
                    <lateral>
                        <ul>
                            <li><a href="#"></a>
                          <div class="input-group md-form form-sm form-2 pl-0">
  <input class="form-control my-0 py-1 lime-border" type="text" placeholder="" aria-label="Search">
  <div class="input-group-append">
    <span class="input-group-text lime lighten-2" id="basic-text1"><i class="fas fa-search text-grey"
        aria-hidden="true"></i></span>
  </div>
</div>
                                </li>

                           <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
         <i class="fas fa-cogs"></i>
        </a>
        <div class="dropdown-menu" aria-labelledby="navbarDropdown">
  
            <asp:Button ID="btnConta" class="dropdown-item" runat="server" Text="Minha conta"></asp:Button>
            <asp:Button ID="btnAjuda" class="dropdown-item" runat="server" Text="Ajuda"></asp:Button>
            <asp:Button ID="btnSair" class="dropdown-item" runat="server" Text="Sair"></asp:Button>
          
          
        </div>
      </li>


                        </ul>
                    </lateral>
                </div>
            </header>
            


            <!--div-- class="witteblok">
                <title></title>




                <div id="content">

                    <span class="slide">
                        <a href="#" onclick="openSlideMenu()">
                            <i class="fas fa-bars"></i>
                        </a>
                    </span>

                    <div id="menu" class="Lateral">
                        <a href="#" class="close" onclick="closeSlideMenu()">
                            <i class="fas fa-window-close"></i>
                        </a>
                        <div id="titulo">MENU</div>
                        <a href="Usuario.aspx" >Home</a>
                        <a href="Cursos.aspx">Cursos</a>

                        <a href="Quiz.aspx">Quizz</a>
                        <a href="Certificado.aspx">Certificado</a>

                        <a/>
       
    
  
  
  
                    </div>
                </div>
            </!--div-->
      

            <br />
           
            
           <UL class="breadc">
  
  <LI>
    <a href="Certificado.aspx">
      <span class="fas fa-graduation-cap"></span>
      <span class="text">Certi</span>
    </a>
  </LI>
  <LI>
    <a href="Quiz.aspx">
      <span class="fas fa-cube"></span>
      <span class="text">Quiz</span>
    </a>
  </LI>
  <LI>
    <a href="Cursos.aspx">
      <span class="icon icon-book"></span>
      <span class="text">Curso</span>
    </a>
  </LI>
  <LI>
    <a href="Usuario.aspx">
      <span class="icon icon-home"></span>
    </a>
  </LI>
</UL>

        

          <div class="container">
                <div class="cards">

                    <asp:Literal ID="litCurso" runat="server"></asp:Literal>






            </div>


         
          

        
        

            <br />
            <br />
            <br />
            <!--<ul class="pagination modal-3">
                <li><a href="#" class="prev">&laquo</a></li>
                <li><a href="#" class="active">1</a></li>
                <li><a href="#">2</a></li>
                <li><a href="#">3</a></li>
                <li><a href="#">4</a></li>
                <li><a href="#">5</a></li>
                <li><a href="#">6</a></li>
                <li><a href="#">7</a></li>
                <li><a href="#">8</a></li>
                <li><a href="#">9</a></li>
                <li><a href="#" class="next">&raquo;</a></li>
            </ul>-->
            <br />
        </div>
    </form>
</body>

<script src="JS/search.js"></script>
<!-- Optional JavaScript -->
<!-- jQuery first, then Popper.js, then Bootstrap JS -->
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
<script src="JS/cardcurso.js"></script>
<script>
    function openSlideMenu() {
        document.getElementById('menu').style.width = '250px';
        document.getElementById('content').style.marginLeft = '-11111250px';

    }

    function closeSlideMenu() {
        document.getElementById('menu').style.width = '0px';
        document.getElementById('content').style.marginLeft = '0px';
    }




</script>


</html>
