using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI
{
    public partial class FaleConosco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            BLL.Contato cont = new BLL.Contato();

            cont.Nome = txtNome.Text;
            cont.Sobrenome = txtSobrenome.Text;
            cont.Email = txtEmail.Text;
            cont.Duvida = txtDuvida.Text;

            DAL.ContatoDAL contDAL = new DAL.ContatoDAL();

            contDAL.Cadastrar(cont);

            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtEmail.Text = "";
            txtDuvida.Text = ""; 
            txtNome.Focus();

            Response.Write("<script>alert('Dúvida enviada com sucesso!')</script>");
        }

        /*protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }*/

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