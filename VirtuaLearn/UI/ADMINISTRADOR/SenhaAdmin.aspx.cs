using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI.ADMINISTRADOR
{
    public partial class SenhaAdmin : System.Web.UI.Page
    {
        BLL.Aluno alu = new BLL.Aluno();
        DAL.AlunoDAL aluDAL = new DAL.AlunoDAL();
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

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            lo.Usuario = txtFiltro.Text;
            lo.Tipo = 1;
            lo = loDAL.PreencherPeloID1(lo);

            lblId.Text = lo.IdLogin.ToString();

            lblUsuario.Text = lo.Usuario;

            alu.IdLogin = lo.IdLogin;

            alu = aluDAL.PreencherPeloID(alu);

            lblCpf.Text = alu.Cpf;

            lblUsuario.Visible = true;
            lblCpf.Visible = true;
            txtSenha.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            btnRecuperar.Visible = true;
            txtFiltro.Visible = false;
            btnFiltrar.Visible = false;
            btnCancelar.Visible = true;
        }

        protected void btnIndex_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("PagAdmin.aspx");
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

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            lo.IdLogin = Convert.ToInt32(lblId.Text);
            lo.Senha = BLL.Criptografia.getMdIHash(txtSenha.Text);

            loDAL.Atualizar1(lo);

            Response.Write("<script>alert('Senha atualizada com sucesso!')</script>");

            txtFiltro.Text = "";

            lblUsuario.Visible = false;
            lblCpf.Visible = false;
            txtSenha.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            btnRecuperar.Visible = false;
            txtFiltro.Visible = true;
            btnFiltrar.Visible = true;
            btnCancelar.Visible = false;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = "";

            lblUsuario.Visible = false;
            lblCpf.Visible = false;
            txtSenha.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            btnRecuperar.Visible = false;
            txtFiltro.Visible = true;
            btnFiltrar.Visible = true;
            btnCancelar.Visible = false;
        }
    }
}