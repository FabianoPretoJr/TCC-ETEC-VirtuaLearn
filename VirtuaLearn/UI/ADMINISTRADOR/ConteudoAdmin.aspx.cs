using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;

namespace VirtuaLearn.UI
{
    public partial class ConteudoAdmin : System.Web.UI.Page
    {
        BLL.Aula au = new BLL.Aula();
        DAL.AulaDAL auDAL = new DAL.AulaDAL();

        BLL.Curso cu = new BLL.Curso();
        DAL.CursoDAL cuDAL = new DAL.CursoDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] != null)
                {
                    if (Session["usuario"].ToString() != string.Empty)
                    {
                        ddlCurso.DataSource = cuDAL.Listar();

                        ddlCurso.DataTextField = "Nome";
                        ddlCurso.DataValueField = "Id_Curso";

                        ddlCurso.DataBind();

                        gvResultado.DataSource = auDAL.Listar();
                        gvResultado.DataBind();
                        if (Request.QueryString["id"] != null)
                        {
                            if (Request.QueryString["id"].ToString() != "")
                            {
                                int idRecebido;
                                int.TryParse(Request.QueryString["id"], out idRecebido);

                                au.IdAula = idRecebido;
                                au = auDAL.PreencherPeloID1(au);

                                if (au.IdAula != 0)
                                {
                                    lblAtu.Visible = true;
                                    lblId.Visible = true;
                                    lblIsso.Visible = true;
                                    lblCad.Visible = false;
                                    litPDF.Visible = true;
                                    btnAtualizar.Visible = true;
                                    ddlCurso.Visible = false;
                                    btnCadastrar.Visible = false;
                                    gvResultado.Visible = false;
                                    txtFiltro.Visible = false;
                                    btnFiltrar.Visible = false;
                                    ////////////////////////////////////////////////////////////////////////////////////////

                                    //Apresentar o PDF

                                    string html = "";

                                    html += "<a href='" + au.Material + "' target='_blank'>Material</a>";


                                    litPDF.Text = html;
                                    ///////////////////////////////////////////////////////////////////////////////////////
                                    lblId.Text = au.IdAula.ToString();
                                    txtNome.Text = au.Nome;
                                    txtVideo.Text = au.Video;
                                    txtDescricao.Text = au.Descricao;
                                    lblId1.Text = au.IdCurso.ToString();
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
                    }
                    else
                    {
                        Response.Redirect("LoginAdm.aspx");
                    }
                }
                else
                {
                    Response.Redirect("LoginAdm.aspx");
                }
            }
        }

        protected void btnIndex_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("PagAdmin.aspx");
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (fulMaterial.PostedFile.ContentLength < 1000000) // Menor que 5MB (625000 megabyte)
            {
                try
                {
                    if (fulMaterial.HasFile)//Verifica se algum arquivo foi selecionado
                    {
                        try
                        {
                            //Aqui ele vai filtrar pelo tipo de arquivo
                            if (fulMaterial.PostedFile.ContentType == "application/pdf")
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
                                            hpf.SaveAs(Server.MapPath("~/UI/material/") + filename + "_" + i + extensao);



                                            au.Nome = txtNome.Text;
                                            string vid = txtVideo.Text.Replace("watch?v=", "embed/");

                                            au.Video = vid + "?rel=0&showinfo=0";

                                            au.Material = "/UI/material/" + filename + "_" + i + extensao;
                                            au.Descricao = txtDescricao.Text;
                                            au.IdCurso = Convert.ToInt32(ddlCurso.SelectedValue);
                                            au.IdAdm = 1;
                                             
                                            cu.IdCurso = au.IdCurso;

                                            cu = cuDAL.AcharCurso(cu);

                                            if(cu.IdProfessor != 0)
                                            {
                                                au.IdProfessor = cu.IdProfessor;

                                                auDAL.Cadastrar(au);
                                            }
                                            else
                                            {
                                                auDAL.Cadastrar1(au);
                                            }

                                            
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
                                lblMensagem.Text = "É permitido carregar apenas arquivo PDF!";
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
                lblMensagem.Text = "Não é permitido carregar arquivo PDF maior que 3 MB";
            }

            txtNome.Text = "";
            txtVideo.Text = "";
            txtDescricao.Text = "";
            //ddlCurso.SelectedIndex = 1;
            txtNome.Focus();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            au.Nome = txtFiltro.Text;
            gvResultado.DataSource = auDAL.Listar2(au);
            gvResultado.DataBind();

            txtFiltro.Text = "";
        }

        protected void gvResultado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            au.IdAula = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "cmdExcluir")
            {
                auDAL.Excluir(au);
                Response.Write("<script>Alert('Curso excluido com sucesso!')</script>");

                btnFiltrar_Click(null, null);
            }
            else if (e.CommandName == "cmdEditar")
            {
                Response.Redirect("ConteudoAdmin.aspx?id=" + au.IdAula);
            }
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (fulMaterial.HasFile)
            {
                if (fulMaterial.PostedFile.ContentLength < 1000000) // Menor que 5MB (625000 megabyte)
                {
                    try
                    {
                        if (fulMaterial.HasFile)//Verifica se algum arquivo foi selecionado
                        {
                            try
                            {
                                //Aqui ele vai filtrar pelo tipo de arquivo
                                if (fulMaterial.PostedFile.ContentType == "application/pdf")
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
                                                hpf.SaveAs(Server.MapPath("~/UI/material/") + filename + "_" + i + extensao);

                                                au.IdAula = Convert.ToInt32(lblId.Text);
                                                au.Nome = txtNome.Text;
                                                string vid = txtVideo.Text.Replace("watch?v=", "embed/");

                                                au.Video = vid + "?rel=0&showinfo=0";

                                                au.Material = "/UI/material/" + filename + "_" + i + extensao;
                                                au.Descricao = txtDescricao.Text;
                                                au.IdCurso = Convert.ToInt32(lblId1.Text);
                                                au.IdAdm = 1;

                                                auDAL.Atualizar(au);
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        lblMensagem.Text = "Erro: " + ex.Message;
                                    }
                                    // Mensagem se tudo ocorreu bem                              
                                    Response.Redirect("ConteudoAdmin.aspx");
                                    btnFiltrar_Click(null, null);
                                }
                                else
                                {
                                    // Mensagem notifica que é permitido carregar apenas 
                                    // as imagens definida la em cima.
                                    lblMensagem.Text = "É permitido carregar apenas arquivos PDF!";
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
                    lblMensagem.Text = "Não é permitido carregar arquivo PDF maior que 3 MB";
                }
            }
            else
            {
                au.IdAula = Convert.ToInt32(lblId.Text);
                au.Nome = txtNome.Text;
                string vid = txtVideo.Text.Replace("watch?v=", "embed/");

                au.Video = vid + "?rel=0&showinfo=0";

                au.Material = litPDF.Text.Replace("<a href='", "").Replace("' target='_blank'>Material</a>", "");
                au.Descricao = txtDescricao.Text;
                au.IdCurso = Convert.ToInt32(lblId1.Text);
                au.IdAdm = 1;

                auDAL.Atualizar(au);
                Response.Redirect("ConteudoAdmin.aspx");
                btnFiltrar_Click(null, null);
            }
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Session.Remove("idlogin");
            Session.Remove("idadm");
            Session.Remove("nome");
            Session.Remove("email");
            Session.Remove("foto");
            Response.Redirect("LoginAdm.aspx");
        }
    }
}
