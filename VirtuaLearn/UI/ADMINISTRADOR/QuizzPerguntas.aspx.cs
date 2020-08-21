using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI
{
    public partial class QuizzPerguntas : System.Web.UI.Page
    {
        BLL.Pergunta pe = new BLL.Pergunta();
        DAL.PerguntaDAL peDAL = new DAL.PerguntaDAL();
        BLL.Quizz zz = new BLL.Quizz();
        DAL.QuizzDAL zzDAL = new DAL.QuizzDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] != null)
                {
                    if (Session["usuario"].ToString() != string.Empty)
                    {
                        gvQuestoes.DataSource = peDAL.Listar();
                        gvQuestoes.DataBind();

                        if (Request.QueryString["id"] != null)
                        {
                            if (Request.QueryString["id"].ToString() != "")
                            {
                                int idRecebido;
                                int.TryParse(Request.QueryString["id"], out idRecebido);

                                pe.IdQuizz = idRecebido;
                                gvQuestoes.DataSource = peDAL.Listar3(pe);
                                gvQuestoes.DataBind();

                                lblIdQ.Text = pe.IdQuizz.ToString();

                                if (Request.QueryString["idp"] != null)
                                {
                                    if (Request.QueryString["idp"].ToString() != "")
                                    {
                                        int idRecebido1;
                                        int.TryParse(Request.QueryString["idp"], out idRecebido1);

                                        pe.IdPergunta = idRecebido1;
                                        pe = peDAL.PreencherPeloID1(pe);

                                        if (pe.IdPergunta != 0)
                                        {
                                            lblAtu.Visible = true;
                                            lblCad.Visible = false;
                                            btnAtualizar.Visible = true;
                                            btnEnviar.Visible = false;
                                            btnVoltar.Visible = false;
                                            lblPer.Visible = true;
                                            gvQuestoes.Visible = false;
                                            txtFiltro.Visible = false;
                                            btnFiltrar.Visible = false;

                                            lblIdQ.Text = pe.IdQuizz.ToString();
                                            lblPer.Text = pe.IdPergunta.ToString();
                                            txtPergunta.Text = pe.Questao;
                                            txtRes1.Text = pe.Res1;
                                            txtRes2.Text = pe.Res2;
                                            txtRes3.Text = pe.Res3;
                                            txtRes4.Text = pe.Res4;
                                            ddlCerta.SelectedValue = pe.Certa;
                                        }
                                        /*else
                                        {
                                            lblCurso.Text = "CURSO INVÁLIDO";
                                        }*/
                                    }
                                    /*else
                                    {
                                        lblCurso.Text = "CURSO INVÁLIDO"; //FAZRER ESQUEMA PARA CARREGAR CODIGO DE ERRO NO ID E EXIBIR NO LOAD
                                    }*/
                                }
                                /*else
                                {
                                    lblCurso.Text = "CURSO INVÁLIDO";
                                }*/
                            }
                            // <<<<<<<<<<<<<<TALVEZ REDIRECIONAR DE VOLTA A QUIZZ>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        }
                        else
                        {
                            //lblCurso.Text = "CURSO INVÁLIDO";
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

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            pe.Questao = txtPergunta.Text;
            pe.Res1 = txtRes1.Text;
            pe.Res2 = txtRes2.Text;
            pe.Res3 = txtRes3.Text;
            pe.Res4 = txtRes4.Text;
            pe.Certa = ddlCerta.SelectedValue;
            pe.IdQuizz = Convert.ToInt32(lblIdQ.Text);
            pe.IdAdm = 1;
            peDAL.Cadastrar1(pe);

            Response.Write("<script>alert('Questão adicinada com sucesso!')</script>");
            btnFiltrar_Click(null, null);




            txtPergunta.Text = "";
            txtRes1.Text = "";
            txtRes2.Text = "";
            txtRes3.Text = "";
            txtRes4.Text = "";
            //ddlCerta.SelectedValue = "";
            txtPergunta.Focus();
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("QuizzAdmin.aspx");
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            pe.Questao = txtFiltro.Text;
            pe.IdQuizz = Convert.ToInt32(lblIdQ.Text);
            gvQuestoes.DataSource = peDAL.Listar2(pe);
            gvQuestoes.DataBind();

            txtFiltro.Text = "";
        }

        protected void btnIndex_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("QuizzPerguntas.aspx");
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

        protected void gvResultado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            pe.IdPergunta = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "cmdExcluir")
            {
                peDAL.Excluir(pe);
                Response.Write("<script>Alert('Pergunta excluida com sucesso!')</script>");

                btnFiltrar_Click(null, null);
            }
            else if (e.CommandName == "cmdEditar")
            {
                Response.Redirect("QuizzPerguntas.aspx?id=" + lblIdQ.Text + "&idp=" + pe.IdPergunta);
            }
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            pe.IdPergunta = Convert.ToInt32(lblPer.Text);
            pe.Questao = txtPergunta.Text;
            pe.Res1 = txtRes1.Text;
            pe.Res2 = txtRes2.Text;
            pe.Res3 = txtRes3.Text;
            pe.Res4 = txtRes4.Text;
            pe.Certa = ddlCerta.SelectedValue;
            pe.IdQuizz = Convert.ToInt32(lblIdQ.Text);
            pe.IdAdm = 1;

            peDAL.Atualizar(pe);

            Response.Write("<script>alert('Questão adicinada com sucesso!')</script>");
            btnFiltrar_Click(null, null);

            txtPergunta.Text = "";
            txtRes1.Text = "";
            txtRes2.Text = "";
            txtRes3.Text = "";
            txtRes4.Text = "";
            //ddlCerta.SelectedValue = "";
            txtPergunta.Focus();

            lblAtu.Visible = false;
            lblCad.Visible = true;
            btnAtualizar.Visible = false;
            btnEnviar.Visible = true;
            btnVoltar.Visible = true;
            lblPer.Visible = false;
            gvQuestoes.Visible = true;
            txtFiltro.Visible = true;
            btnFiltrar.Visible = true;
        }
    }
}
