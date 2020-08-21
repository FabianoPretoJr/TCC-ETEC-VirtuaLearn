using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace VirtuaLearn.UI
{
    public partial class TermosAdmin : System.Web.UI.Page
    {
        BLL.Termos te = new BLL.Termos();
        DAL.TermosDAL teDAL = new DAL.TermosDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] != null)
                {
                    if (Session["usuario"].ToString() != string.Empty)
                    {

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
            if (fulTermos.PostedFile.ContentLength < 1000000) // Menor que 10MB (625000 megabyte)
            {
                try
                {
                    if (fulTermos.HasFile)//Verifica se algum arquivo foi selecionado
                    {
                        try
                        {
                            //Aqui ele vai filtrar pelo tipo de arquivo
                            if (fulTermos.PostedFile.ContentType == "application/pdf")
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
                                            hpf.SaveAs(Server.MapPath("~/UI/termosdeuso/") + filename + "_" + i + extensao);

                                            te.TermosUso = "/UI/termosdeuso/" + filename + "_" + i + extensao;

                                            teDAL.Cadastrar(te);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    lblMensagem.Text = "Erro: " + ex.Message;
                                }
                                // Mensagem se tudo ocorreu bem
                                Response.Write("<script>alert('Termos upados com sucesso!')</script>");
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
                lblMensagem.Text = "Não é permitido carregar arquivo PDF maior que 10 MB";
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