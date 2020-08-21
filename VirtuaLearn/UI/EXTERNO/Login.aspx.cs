using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            BLL.Login lo = new BLL.Login();

            lo.Usuario = txtEmail.Text;
            lo.Senha = BLL.Criptografia.getMdIHash(txtSenha.Text);

            DAL.LoginDAL loginDAL = new DAL.LoginDAL();

            lo = loginDAL.Login(lo);

            if(lo.IdLogin == 0)
            {
                Response.Write("<script>alert('Login inválido')</script>");

                txtEmail.Text = "";
                txtSenha.Text = "";
                txtEmail.Focus();
            }
            else
            {
                Response.Write("<script>alert('Acesso permitido!')</script>");

                Session.Add("idlogin", lo.IdLogin);
                Session.Add("usuario", lo.Usuario);

                Response.Redirect("../USUARIO/Usuario.aspx");
            }
        
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx");
        }

        protected void btnEsqueceu_Click(object sender, EventArgs e)
        {

        }

        protected void btnIndex_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void btnIndex1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void btnCursos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cursos1.aspx");
        }

        protected void btnContato_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contato.aspx");
        }
    }
}