using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace VirtuaLearn.UI.PROFESSOR
{
    public partial class PerfilAdmC : System.Web.UI.Page
    {
        BLL.Professor pro = new BLL.Professor();
        DAL.ProfessorDAL proDAL = new DAL.ProfessorDAL();

        BLL.Login lo = new BLL.Login();
        DAL.LoginDAL loDAL = new DAL.LoginDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] != null)
                {
                    if (Session["usuario"].ToString() != string.Empty)
                    {
                        pro.IdLogin = Convert.ToInt32(Session["idlogin"]);
                        pro = proDAL.PreencherPeloID(pro);


                        if (pro.IdProfessor.ToString() != null)
                        {
                            if (pro.IdProfessor.ToString() != "")
                            {
                                int idRecebido;
                                int.TryParse(pro.IdProfessor.ToString(), out idRecebido);

                                //pro.IdProfessor = idRecebido;
                                //pro = proDAL.PreencherPeloID(pro);

                                lo.IdLogin = Convert.ToInt32(Session["idlogin"]);
                                lo = loDAL.PreencherPeloID(lo);

                                if (pro.IdProfessor != 0)
                                {
                                    lblId.Text = pro.IdProfessor.ToString();
                                    Image1.ImageUrl = pro.Foto;
                                    txtNome.Text = pro.Nome;                                    
                                    txtEmail.Text = pro.Email;                                    
                                    txtTelefone.Text = pro.Telefone;                                    
                                    txtDescricao.Text = pro.Descricao;                                   
                                    txtCpf.Text = pro.Cpf;


                                    Image1.ImageUrl = pro.Foto;
                                    lblNome.Text = pro.Nome;
                                    lblEmail.Text = pro.Email;
                                    lblTelefone.Text = pro.Telefone;
                                    lblDescricao.Text = pro.Descricao;
                                    lblCpf.Text = pro.Cpf;

                                    lblIdL.Text = lo.IdLogin.ToString();
                                    txtUsuario.Text = lo.Usuario;
                                    txtSenha.Text = lo.Senha;
                                }
                                else
                                {
                                    //lblId.Text = "ID INVÁLIDO";
                                }
                            }
                            else
                            {
                                //lblId.Text = "ID INVÁLIDO";
                            }
                        }
                        else
                        {
                            //lblId.Text = "ID INVÁLIDO";
                        }
                    }
                    else
                    {
                        Response.Redirect("../ADMINISTRADOR/LoginAdm.aspx");
                    }
                }
                else
                {
                    Response.Redirect("../ADMINISTRADOR/LoginAdm.aspx");
                }
            }
        }

        protected void btnIndex_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("PagAdmComum.aspx");
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (fulFoto.HasFile)
            {
                if (fulFoto.PostedFile.ContentLength < 625000) // Menor que 5MB (625000 megabyte)
                {
                    try
                    {
                        if (fulFoto.HasFile)//Verifica se algum arquivo foi selecionado
                        {
                            try
                            {
                                //Aqui ele vai filtrar pelo tipo de arquivo
                                if (fulFoto.PostedFile.ContentType == "image/jpeg" ||
                                    fulFoto.PostedFile.ContentType == "image/png" ||
                                    fulFoto.PostedFile.ContentType == "image/gif" ||
                                    fulFoto.PostedFile.ContentType == "image/bmp")
                                {
                                    try
                                    {
                                        //Obtem o  HttpFileCollection (Lista de arquivos)
                                        HttpFileCollection hfc = Request.Files;
                                        for (int i = 0; i < hfc.Count; i++)
                                        {
                                            HttpPostedFile hpf = hfc[i];
                                            if (hpf.ContentLength > 0) //Verifica se o arquivo é maior que 0 bytes
                                            {
                                                //Pega o nome do arquivo
                                                string nome = System.IO.Path.GetFileName(hpf.FileName);
                                                //Pega a extensão do arquivo
                                                string extensao = Path.GetExtension(hpf.FileName);
                                                //Gera nome novo do Arquivo numericamente

                                                //string filename = string.Format("{0:00000000000000}", GerarID());

                                                string filename = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "_");

                                                //Caminho a onde será salvo
                                                hpf.SaveAs(Server.MapPath("~/UI/fotoprof/") + filename + "_" + i + extensao);



                                                pro.IdProfessor = Convert.ToInt32(lblId.Text);
                                                pro.Nome = txtNome.Text;
                                                pro.Email = txtEmail.Text;
                                                pro.Telefone = txtTelefone.Text;
                                                pro.Descricao = txtDescricao.Text;
                                                pro.Foto = "/UI/fotoprof/" + filename + "_" + i + extensao;
                                                pro.Cpf = txtCpf.Text;

                                                proDAL.Atualizar(pro);

                                                lo.IdLogin = Convert.ToInt32(lblIdL.Text);
                                                lo.Usuario = txtUsuario.Text;
                                                lo.Senha = BLL.Criptografia.getMdIHash(txtSenha.Text);

                                                loDAL.Atualizar(lo);
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        lblMensagem.Text = "Erro: " + ex.Message;
                                    }
                                    // Mensagem se tudo ocorreu bem      
                                    Response.Write("<script>alert('Perfil alterado com sucesso!')</script>");

                                    //Response.Redirect("PerfilAdmC.aspx");
                                }
                                else
                                {
                                    // Mensagem notifica que é permitido carregar apenas 
                                    // as imagens definida la em cima.
                                    lblMensagem.Text = "É permitido carregar apenas imagens!";
                                }
                            }
                            catch (Exception ex)
                            {
                                // Mensagem notifica quando ocorre erros
                                lblMensagem.Text = @"O arquivo não pôde ser carregado. 
                            O seguinte erro ocorreu: " + ex.Message;
                            }
                        }
                        else
                        {
                            lblMensagem.Text = "Nenhum arquivo selecionado";
                        }
                    }
                    catch (Exception ex)
                    {
                        // Mensagem notifica quando ocorre erros
                        lblMensagem.Text = @"O arquivo não pôde ser carregado. 
                    O seguinte erro ocorreu: " + ex.Message;
                    }
                }

                else
                {
                    // Mensagem notifica quando imagem é superior a 3 MB
                    lblMensagem.Text = "Não é permitido carregar imagem maior que 3 MB";
                }
            }
            else
            {


                pro.IdProfessor = Convert.ToInt32(lblId.Text);
                pro.Foto = Image1.ImageUrl;
                pro.Nome = txtNome.Text;
                pro.Email = txtEmail.Text;
                pro.Telefone = txtTelefone.Text;
                pro.Descricao = txtDescricao.Text;
                pro.Cpf = txtCpf.Text;

                proDAL.Atualizar(pro);

                lo.IdLogin = Convert.ToInt32(lblIdL.Text);
                lo.Usuario = txtUsuario.Text;
                lo.Senha = BLL.Criptografia.getMdIHash(txtSenha.Text);

                loDAL.Atualizar(lo);

                Response.Write("<script>alert('Perfil alterado com sucesso!')</script>");

                //Response.Redirect("PerfilAdmC.aspx");
            }

            btnLoad_Click(null, null);
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Session.Remove("idlogin");
            Session.Remove("idprof");
            Session.Remove("nome");
            Session.Remove("email");
            Session.Remove("telefone");
            Session.Remove("descricao");
            Session.Remove("foto");
            Session.Remove("cpf");
            Response.Redirect("../ADMINISTRADOR/LoginAdm.aspx");
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            Image1.ImageUrl = pro.Foto;
            lblNome.Text = pro.Nome;
            lblEmail.Text = pro.Email;
            lblTelefone.Text = pro.Telefone;
            lblDescricao.Text = pro.Descricao;
            lblCpf.Text = pro.Cpf;
        }
    }
}