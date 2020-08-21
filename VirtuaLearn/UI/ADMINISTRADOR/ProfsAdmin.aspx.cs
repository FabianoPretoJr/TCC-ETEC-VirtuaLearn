using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI
{
    public partial class ProfsAdmin : System.Web.UI.Page
    {
        BLL.Professor pro = new BLL.Professor();
        BLL.Login lo = new BLL.Login();
        DAL.ProfessorDAL proDAL = new DAL.ProfessorDAL();
        DAL.LoginDAL loDAL = new DAL.LoginDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] != null)
                {
                    if (Session["usuario"].ToString() != string.Empty)
                    {
                        gvProf.DataSource = proDAL.Listar();
                        gvProf.DataBind();
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

        protected void gvProf_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            pro.IdProfessor = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "cmdExcluir")
            {
                proDAL.Excluir(pro);
                Response.Write("<script>Alert('Curso excluido com sucesso!')</script>");

                btnFiltrar_Click(null, null);
            }
            /*else if (e.CommandName == "cmdEditar")
            {
                Response.Redirect("ProfsAdmin.aspx?id=" + pro.IdProfessor);
            }*/
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            pro.Nome = txtFiltro.Text;
            gvProf.DataSource = proDAL.Listar(pro);
            gvProf.DataBind();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            lo.Usuario = txtUsuario.Text;
            lo.Senha = BLL.Criptografia.getMdIHash(txtSenha.Text);
            lo.Tipo = 2;

            pro.IdLogin = loDAL.Cadastrar(lo);


            pro.Nome = txtNome.Text;
            pro.Email = txtEmail.Text;
            pro.Telefone = txtTelefone.Text;
            pro.Foto = "."; //FIZ UMA PUTA GAMBIARRA
            pro.Cpf = txtCpf.Text;
            pro.Descricao = txtDescricao.Text;

            proDAL.Cadastrar(pro);

            btnFiltrar_Click(null, null);
            Response.Write("<script>alert('Cadastrado com sucesso!')</script>");

            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtCpf.Text = "";
            txtDescricao.Text = "";
            txtSenha.Text = "";
            txtUsuario.Text = "";

            txtNome.Focus();
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