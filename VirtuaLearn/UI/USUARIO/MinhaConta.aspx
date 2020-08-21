<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MinhaConta.aspx.cs" Inherits="VirtuaLearn.UI.USUARIO.MinhaConta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/nucleo-icons.css" rel="stylesheet" />
    <link href="bootstrap-4.3.1-dist/css/bootstrap.css" rel="stylesheet" />  
    <link rel="shortcut icon" href="../img/cubo.png" type="../image/x-png" />
    <link href="CSS/Style.css?Version=1" rel="stylesheet" />  
    <link href="CSS/paginacao.css" rel="stylesheet" />
    <link href="CSS/pesquisa.css" rel="stylesheet" />
    
    <link href="https://use.fontawesome.com/releases/v5.0.6/css/all.css" rel="stylesheet" />
    <link href="CSS/cardCurso.css" rel="stylesheet" />

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
  
            <asp:Button ID="btnConta" class="dropdown-item" runat="server" Text="Minha conta" ></asp:Button>
            <asp:Button ID="btnAjuda" class="dropdown-item" runat="server" Text="Ajuda"></asp:Button>
            <asp:Button ID="btnSair" class="dropdown-item" runat="server" Text="Sair"></asp:Button>
          
          
        </div>
      </li>


                        </ul>
                    </lateral>
                </div>
            </header>


            
<div class="container">
<br/>
<br/>
    <br/>
    <br/>
	<div class="row" id="main">
        <div class="col-md-4 well" id="leftPanel">
            <div class="row">
                <div class="col-md-12">
                	<div>
        				<img src="../img/user.png" width="200px" height="200px" alt="Texto Alternativo" class="rounded-circle" />
        				<h2>Usuario</h2>
        				<p>DESCRIÇÃO: Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
        				tempor incididunt ut labore et dolore magna aliqua.</p>
                       
        			</div>
        		</div>
            </div>
        </div>           
        <div class="col-md-8 well" id="rightPanel">
            <div class="row">
    <div class="col-md-12">
    	<form role="form">
			<h2>Editar Perfil<small></small></h2>
			<hr class="colorgraph">
			<div class="row">
				<div class="col-xs-12 col-sm-6 col-md-6">
					<div class="form-group">
                        <input type="text" name="first_name" id="first_name" class="form-control input-lg" placeholder="Nome" tabindex="1">
					</div>
				</div>
				<div class="col-xs-12 col-sm-6 col-md-6">
					<div class="form-group">
						<input type="text" name="last_name" id="last_name" class="form-control input-lg" placeholder="Sobrenome" tabindex="2">
					</div>
				</div>
			</div>
			
			<div class="row">
				<div class="col-xs-12 col-sm-6 col-md-6">
					<div class="form-group">
						<input type="date" name="date" id="RG" class="form-control input-lg" placeholder="dd/mm/aa" tabindex="5">
					</div>
				</div>
				<div class="col-xs-12 col-sm-6 col-md-6">
					<div class="form-group">
						<input type="text" name="text" id="CPF" class="form-control input-lg" placeholder="Telefone" tabindex="6">
					</div>
				</div>

			</div>
           
            <div class="row">
				<div class="col-xs-12 col-sm-6 col-md-6">
					<div class="form-group">
						<input type="text" name="text" id="cpf" class="form-control input-lg" placeholder="CPF" tabindex="5">
					</div>
				</div>
				<div class="col-xs-12 col-sm-6 col-md-6">
					<div class="form-group">
						<input type="text" name="text" id="RG1" class="form-control input-lg" placeholder="RG" tabindex="6">
					</div>
				</div>
                
			</div>
             <div class="row">
				<div class="col-xs-12 col-sm-6 col-md-6">
					<div class="form-group">
						<input type="text" name="text" id="CPF1" class="form-control input-lg" placeholder="CEP" tabindex="5">
					</div>
				</div>
				<div class="col-xs-12 col-sm-6 col-md-6">
					<div class="form-group">
						<input type="text" name="text" id="Estado1" class="form-control input-lg" placeholder="Estado" tabindex="6">
					</div>
				</div>
                
			</div>
             <div class="row">
				<div class="col-xs-12 col-sm-6 col-md-6">
					<div class="form-group">
						<input type="text" name="password" id="Bairro1" class="form-control input-lg" placeholder="Bairro" tabindex="5">
					</div>
				</div>
				<div class="col-xs-12 col-sm-6 col-md-6">
					<div class="form-group">
						<input type="text" name="Cidade" id="Cidade1" class="form-control input-lg" placeholder="Cidade" tabindex="6">
					</div>
				</div>
                
			</div>

            <div class="row">
				<div class="col-xs-12 col-sm-10 col-md-10">
					<div class="form-group">
						<input type="text" name="text" id="Rua1" class="form-control input-lg" placeholder="Rua" tabindex="5">
					</div>
				</div>
				<div class="col-xs-12 col-sm-2 col-md-2">
					<div class="form-group">
						<input type="text" name="Cidade" id="n1" class="form-control input-lg" placeholder="Nº" tabindex="6">
					</div>
				</div>
                
			</div>
             <div class="form-group">
				<input type="email" name="email" id="email" class="form-control input-lg" placeholder="Email" tabindex="4">
			</div>
            <div class="row">
				<div class="col-xs-12 col-sm-6 col-md-6">
					<div class="form-group">
						<input type="password" name="password" id="password" class="form-control input-lg" placeholder="Senha" tabindex="5">
					</div>
				</div>
				<div class="col-xs-12 col-sm-6 col-md-6">
					<div class="form-group">
						<input type="password" name="password_confirmation" id="password_confirmation" class="form-control input-lg" placeholder="Confirmar senha" tabindex="6">
					</div>
				</div>
                
			</div>
			<hr class="colorgraph">
			<div class="row">
				<div class="col-xs-12 col-md-6"></div>
				<div class="col-xs-12 col-md-6"><a href="#" class="btn btn-block btn-lg">Salvar</a></div>
			</div>
		</form>
	</div>
</div>
<!-- Modal -->
<div class="modal fade" id="t_and_c_m" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
	<div class="modal-dialog modal-lg">
		<div class="modal-content">
			<div class="modal-header">
				<button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
				<h4 class="modal-title" id="myModalLabel">Terms & Conditions</h4>
			</div>
			<div class="modal-body">
				<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Similique, itaque, modi, aliquam nostrum at sapiente consequuntur natus odio reiciendis perferendis rem nisi tempore possimus ipsa porro delectus quidem dolorem ad.</p>
				<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Similique, itaque, modi, aliquam nostrum at sapiente consequuntur natus odio reiciendis perferendis rem nisi tempore possimus ipsa porro delectus quidem dolorem ad.</p>
				<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Similique, itaque, modi, aliquam nostrum at sapiente consequuntur natus odio reiciendis perferendis rem nisi tempore possimus ipsa porro delectus quidem dolorem ad.</p>
				<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Similique, itaque, modi, aliquam nostrum at sapiente consequuntur natus odio reiciendis perferendis rem nisi tempore possimus ipsa porro delectus quidem dolorem ad.</p>
				<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Similique, itaque, modi, aliquam nostrum at sapiente consequuntur natus odio reiciendis perferendis rem nisi tempore possimus ipsa porro delectus quidem dolorem ad.</p>
				<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Similique, itaque, modi, aliquam nostrum at sapiente consequuntur natus odio reiciendis perferendis rem nisi tempore possimus ipsa porro delectus quidem dolorem ad.</p>
				<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Similique, itaque, modi, aliquam nostrum at sapiente consequuntur natus odio reiciendis perferendis rem nisi tempore possimus ipsa porro delectus quidem dolorem ad.</p>
			</div>
			<div class="modal-footer">
				<button type="button" class="btn" data-dismiss="modal">I Agree</button>
			</div>
		</div><!-- /.modal-content -->
	</div><!-- /.modal-dialog -->
</div><!-- /.modal -->
</div>
        </div>
     </div>       
</div>
            <br/>    <br/>
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
</html>
