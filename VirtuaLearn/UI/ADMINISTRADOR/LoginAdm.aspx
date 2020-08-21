<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAdm.aspx.cs" Inherits="VirtuaLearn.UI.LoginAdm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="../css/bootstrap.css" />
    <link rel="stylesheet" href="../css/Style.css" />
    <link href="../css/LooginAdm.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.1/css/all.css" integrity="sha384-gfdkjb5BdAXd+lj+gudLWI+BXq4IuLW5IT+brZEZsLFm++aCMlF1V92rMkPaX4PP" crossorigin="anonymous" />
    <link rel="shortcut icon" href="../img/cubo.png" type="../image/x-png" />
    <link href="../css/icons.css" rel="stylesheet" />
    <link href="../css/BackgroundPulseLoginAdm%20.css" rel="stylesheet" />
     <link rel="shortcut icon" href="../img/cubo.png" type="../image/x-png" />
    <title>Virtua Learn</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
                <div class="container">
                   
                   
                    <br />                    
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <div class="container h-100">
                        <div class="d-flex justify-content-center h-100">
                            <div class="user_card">
                                <div class="d-flex justify-content-center">
                                    <div class="brand_logo_container">
                                        <img src="../img/lock.png" height="120" width="120" alt="Logo" />
                                    </div>
                                </div>
                                <div class="d-flex justify-content-center form_container">
                                    <div>
                                        <div class="input-group mb-3">
                                            <div class="input-group-append">
                                                <div class="input-group-text"><i class="fas fa-user"></i></div>
                                            </div>
                                            <asp:TextBox ID="txtNome" class="form-control input_user" runat="server" placeholder="USUÁRIO" MaxLength="30"></asp:TextBox>
                                        </div>
                                        <div class="input-group mb-2">
                                            <div class="input-group-append">
                                                <div class="input-group-text"><i class="fas fa-key"></i></div>
                                            </div>
                                            <asp:TextBox ID="txtSenha" runat="server" class="form-control input_pass" placeholder="SENHA" TextMode="Password" MaxLength="20"></asp:TextBox>
                                        </div>
                                        
                                    </div>
                                </div>
                                <div class="d-flex justify-content-center mt-3 login_container">
                                    <asp:Button ID="btnEntrar" runat="server" Text="ENTRAR"  class="btn login_btn" OnClick="btnEntrar_Click"/>
                                </div>
                                
                                
                               
                                
                               </div>
                            </div>
                        </div>
                    </div>

                
          <br/><br/><br/><br/>
               </div>
    </section>
            </div>
    </form>
    <!-- Optional JavaScript -->
<!-- jQuery first, then Popper.js, then Bootstrap JS -->
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

</body>
</html>
