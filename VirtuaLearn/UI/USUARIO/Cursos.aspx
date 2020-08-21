<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="VirtuaLearn.UI.USUARIO.Cursos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <!--link href="CSS/Style.css" rel="stylesheet" /-->
    <link href="CSS/nucleo-icons.css" rel="stylesheet" />
    <link href="bootstrap-4.3.1-dist/css/bootstrap.css" rel="stylesheet" />
    <link href="CSS/cardTransform.css" rel="stylesheet" />
    <link rel="shortcut icon" href="../img/cubo.png" type="../image/x-png" />
    <link href="CSS/Style.css" rel="stylesheet" />
    <link href="CSS/Collapsee.css" rel="stylesheet" />

    <link href="CSS/paginacao.css" rel="stylesheet" />
    <link href="CSS/search.css" rel="stylesheet" />
    <link href="CSS/breadcrumb.css" rel="stylesheet" />
    <link href="//netdna.bootstrapcdn.com/font-awesome/3.2.1/css/font-awesome.css" rel="stylesheet" />

    <link href="https://use.fontawesome.com/releases/v5.0.6/css/all.css" rel="stylesheet" />


    <link href="shadowbox/shadowbox-3.0.3/shadowbox.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript" src="http://code.jquery.com/jquery-1.4.2.min.js"></script>
    <script type="text/javascript" src="shadowbox/shadowbox.js"></script>
    <script type="text/javascript">

        Shadowbox.init({
            language: 'pt',
            player: ['img', 'html', 'swf']
        });
    </script>


    <title>Virtua Learn</title>


</head>
<body>
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




            <!--div class="witteblok">
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
                        <a href="Usuario.aspx">Home</a>
                        <a href="Cursos.aspx">Cursos</a>

                        <a href="Quiz.aspx">Quizz</a>
                        <a href="Certificado.aspx">Certificado</a>

                        <a/>
       
    
  
  
  
                    </div>
                </div>
            </div-->

            <br />


            <ul class="breadc">

                <li>
                    <a href="Certificado.aspx">
                        <span class="fas fa-graduation-cap"></span>
                        <span class="text"></span>
                    </a>
                </li>
                <li>
                    <a href="Quiz.aspx">
                        <span class="fas fa-cube"></span>
                        <span class="text"></span>
                    </a>
                </li>
                <li>
                    <a href="Cursos.aspx">
                        <span class="icon icon-book"></span>
                        <span class="text"></span>
                    </a>
                </li>
                <li>
                    <a href="Usuario.aspx">
                        <span class="icon icon-home"></span>
                    </a>
                </li>
            </ul>

            <br />
            <br />

            <br />
            <div class="container">


                <!--=============LITERAL TA AQUI============-->


                <asp:Literal ID="litAula" runat="server"></asp:Literal>








                <!--<div class="row align-content-center">
                    <div class="col-md-2">
                    </div>
                    <div class="col-md-12">
                        <div class="card3">
                            <div id="main">

                                <h3>Curso<span class="badge badge-secondary"></span></h3>
                                <br />
                                <div class="accordion" id="faq">
                                    <div class="cartt">
                                        <div class="cartt-cab" id="faqhead1">
                                            <a href="#" class="btnn btnn-cab-linkedd" data-toggle="collapse" data-target="#faq1"
                                                aria-expanded="true" aria-controls="faq1">Material de Apoio</a>
                                        </div>

                                        <div id="faq1" class="collapse show" aria-labelledby="faqhead1" data-parent="#faq">
                                            <div class="cartt-body">
                                                <br />
                                                <br />
                                                <div class="cardTransf-container">
                                                    <div class="cardTransf">
                                                        <div class="front">
                                                            <span class="fa fa-book"></span>
                                                        </div>
                                                        <div class="back"><a href="#">Baixar</a></div>

                                                    </div>
                                                </div>
                                                <br />
                                                <br />

                                            </div>
                                        </div>
                                    </div>
                                    <div class="cartt">
                                        <div class="cartt-header" id="faqhead2">
                                            <a href="#" class="btnn btnn-cab-linkedd collapsed" data-toggle="collapse" data-target="#faq2"
                                                aria-expanded="true" aria-controls="faq2">Vídeo Aula</a>
                                        </div>

                                        <div id="faq2" class="collapse" aria-labelledby="faqhead2" data-parent="#faq">
                                            <div class="cartt-body">
                                                <br />
                                                <br />
                                                <div class="cardTransf-container">
                                                    <div class="cardTransf">
                                                        <div class="front">
                                                            <span class="fa fa-film"></span>
                                                        </div>
                                                        <div class="back"><a title="UpInside Tecnologia" href="https://www.youtube.com/embed/CvBfHwUxHIk?rel=0&amp;showinfo=0" rel="shadowbox; width=600; height=540;">assistir</a></div>

                                                    </div>
                                                </div>
                                                <br />
                                                <br />
                                            </div>
                                        </div>
                                    </div>

                                </div>

                            </div>
                        </div>
                    </div>
                    <div class="col-md-2">
                    </div>
                </div>
                <br />
                <br />
                <br />-->

                <!-- Segundo collapse-->

                <!--<div class="row">
                    <div class="col-md-2">
                    </div>
                    <div class="col-md-12">
                        <div class="card5">
                            <div id="bloco2">

                                <h3>Curso<span class="badge badge-secondary"></span></h3>
                                <br />
                                <div class="accordion" id="facc">
                                    <div class="kart">
                                        <div class="kart-capp" id="facchead1">
                                            <a href="#" class="butnn butnn-capp-link" data-toggle="collapse" data-target="#facc1"
                                                aria-expanded="true" aria-controls="facc1">Material de Apoio</a>
                                        </div>

                                        <div id="facc1" class="collapse shown" aria-labelledby="facchead1" data-parent="#facc">
                                            <div class="kart-body">
                                                <br />
                                                <br />
                                                <div class="cardTransf-container">
                                                    <div class="cardTransf">
                                                        <div class="front">
                                                            <span class="fa fa-book"></span>
                                                        </div>
                                                        <div class="back">Baixar <a href="#"></a></div>


                                                    </div>
                                                </div>
                                            </div>
                                            <br />
                                            <br />

                                        </div>
                                    </div>
                                </div>
                                <div class="kart">
                                    <div class="kart-header" id="facchead2">
                                        <a href="#" class="butnn butnn-capp-link collapsee" data-toggle="collapse" data-target="#facc2"
                                            aria-expanded="true" aria-controls="facc2">Vídeo Aula</a>
                                    </div>

                                    <div id="facc2" class="collapse" aria-labelledby="facchead2" data-parent="#facc">
                                        <div class="kart-body">
                                            <br />
                                            <br />
                                            <div class="cardTransf-container">
                                                <div class="cardTransf">
                                                    <div class="front">
                                                        <span class="fa fa-film"></span>
                                                    </div>
                                                    <div class="back"><a title="UpInside Tecnologia" href="https://www.youtube.com/embed/CvBfHwUxHIk?rel=0&amp;showinfo=0" rel="shadowbox; width=600; height=540;">assistir</a></div>

                                                </div>
                                            </div>
                                            <br />
                                            <br />
                                        </div>
                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>
                </div>-->




                <!--<div class="col-md-2">
                </div>
            </div>

            <br />
            <br />
            <br />-->
            <!-- terceiro collapse-->

            <!--<div class="row">
                <div class="col-md-2">
                </div>
                <div class="col-md-12">
                    <div class="card5">
                        <div id="bloco3">

                            <h3>Curso<span class="badge badge-secondary"></span></h3>
                            <br />
                            <div class="accordion" id="fitt">
                                <div class="coart">
                                    <div class="coart-cott" id="fitthead1">
                                        <a href="#" class="batnn batnn-cott-link" data-toggle="collapse" data-target="#fitt1"
                                            aria-expanded="true" aria-controls="fitt1">Material de Apoio</a>
                                    </div>

                                    <div id="fitt1" class="collapse showm" aria-labelledby="fitthead1" data-parent="#fitt">
                                        <div class="coart-body">
                                            <br />
                                            <br />
                                            <div class="cardTransf-container">
                                                <div class="cardTransf">
                                                    <div class="front">
                                                        <span class="fa fa-book"></span>
                                                    </div>
                                                    <div class="back"><a href="#">Baixar</a></div>
                                                </div>
                                            </div>
                                            <br />
                                            <br />

                                        </div>
                                    </div>
                                </div>
                                <div class="coart">
                                    <div class="coart-header" id="fitthead2">
                                        <a href="#" class="batnn batnn-cott-link collapsaad" data-toggle="collapse" data-target="#fitt2"
                                            aria-expanded="true" aria-controls="facc2">Vídeo Aula</a>
                                    </div>

                                    <div id="fitt2" class="collapse" aria-labelledby="fitthead2" data-parent="#fitt">
                                        <div class="coart-body">
                                            <br />
                                            <br />
                                            <div class="cardTransf-container">
                                                <div class="cardTransf">
                                                    <div class="front">
                                                        <span class="fa fa-film"></span>
                                                    </div>
                                                    <div class="back"><a title="UpInside Tecnologia" href="https://www.youtube.com/embed/CvBfHwUxHIk?rel=0&amp;showinfo=0" rel="shadowbox; width=600; height=540;">assistir</a></div>


                                                </div>
                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                    </div>
                                </div>
                            </div>

                        </div>

                    </div>
                </div>
            </div>-->
            <div class="col-md-2">
            </div>



            <br />





            <br />
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
