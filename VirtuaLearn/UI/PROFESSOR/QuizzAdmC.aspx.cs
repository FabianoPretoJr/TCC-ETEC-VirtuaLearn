using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI.PagAdmComun
{
    public partial class QuizzAdmC : System.Web.UI.Page
    {
        BLL.Quizz zz = new BLL.Quizz();
        DAL.QuizzDAL zzDAL = new DAL.QuizzDAL();
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
                        cu.IdProfessor = Convert.ToInt32(Session["idprof"]);
                        zz.IdProfessor = Convert.ToInt32(Session["idprof"]);

                        ddlCurso.DataSource = cuDAL.Listar1(cu);

                        ddlCurso.DataTextField = "Nome";
                        ddlCurso.DataValueField = "Id_Curso";

                        ddlCurso.DataBind();

                        gvQuizz.DataSource = zzDAL.Listar1(zz);
                        gvQuizz.DataBind();

                        if (Request.QueryString["id"] != null)
                        {
                            if (Request.QueryString["id"].ToString() != "")
                            {
                                int idRecebido;
                                int.TryParse(Request.QueryString["id"], out idRecebido);

                                zz.IdQuizz = idRecebido;
                                zz = zzDAL.PreencherPeloID(zz);

                                if (zz.IdQuizz != 0)
                                {
                                    //mudar visibilidade
                                    lblAtu.Visible = true;
                                    lblCad.Visible = false;
                                    lblId.Visible = true;
                                    lblIsso.Visible = true;
                                    ddlCurso.Visible = false;
                                    btnEnviar.Visible = false;
                                    btnAtualizar.Visible = true;
                                    gvQuizz.Visible = false;
                                    txtFiltro.Visible = false;
                                    btnFiltrar.Visible = false;

                                    lblId.Text = zz.IdQuizz.ToString();
                                    lblIdC.Text = zz.IdCurso.ToString();
                                    txtNome.Text = zz.Nome;
                                }
                                else
                                {
                                    lblId.Text = "ID INVÁLIDO";
                                }
                            }
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

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            zz.Nome = txtNome.Text;
            zz.IdCurso = Convert.ToInt32(ddlCurso.SelectedValue);
            zz.IdProfessor = Convert.ToInt32(Session["idprof"]);
            zz.IdAdm = 1;

            zzDAL.Cadastrar(zz);

            Response.Write("<script>alert('Quizz criado com sucesso!')</script>");
            btnFiltrar_Click(null, null);

            txtNome.Text = "";
            //ddlCurso.SelectedValue = 1;
            txtNome.Focus();
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            zz.Nome = txtNome.Text;
            zz.IdQuizz = Convert.ToInt32(lblId.Text);
            zz.IdProfessor = Convert.ToInt32(Session["idprof"]);
            zz.IdCurso = Convert.ToInt32(lblIdC.Text); 
            zz.IdAdm = 1;

            zzDAL.Atualizar(zz);

            Response.Write("<script>alert('Quizz atualizado com sucesso!')</script>");
            btnFiltrar_Click(null, null);

            txtNome.Text = "";
            //ddlCurso.SelectedValue = 1;
            txtNome.Focus();

            lblAtu.Visible = false;
            lblCad.Visible = true;
            lblId.Visible = false;
            lblIsso.Visible = false;
            ddlCurso.Visible = true;
            btnEnviar.Visible = true;
            btnAtualizar.Visible = false;
            gvQuizz.Visible = true;
            txtFiltro.Visible = true;
            btnFiltrar.Visible = true;
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            zz.Nome = txtFiltro.Text;
            zz.IdProfessor = Convert.ToInt32(Session["idprof"]);
            gvQuizz.DataSource = zzDAL.Listar(zz);
            gvQuizz.DataBind();

            txtFiltro.Text = "";
        }

        protected void btnIndex_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("PagAdmComum.aspx");
        }

        protected void gvQuizz_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            zz.IdQuizz = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "cmdExcluir")
            {
                zzDAL.Excluir(zz);
                Response.Write("<script>Alert('Quizz excluido com sucesso!')</script>");

                btnFiltrar_Click(null, null);
            }
            else if (e.CommandName == "cmdAdicionar")
            {
                Response.Redirect("QuizzPerguntasC.aspx?id=" + zz.IdQuizz);
            }
            else if(e.CommandName == "cmdAtualizar")
            {
                Response.Redirect("QuizzAdmC.aspx?id=" + zz.IdQuizz);
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