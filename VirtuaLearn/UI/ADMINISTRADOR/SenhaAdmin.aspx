<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SenhaAdmin.aspx.cs" Inherits="VirtuaLearn.UI.ADMINISTRADOR.SenhaAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />

    <link rel="apple-touch-icon" sizes="76x76" href="../assets/img/apple-icon.png" />
    <link rel="icon" type="../image/png" href="../assets/img/favicon.png" />
    <!--     Fonts and icons     -->
    <link href="https://fonts.googleapis.com/css?family=Poppins:200,300,400,600,700,800" rel="stylesheet" />
    <link href="https://use.fontawesome.com/releases/v5.0.6/css/all.css" rel="stylesheet" />
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

                            <a href="javascript:void(0)" class="simple-text logo-mini"></a>
                            <a href="javascript:void(0)" class="simple-text logo-normal">M E N U
                            </a>
                        </div>
                        <ul class="nav">
                            <li>
                                <a href="PagAdmin.aspx">

                                    <i class="tim-icons icon-app"></i>
                                    <p>Dashboard</p>
                                </a>
                            </li>
                            <li>
                                <a href="CursoAdmin.aspx">
                                    <i class="tim-icons icon-book-bookmark"></i>
                                    <p>Cursos</p>
                                </a>
                            </li>
                            <li>
                                <a href="ConteudoAdmin.aspx">
                                    <i class="tim-icons icon-paper"></i>
                                    <p>Conteudos</p>
                                </a>
                            </li>
                            <li>
                                <a href="QuizzAdmin.aspx">
                                    <i class="tim-icons icon-puzzle-10"></i>
                                    <p>Quizz</p>
                                </a>
                            </li>
                            <li>
                                <a href="ProfsAdmin.aspx">
                                    <i class="tim-icons icon-badge"></i>
                                    <p>Professores</p>
                                </a>
                            </li>
                            <li>
                                <a href="PerfilAdm.aspx">
                                    <i class="tim-icons icon-single-02"></i>
                                    <p>Perfil</p>
                                </a>
                            </li>
                            <li>
                                <a href="CertificadoAdmin.aspx">
                                    <i class="tim-icons icon-notes"></i>
                                    <p>Certificado</p>
                                </a>
                            </li>
                            <li class="active ">
                                <a href="SenhaAdmin.aspx">
                                    <i class="tim-icons icon-bulb-63"></i>
                                    <p>Recuperar senhas</p>
                                </a>
                            </li>
                            <li>
                                <a href="TermosAdmin.aspx">
                                    <i class="tim-icons icon-pencil"></i>
                                    <p>Editar Termos de uso</p>
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
                                <asp:ImageButton ID="btnIndex" class="navbar-brand" runat="server" Height="60px" ImageUrl="../img/1logo.png" OnClick="btnIndex_Click" Width="190px" />
                            </div>
                            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navigation" aria-expanded="false" aria-label="Toggle navigation">
                                <span class="navbar-toggler-bar navbar-kebab"></span>
                                <span class="navbar-toggler-bar navbar-kebab"></span>
                                <span class="navbar-toggler-bar navbar-kebab"></span>
                            </button>
                            <div class="collapse navbar-collapse" id="navigation">
                                <ul class="navbar-nav ml-auto">
                                    <asp:Button ID="btnSair" class="btn btn-fill btn-primary" runat="server" Text="Sair" OnClick="btnSair_Click" />
                                    <!--SAIR DA SESSÃO-->
                                </ul>
                            </div>
                        </div>
                    </nav>
                    <div class="modal modal-search fade" id="searchModal" tabindex="-1" role="dialog" aria-labelledby="searchModal" aria-hidden="true">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <input type="text" class="form-control" id="inlineFormInputGroup" placeholder="SEARCH" />
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <i class="tim-icons icon-simple-remove"></i>
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- End Navbar -->

                    <!--Conteudo-->
                    <div class="content">
                        <div class="row">
                            <div class="col-lg-12 col-md-12">
                                <div class="card ">
                                    <div class="card-header">
                                        <h4 class="card-title">
                                            <asp:Label ID="lblCad" runat="server" Text="Recuperar Senha" Visible="False"></asp:Label>
                                        </h4>
                                    </div>
                                    <div class="card-body">
                                        <div class="table-responsive">
                                            <table class="table tablesorter " id="">
                                                <thead class=" text-primary">
                                                </thead>
                                                <tbody>
                                                    <div class="center-text">
                                                        <asp:TextBox ID="txtFiltro" class="form-control" Width="350" runat="server" Visible="True"></asp:TextBox>
                                                        <br />
                                                        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" class="btn btn-fill btn-dark" Visible="True" OnClick="btnFiltrar_Click"/>
                                                    </div>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label1" runat="server" Text="" Visible="False">Usuário</asp:Label>
                                                            <asp:Label ID="lblUsuario" runat="server" class="form-control" Text="" Visible="False"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label2" runat="server" Text="" Visible="False">CPF</asp:Label>
                                                            <asp:Label ID="lblCpf" runat="server" class="form-control" Text="" Visible="False"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label3" runat="server" Text="" Visible="False">Nova senha:</asp:Label>
                                                            <asp:TextBox ID="txtSenha" class="form-control" runat="server" MaxLength="40" Visible="False" TextMode="Password"></asp:TextBox>
                                                            <br />
                                                            <asp:Button ID="btnRecuperar" runat="server" Text="Alterar" class="btn btn-fill btn-dark" Visible="False" OnClick="btnRecuperar_Click"/>
                                                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="btn btn-fill btn-danger" Visible="False" OnClick="btnCancelar_Click" />
                                                            <asp:Label ID="lblId" runat="server" Visible="False"></asp:Label>
                                                        </td>
                                                    </tr>

                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>

                        <!--end Conteudo-->


                        <footer class="footer">
                            <div class="container-fluid">
                                <ul class="nav">
                                    <li class="nav-item">
                                        <a href="javascript:void(0)" class="nav-link"></a>
                                    </li>
                                    <li class="nav-item">
                                        <a href="javascript:void(0)" class="nav-link"></a>
                                    </li>
                                    <li class="nav-item">
                                        <a href="javascript:void(0)" class="nav-link"></a>
                                    </li>
                                </ul>
                                <div class="copyright">
                                    ©
            <script>
                document.write(new Date().getFullYear())
            </script>
                                    <i class=""></i>-
            <a href="javascript:void(0)" target="_blank">Virtua Learn</a>
                                </div>
                            </div>
                        </footer>
                    </div>
                </div>

            </div>
    </form>
</body>
</html>
