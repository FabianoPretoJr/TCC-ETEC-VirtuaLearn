<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contato.aspx.cs" Inherits="VirtuaLearn.UI.FaleConosco" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
   <link href="MDB-Free/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="../css/Style.css" />
    <link href="../css/FaleConosco.css" rel="stylesheet" />
    <link rel="shortcut icon" href="../img/cubo.png" type="../image/x-png" />
    <link href="../css/icons.css" rel="stylesheet" />
    <link href="../css/BackgroundPulseContato%20.css" rel="stylesheet" />
    <title>Virtua Learn</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container-fluid">
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
                                <a href="../EXTERNO/Login.aspx" class="btn btn-outline-light my-2 my-sm-0">Login</a>                                
                            </div>
                        </div>
                    </nav>
                </header>
                <!--CABEÇALHO-->

                <section>
                    <div class="bgPulse">
                        <span></span>
                        <span></span>
                        <span></span>
                        <span></span>
                        <span></span>
                        <span></span>
                        <span></span>
                        <span></span>
                        <span></span>
                        <span></span>
                        <br />
                        <br />
                        <br />
                        <div class="container contact">
                            <div class="row">
                                <div class="col-md-3">
                                    <div class="contact-info">
                                        <img src="https://image.ibb.co/kUASdV/contact-image.png" alt="image" />
                                        <h4>ENTRE EM CONTATO</h4>
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <h4>Gostaríamos muito de ouvir você!</h4>
                                    </div>
                                </div>
                                <div class="col-md-9">
                                    <div class="contact-form">
                                        <div class="form-group">
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <label class="control-label col-sm-2" for="fname"></label>
                                            <div class="col-sm-10">
                                                <asp:TextBox ID="txtNome" class="form-control" placeholder="Nome" required="" runat="server" MaxLength="20" ValidationGroup="0"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label class="control-label col-sm-2" for="lname"></label>
                                            <div class="col-sm-10">
                                                <asp:TextBox ID="txtSobrenome" class="form-control" placeholder="Sobrenome" required="" runat="server" MaxLength="30" ValidationGroup="0"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label class="control-label col-sm-2" for="email"></label>
                                            <div class="col-sm-10">
                                                <asp:TextBox ID="txtEmail" class="form-control" placeholder="Email" runat="server" required="" TextMode="Email" MaxLength="30" ValidationGroup="0"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label class="control-label col-sm-2" for="comment"></label>
                                            <div class="col-sm-10">
                                                <asp:TextBox ID="txtDuvida" class="form-control" placeholder="Dúvidas" runat="server" required="" TextMode="MultiLine" MaxLength="500" ValidationGroup="0"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-sm-offset-2 col-sm-10">
                                                <asp:Button ID="btnEnviar" runat="server" class="btn btn-warning" Text="Enviar" OnClick="btnEnviar_Click" ValidationGroup="0" />
                                            </div>
                                        </div>
                                    </div>

                                </div>

                            </div>

                        </div>

                        <br />
                        <br />
                        <br />
                    </div>
                </section>

                <footer>
                    <br />
                    <br />

                    <!--DESENVOLVEDORES-->
                    <br />


                    <a class="facebook" href="https://www.facebook.com/virtualearnead/" target="_blank">
                        <svg xmlns="http://www.w3.org/2000/svg" width="60" height="60" viewBox="0 0 60 60">
                            <rect x="13" y="13" fill="#EEEEEE" transform="matrix(-0.7071 0.7071 -0.7071 -0.7071 73.0976 30.4134)" width="36" height="36"></rect><path fill="#000000" d="M31.8,40.3h-3.7v-10h-2.5v-3.4l2.5,0l0-2c0-2.8,0.8-4.5,4.1-4.5h2.8v3.4h-1.7c-1.3,0-1.4,0.5-1.4,1.4l0,1.7h3.1l-0.4,3.4l-2.7,0L31.8,40.3L31.8,40.3z"></path></svg></a>
                    <a class="twitter" href="#" target="_blank">
                        <svg xmlns="http://www.w3.org/2000/svg" width="60" height="60" viewBox="0 0 60 60">
                            <rect x="13" y="13" fill="#EEEEEE" transform="matrix(-0.7071 0.7071 -0.7071 -0.7071 73.0976 30.4134)" width="36" height="36"></rect><path fill="#000000" d="M41.076,23.131c-0.814,0.36-1.691,0.605-2.611,0.715c0.938-0.562,1.658-1.453,1.998-2.514c-0.877,0.521-1.852,0.899-2.885,1.103C36.75,21.552,35.566,21,34.26,21c-2.508,0-4.543,2.034-4.543,4.544c0,0.357,0.039,0.703,0.117,1.035c-3.777-0.189-7.125-1.999-9.367-4.747c-0.391,0.67-0.615,1.45-0.615,2.284c0,1.576,0.803,2.968,2.021,3.783c-0.744-0.024-1.443-0.229-2.057-0.569c-0.002,0.019-0.002,0.039-0.002,0.058c0,2.202,1.566,4.038,3.645,4.456c-0.381,0.104-0.783,0.16-1.197,0.16c-0.293,0-0.576-0.028-0.855-0.083c0.58,1.805,2.258,3.119,4.246,3.156c-1.557,1.219-3.516,1.945-5.643,1.945c-0.369,0-0.73-0.022-1.086-0.063c2.012,1.289,4.4,2.041,6.967,2.041c8.357,0,12.93-6.925,12.93-12.931c0-0.197-0.004-0.393-0.014-0.587C39.695,24.841,40.465,24.041,41.076,23.131L41.076,23.131z"></path></svg></a>
                    <a class="instagram" href="#" target="_blank">
                        <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 60 60" width="60" height="60">
                            <rect x="12" y="12" transform="matrix(0.7071 -0.7071 0.7071 0.7071 -12.4264 30)" fill="#EEEEEE" width="36" height="36" />
                            <path d="M36.5,19.3H23.5c-2.3,0-4.1,1.8-4.1,4.1v4.4v8.7c0,2.3,1.9,4.1,4.1,4.1h13.1c2.3,0,4.1-1.8,4.1-4.1v-8.7v-4.4C40.7,21.2,38.8,19.3,36.5,19.3z M37.7,21.8l0.5,0v0.5v3.1l-3.6,0l0-3.6L37.7,21.8z M27,27.8c0.7-0.9,1.8-1.6,3-1.6s2.4,0.6,3,1.6c0.4,0.6,0.7,1.4,0.7,2.2c0,2.1-1.7,3.8-3.8,3.8s-3.8-1.7-3.8-3.8C26.2,29.2,26.5,28.4,27,27.8z M38.6,36.5c0,1.1-0.9,2-2,2H23.5c-1.1,0-2-0.9-2-2v-8.7h3.2c-0.3,0.7-0.4,1.4-0.4,2.2c0,3.2,2.6,5.8,5.8,5.8c3.2,0,5.8-2.6,5.8-5.8c0-0.8-0.2-1.5-0.4-2.2h3.2V36.5z" />
                        </svg></a>

                    <br />
                    <br />
                    <h5>© Virtua Learn 2019<br />
                        Avenida Santa Inês, 801, 7º andar, conjunto 76, Santana, São Paulo - SP.<br />
                        CEP 02415-001<br />

                        Tel. 11 3294 9723<br />

                        Celular e Whatsapp - (11) 9 8255-5688<br />

                        sac@virtualearn.com.br</h5>


                </footer>
                <!--RODAPÉ-->
            </div>


            <!--RODAPÉ-->

        </div>
    </form>

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

</body>
</html>
