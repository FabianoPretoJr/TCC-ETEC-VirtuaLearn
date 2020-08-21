<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PagAdmComum.aspx.cs" Inherits="VirtuaLearn.UI.PROFESSOR.PagAdmComum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>

  <link rel="apple-touch-icon" sizes="76x76" href="../assets/img/apple-icon.png"/>
  <link rel="icon" type="../image/png" href="../assets/img/favicon.png"/>
     <!--     Fonts and icons     -->
  <link href="https://fonts.googleapis.com/css?family=Poppins:200,300,400,600,700,800" rel="stylesheet" />
  <link href="https://use.fontawesome.com/releases/v5.0.6/css/all.css" rel="stylesheet"/>
  <!-- Nucleo Icons -->
  <link href="../PagAdm/black-dashboard-master/assets/css/nucleo-icons.css" rel="stylesheet" />

  <!-- CSS Files -->
     
    <link href="../PagAdm/black-dashboard-master/assets/css/black-dashboard.css" rel="stylesheet" />
  <!-- CSS Just for demo purpose, don't include it in your project -->
  <link href="../PagAdm/black-dashboard-master/assets/demo/demo.css" rel="stylesheet" />
     <link rel="shortcut icon" href="../img/cubo.png" type="../image/x-png" />
    <title>Administrador</title>

     <style type="text/css">
        <!--

        html {
            overflow-y: hidden;
        }

        -->
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="wrapper">
    <div class="sidebar">
      <!--
        Tip 1: You can change the color of the sidebar using: data-color="blue | green | orange | red"
    -->
      <div class="sidebar-wrapper">
        <div class="logo">
           
          <a href="javascript:void(0)" class="simple-text logo-mini" >
            
          </a>
          <a href="javascript:void(0)" class="simple-text logo-normal">
            M E N U
          </a>
        </div>
                        <ul class="nav">
                            <li class="active">
                                <a href="PagAdmComum.aspx">

                                    <i class="tim-icons icon-app"></i>
                                    <p>Dashboard</p>
                                </a>
                            </li>
                            <li>
                                <a href="CursoAdmC.aspx">
                                    <i class="tim-icons icon-book-bookmark"></i>
                                    <p>Cursos</p>
                                </a>
                            </li>
                            <li>
                                <a href="ConteudosAdmC.aspx">
                                    <i class="tim-icons icon-paper"></i>
                                    <p>Conteudos</p>
                                </a>
                            </li>
                            <li>
                                <a href="QuizzAdmC.aspx">
                                    <i class="tim-icons icon-puzzle-10"></i>
                                    <p>Quizz</p>
                                </a>
                            </li>
                             <li>
                                <a href="CertificadoAdmc.aspx">
                                    <i class="tim-icons icon-notes"></i>
                                    <p>Certificado</p>
                                </a>
                            </li>
                            <li>
                                <a href="PerfilAdmC.aspx">
                                    <i class="tim-icons icon-single-02"></i>
                                    <p>Perfil</p>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
    <div class="main-panel">

      <!-- Navbar -->
      <nav class="navbar navbar-expand-lg navbar-absolute navbar-transparent">
        <div class="container-fluid">
          <div class="navbar-wrapper">
            <div class="navbar-toggle d-inline">
              <button type="button" class="navbar-toggler">
                <span class="navbar-toggler-bar bar1"></span>
                <span class="navbar-toggler-bar bar2"></span>
                <span class="navbar-toggler-bar bar3"></span>
              </button>
            </div>
            <asp:ImageButton ID="btnIndex" class="navbar-brand" runat="server" Height="60px" ImageUrl="../img/1logo.png" OnClick="btnIndex_Click" Width="190px"/>
          </div>
          <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navigation" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-bar navbar-kebab"></span>
            <span class="navbar-toggler-bar navbar-kebab"></span>
            <span class="navbar-toggler-bar navbar-kebab"></span>
          </button>
          <div class="collapse navbar-collapse" id="navigation">
            <ul class="navbar-nav ml-auto">
                                        <asp:Button ID="btnSair" class="btn btn-fill btn-primary" runat="server" Text="Sair" OnClick="btnSair_Click" /> <!--SAIR DA SESSÃO-->
            </ul>
          </div>
        </div>
      </nav>
      <div class="modal modal-search fade" id="searchModal" tabindex="-1" role="dialog" aria-labelledby="searchModal" aria-hidden="true">
        <div class="modal-dialog" role="document">
          <div class="modal-content">
            <div class="modal-header">
              <input type="text" class="form-control" id="inlineFormInputGroup" placeholder="SEARCH"/>
              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                <i class="tim-icons icon-simple-remove"></i>
              </button>
            </div>
          </div>
        </div>
      </div>
      <!-- End Navbar -->

        <!--footer-->
          <footer class="footer">
        <div class="container-fluid">
          <ul class="nav">
            <li class="nav-item">
              <a href="javascript:void(0)" class="nav-link">
       
              </a>
            </li>
            <li class="nav-item">
              <a href="javascript:void(0)" class="nav-link">
          
              </a>
            </li>
            <li class="nav-item">
              <a href="javascript:void(0)" class="nav-link">
          
              </a>
            </li>
          </ul>
          <div class="copyright">
            ©
            <script>
              document.write(new Date().getFullYear())
            </script>  <i class=""></i> -
            <a href="javascript:void(0)" target="_blank">Virtua Learn</a>
          </div>
        </div>
      </footer>
    </div>
  </div>

        <!-- -end footer-->
        </div>
    </form>
</body>
    <script src="../PagAdm/black-dashboard-master/assets/js/core/bootstrap.min.js"></script>
<script src="../PagAdm/black-dashboard-master/assets/js/core/jquery.min.js"></script>
<script src="../PagAdm/black-dashboard-master/assets/js/core/popper.min.js"></script>
  <script src="../PagAdm/black-dashboard-master/assets/js/plugins/perfect-scrollbar.jquery.min.js"></script>
  <!--  Google Maps Plugin    -->
  <!-- Place this tag in your head or just before your close body tag. -->
  <script src="https://maps.googleapis.com/maps/api/js?key=YOUR_KEY_HERE"></script>
  <!-- Chart JS -->
 <script src="../PagAdm/black-dashboard-master/assets/js/plugins/chartjs.min.js"></script>
  <!--  Notifications Plugin    -->
  <script src="../PagAdm/black-dashboard-master/assets/js/plugins/bootstrap-notify.js"></script>
  <!-- Control Center for Black Dashboard: parallax effects, scripts for the example pages etc -->
  
 <script src="../PagAdm/black-dashboard-master/assets/js/black-dashboard.min.js"></script><!-- Black Dashboard DEMO methods, don't include it in your project! -->
<script src="../PagAdm/black-dashboard-master/assets/demo/demo.js"></script>

    <script>
    $(document).ready(function() {
      $().ready(function() {
        $sidebar = $('.sidebar');
        $navbar = $('.navbar');
        $main_panel = $('.main-panel');

        $full_page = $('.full-page');

        $sidebar_responsive = $('body > .navbar-collapse');
        sidebar_mini_active = true;
        white_color = false;

        window_width = $(window).width();

        fixed_plugin_open = $('.sidebar .sidebar-wrapper .nav li.active a p').html();



        $('.fixed-plugin a').click(function(event) {
          if ($(this).hasClass('switch-trigger')) {
            if (event.stopPropagation) {
              event.stopPropagation();
            } else if (window.event) {
              window.event.cancelBubble = true;
            }
          }
        });

        $('.fixed-plugin .background-color span').click(function() {
          $(this).siblings().removeClass('active');
          $(this).addClass('active');

          var new_color = $(this).data('color');

          if ($sidebar.length != 0) {
            $sidebar.attr('data', new_color);
          }

          if ($main_panel.length != 0) {
            $main_panel.attr('data', new_color);
          }

          if ($full_page.length != 0) {
            $full_page.attr('filter-color', new_color);
          }

          if ($sidebar_responsive.length != 0) {
            $sidebar_responsive.attr('data', new_color);
          }
        });

        $('.switch-sidebar-mini input').on("switchChange.bootstrapSwitch", function() {
          var $btn = $(this);

          if (sidebar_mini_active == true) {
            $('body').removeClass('sidebar-mini');
            sidebar_mini_active = false;
            blackDashboard.showSidebarMessage('Sidebar mini deactivated...');
          } else {
            $('body').addClass('sidebar-mini');
            sidebar_mini_active = true;
            blackDashboard.showSidebarMessage('Sidebar mini activated...');
          }

          // we simulate the window Resize so the charts will get updated in realtime.
          var simulateWindowResize = setInterval(function() {
            window.dispatchEvent(new Event('resize'));
          }, 180);

          // we stop the simulation of Window Resize after the animations are completed
          setTimeout(function() {
            clearInterval(simulateWindowResize);
          }, 1000);
        });

        $('.switch-change-color input').on("switchChange.bootstrapSwitch", function() {
          var $btn = $(this);

          if (white_color == true) {

            $('body').addClass('change-background');
            setTimeout(function() {
              $('body').removeClass('change-background');
              $('body').removeClass('white-content');
            }, 900);
            white_color = false;
          } else {

            $('body').addClass('change-background');
            setTimeout(function() {
              $('body').removeClass('change-background');
              $('body').addClass('white-content');
            }, 900);

            white_color = true;
          }


        });

        $('.light-badge').click(function() {
          $('body').addClass('white-content');
        });

        $('.dark-badge').click(function() {
          $('body').removeClass('white-content');
        });
      });
    });
  </script>
  <script>
    $(document).ready(function() {
      // Javascript method's body can be found in assets/js/demos.js
      demo.initDashboardPageCharts();

    });
  </script>
  <script src="https://cdn.trackjs.com/agent/v3/latest/t.js"></script>
  <script>
    window.TrackJS &&
      TrackJS.install({
        token: "ee6fab19c5a04ac1a32a645abde4613a",
        application: "black-dashboard-free"
      });
  </script>
</html>
