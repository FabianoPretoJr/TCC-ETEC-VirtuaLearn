using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace VirtuaLearn.UI.PROFESSOR
{
    public partial class CursoAdmC : System.Web.UI.Page
    {
        DAL.CursoDAL cuDAL = new DAL.CursoDAL();
        BLL.Curso cu = new BLL.Curso();

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
                        cu.IdProfessor = Convert.ToInt32(Session["idprof"]);

                        gvResultado.DataSource = cuDAL.Listar1(cu);
                        gvResultado.DataBind();                       

                        if (Request.QueryString["id"] != null)
                        {
                            if (Request.QueryString["id"].ToString() != "")
                            {
                                int idRecebido;
                                int.TryParse(Request.QueryString["id"], out idRecebido);

                                cu.IdCurso = idRecebido;
                                cu = cuDAL.PreencherPeloID(cu);

                                if (cu.IdCurso != 0)
                                {
                                    /*btnAtualizar.Enabled = true;
                                    btnEnviar.Enabled = false;
                                    fulImagens.Enabled = false;
                                    fulImagens1.Enabled = true;*/

                                    lblAtu.Visible = true;
                                    lblId.Visible = true;
                                    lblIsso.Visible = true;
                                    lblCad.Visible = false;
                                    Image1.Visible = true;
                                    btnAtualizar.Visible = true;
                                    btnEnviar.Visible = false;
                                    gvResultado.Visible = false;
                                    txtFiltro.Visible = false;
                                    btnFiltrar.Visible = false;

                                    Image1.ImageUrl = cu.Imagem;
                                    lblId.Text = cu.IdCurso.ToString();
                                    txtNome.Text = cu.Nome;
                                    txtValor.Text = cu.Valor.ToString();
                                    txtHoras.Text = cu.Horas;
                                    txtDescricao.Text = cu.Descricao;
                                    lblIdP.Text = Session["idprof"].ToString();
                                }
                                else
                                {
                                    lblId.Text = "ID INVÁLIDO";
                                }
                            }
                            else
                            {
                                lblId.Text = "ID INVÁLIDO";
                            }
                        }
                        else
                        {
                            lblId.Text = "ID INVÁLIDO";
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
            if (fulImagens.PostedFile.ContentLength < 625000) // Menor que 5MB (625000 megabyte)
            {
                try
                {
                    if (fulImagens.HasFile)//Verifica se algum arquivo foi selecionado
                    {
                        try
                        {
                            //Aqui ele vai filtrar pelo tipo de arquivo
                            if (fulImagens.PostedFile.ContentType == "image/jpeg" ||
                                fulImagens.PostedFile.ContentType == "image/png" ||
                                fulImagens.PostedFile.ContentType == "image/gif" ||
                                fulImagens.PostedFile.ContentType == "image/bmp")
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
                                            hpf.SaveAs(Server.MapPath("~/UI/imagens/") + filename + "_" + i + extensao);

                                            cu.Imagem = "/UI/imagens/" + filename + "_" + i + extensao;
                                            cu.Nome = txtNome.Text;
                                            cu.Valor = decimal.Parse(txtValor.Text);
                                            cu.Horas = txtHoras.Text;
                                            cu.Descricao = txtDescricao.Text;
                                            cu.IdProfessor = Convert.ToInt32(Session["idprof"]);
                                            cu.IdAdm = 1;

                                            cuDAL.Cadastrar(cu);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    lblMensagem.Text = "Erro: " + ex.Message;
                                }
                                // Mensagem se tudo ocorreu bem
                                Response.Write("<script>alert('Cadastro efetuado!')</script>");
                                btnFiltrar_Click(null, null);
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

            txtNome.Text = "";
            txtValor.Text = "";
            txtHoras.Text = "";
            txtDescricao.Text = "";
            txtNome.Focus();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            cu.Nome = txtFiltro.Text;
            cu.IdProfessor = Convert.ToInt32(Session["idprof"]);
            gvResultado.DataSource = cuDAL.Listar(cu);
            gvResultado.DataBind();

            txtFiltro.Text = "";
        }

        protected void gvResultado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            cu.IdCurso = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "cmdExcluir")
            {
                cuDAL.Excluir(cu);
                Response.Write("<script>Alert('Curso excluido com sucesso!')</script>");

                btnFiltrar_Click(null, null);
            }
            else if (e.CommandName == "cmdEditar")
            {
                Response.Redirect("CursoAdmC.aspx?id=" + cu.IdCurso);
            }
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (fulImagens.HasFile)
            {
                if (fulImagens.PostedFile.ContentLength < 625000) // Menor que 5MB (625000 megabyte)
                {
                    try
                    {
                        if (fulImagens.HasFile)//Verifica se algum arquivo foi selecionado
                        {
                            try
                            {
                                //Aqui ele vai filtrar pelo tipo de arquivo
                                if (fulImagens.PostedFile.ContentType == "image/jpeg" ||
                                    fulImagens.PostedFile.ContentType == "image/png" ||
                                    fulImagens.PostedFile.ContentType == "image/gif" ||
                                    fulImagens.PostedFile.ContentType == "image/bmp")
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
                                                hpf.SaveAs(Server.MapPath("~/UI/imagens/") + filename + "_" + i + extensao);

                                                cu.IdCurso = Convert.ToInt32(lblId.Text);
                                                cu.Imagem = "/UI/imagens/" + filename + "_" + i + extensao;
                                                cu.Nome = txtNome.Text;
                                                cu.Valor = decimal.Parse(txtValor.Text);
                                                cu.Horas = txtHoras.Text;
                                                cu.Descricao = txtDescricao.Text;
                                                cu.IdProfessor = Convert.ToInt32(lblIdP.Text);

                                                cuDAL.Atualizar(cu);
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        lblMensagem.Text = "Erro: " + ex.Message;
                                    }
                                    // Mensagem se tudo ocorreu bem                              
                                    Response.Redirect("CursoAdmC.aspx");
                                    btnFiltrar_Click(null, null);
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

                cu.IdCurso = Convert.ToInt32(lblId.Text);
                cu.Imagem = Image1.ImageUrl;
                cu.Nome = txtNome.Text;
                cu.Valor = decimal.Parse(txtValor.Text);
                cu.Horas = txtHoras.Text;
                cu.Descricao = txtDescricao.Text;
                cu.IdProfessor = Convert.ToInt32(lblIdP.Text);

                cuDAL.Atualizar(cu);
                Response.Redirect("CursoAdmC.aspx");
                btnFiltrar_Click(null, null);
            }
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
    }
}