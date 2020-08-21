<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="VirtuaLearn.UI.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="MDB-Free/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="../css/style.css" />
    <link rel="shortcut icon" href="../img/cubo.png" type="../image/x-png" />
    <link href="../css/Cadastroo.css" rel="stylesheet" />
    <link href="../css/icons.css" rel="stylesheet" />
    <link href="../css/BackgroundPulseCadastro%20.css" rel="stylesheet" />
    <title>Virtua Learn</title>
</head>
<body>
    <form id="form1" runat="server">
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
            <!--CABEÇALHO - #f39c12-->
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




                        <div class="container h-100">
                            <div class="d-flex justify-content-center h-100">
                                <div class="user_card">
                                    <div class="d-flex justify-content-center">
                                        <div class="brand_logo_container">
                                            <img src="../img/cubo.png" height="160" width="160" alt="Logo" />
                                        </div>
                                    </div>
                                    <br />
                                    <br />
                                    <div class="d-flex justify-content-center form_container">
                                        <div>


                                            <div class="form-row">
                                                <div class="col-md-8 mb-8">
                                                    <label for="validationServer01">Nome Completo </label>
                                                    <asp:TextBox ID="txtNome" class="form-control" runat="server" placeholder="Nome" required="" MaxLength="50" CausesValidation="False"></asp:TextBox>
                                                </div>

                                                <div class="col-md-4 mb-4">
                                                    <label for="validationServer01">Data de nascimento</label>
                                                    <asp:TextBox ID="txtNasc" class="form-control" runat="server" placeholder="Nasc" required="" TextMode="Date"></asp:TextBox>
                                                </div>


                                            </div>



                                            <div class="form-row">
                                                <div class="col-md-3 mb-3">
                                                    <label for="validationServer01">CPF</label>
                                                    <asp:TextBox ID="txtCpf" runat="server" class="form-control" placeholder="CPF" required="" MaxLength="11" MinLength="11"></asp:TextBox>
                                                </div>
                                                <div class="col-md-3 mb-3">
                                                    <label for="validationServer01">RG</label>
                                                    <asp:TextBox ID="txtRg" class="form-control" runat="server" placeholder="RG" required="" MaxLength="10" MinLength="10"></asp:TextBox>
                                                </div>
                                                <div class="col-md-2 mb-3">
                                                    <label for="validationServer01">Cep</label>
                                                    <asp:TextBox ID="txtCep" runat="server" class="form-control" placeholder="CEP" required="" MaxLength="8" MinLength="8"></asp:TextBox>
                                                </div>

                                                <div class="col-md-4 mb-4">
                                                    <label for="validationServer01">Estado</label>
                                                    <asp:DropDownList ID="DropDownList" class="form-control" runat="server" placeholder="Estado" required="">
                                                        <asp:ListItem Value="AC">Acre</asp:ListItem>
                                                        <asp:ListItem Value="AL">Alagoas</asp:ListItem>
                                                        <asp:ListItem Value="AP">Amapá</asp:ListItem>
                                                        <asp:ListItem Value="AM">Amazonas</asp:ListItem>
                                                        <asp:ListItem Value="BA">Bahia</asp:ListItem>
                                                        <asp:ListItem Value="CE">Ceará</asp:ListItem>
                                                        <asp:ListItem Value="DF">Distrito Federal</asp:ListItem>
                                                        <asp:ListItem Value="ES">Espírito Santo</asp:ListItem>
                                                        <asp:ListItem Value="GO">Goiás</asp:ListItem>
                                                        <asp:ListItem Value="MA">Maranhão</asp:ListItem>
                                                        <asp:ListItem Value="MT">Mato Grosso</asp:ListItem>
                                                        <asp:ListItem Value="MS">Mato Grosso do Sul</asp:ListItem>
                                                        <asp:ListItem Value="MG">Minas Gerais</asp:ListItem>
                                                        <asp:ListItem Value="PA">Pará</asp:ListItem>
                                                        <asp:ListItem Value="PB">Paraíba</asp:ListItem>
                                                        <asp:ListItem Value="PR">Paraná</asp:ListItem>
                                                        <asp:ListItem Value="PE">Pernambuco</asp:ListItem>
                                                        <asp:ListItem Value="PI">Piauí</asp:ListItem>
                                                        <asp:ListItem Value="RJ">Rio Janeiro</asp:ListItem>
                                                        <asp:ListItem Value="RN">Rio Grande do Norte</asp:ListItem>
                                                        <asp:ListItem Value="RS">Rio Grande do Sul</asp:ListItem>
                                                        <asp:ListItem Value="RO">Rondônia</asp:ListItem>
                                                        <asp:ListItem Value="RR">Roraima</asp:ListItem>
                                                        <asp:ListItem Value="SC">Santa Catarina</asp:ListItem>
                                                        <asp:ListItem Value="SP">São Paulo</asp:ListItem>
                                                        <asp:ListItem Value="SE">Sergipe</asp:ListItem>
                                                        <asp:ListItem Value="TO">Tocantins</asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                            </div>


                                            <div class="form-row">



                                                <div class="col-md-4 mb-3">
                                                    <label for="validationServer01">Bairro</label>
                                                    <asp:TextBox ID="txtBairro" class="form-control" runat="server" placeholder="Bairro" required="" MaxLength="30"></asp:TextBox>
                                                </div>
                                                <div class="col-md-3 mb-3">
                                                    <label for="validationServer01">Cidade</label>
                                                    <asp:TextBox ID="txtCidade" class="form-control" runat="server" placeholder="Cidade" required="" MaxLength="30"></asp:TextBox>
                                                </div>
                                                <div class="col-md-4 mb-3">
                                                    <label for="validationServer01">Rua/Av</label>
                                                    <asp:TextBox ID="txtRuaAv" class="form-control" runat="server" placeholder="RuaAv" required="" MaxLength="20"></asp:TextBox>
                                                </div>
                                                <div class="col-md-1 mb-1">
                                                    <label for="validationServer01">N°</label>
                                                    <asp:TextBox ID="txtNum" class="form-control" runat="server" placeholder="Nº" required="" MaxLength="10"></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="form-row">
                                                <div class="col-md-8 mb-9">
                                                    <label for="validationServer01">E-mail</label>
                                                    <asp:TextBox ID="txtEmail" class="form-control" runat="server" placeholder="Email" required="" TextMode="Email" MaxLength="30"></asp:TextBox>
                                                </div>
                                                <div class="col-md-4 mb-4">
                                                    <label for="validationServer01">Telefone </label>
                                                    <asp:TextBox ID="txtTelefone" class="form-control" runat="server" placeholder="Telefone" required="" MaxLength="11" MinLength="10"></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="form-row">
                                                <div class="col-md-6 mb-6">
                                                    <label for="validationServer01">Nome de usuário</label>
                                                    <asp:TextBox ID="txtUsuario" class="form-control" runat="server" placeholder="Usuario" required="" MaxLength="20" MinLength="6"></asp:TextBox>
                                                </div>
                                                <div class="col-md-6 mb-6">
                                                    <label for="validationServer01">Escolha uma senha</label>
                                                    <asp:TextBox ID="txtSenha" class="form-control" runat="server" placeholder="Senha" required="" TextMode="Password" MaxLength="20" MinLength="8"></asp:TextBox>
                                                </div>

                                                <!--<div class="col-md-7 mb-6">
                                                            <label for="validationServer01">Confirmar Senha</label>
                                                            <asp:TextBox ID="txtSenha1"  class="form-control" runat="server" placeholder="Senha" required="" TextMode="Password"></asp:TextBox>
                                                        </div>-->
                                            </div>
                                            <br />
                                            <div class="form-row">
                                                <div class="col-md-6 mb-6">
                                                    <asp:CheckBox ID="CheckBox1" runat="server" />&nbsp
                                                <label class="form-check-label" for="invalidCheck2">Eu concordo com os </label>
                                                    <asp:Literal ID="litTermos" runat="server"></asp:Literal>
                                                    <asp:Literal ID="litAviso" runat="server"></asp:Literal>
                                                </div>
                                            </div>

                                            <br/>


                                            <asp:Button ID="btnCadastrar" class="btn btn-outline-light my-2 my-sm-0" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />

                                            <br />
                                        </div>
                                    </div>
                                    <br />

                                </div>


                            </div>
                        </div>
                    </div>

                </div>
                <br />
                <br />
                <br />
                <br />
        </div>
        </section>






        </div>
        <!--RODAPÉ-->
        <footer>


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
        <div />
    </form>
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>


    <!--Começo da chamada Jquery para endereços-->
    <!--<script type="text/javascript">
        $(document).ready(function () {
            function limpa_formulário_cep() {
                //Limpa valores do formulario de cep.
                $("#txtRuaAv").val("");
                $("#txtBairro").val("");
                $("#txtCidade").val("");
                $("#DropDownList").val("");
            }

            //Quando o corpo cep perde o foco.
            $("#txtCep").blur(function () {
                //nova variavel "CEP" somente com digitos.
                var cep = $(this).val().replace(/\D/g, '');

                //verifica se o campo cep possui valor informado.
                if (cep != "") {

                    //Expressao para validar o cep.
                    var validacep = /^[0-9]{8}$/;
                    //valida formato de cep.
                    if (validacep.test(cep)) {
                        //preenche campo com "..." enquanto consulta o webservice.
                        $("#txtRuaAv").val("...");
                        $("#txtBairro").val("...");
                        $("#txtCidade").val("...");

                        //consulta o webservice viacep.com.br/
                        $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {
                            if (!("erro" in dados)) {
                                //atualiza os campos com os valores da consulta.
                                $("#txtRuaAv").val(dados.logradouro);
                                $("#txtBairro").val(dados.bairro);
                                $("#txtCidade").val(dados.localidade);
                                //							$("#uf").val(dados.uf);
                                $("#DropDownList option[value=" + dados.uf + "]").attr('selected', 'selected');
                            } //end if.
                            else {
                                //CEP pesquisado não foi encontrado.
                                limpa_formulário_cep();
                                alert("CEP não encontrado.");
                            }
                        });
                    } //end if.
                    else {
                        //cep é inválido.
                        limpa_formulário_cep();
                        alert("Formato de CEP inválido.");
                    }
                } //end if.
                else {
                    //cep sem valor, limpa formulário.
                    limpa_formulário_cep();
                }
            });
        });

    </script>-->

</body>
</html>
