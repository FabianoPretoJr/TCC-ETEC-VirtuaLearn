using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI
{
    public partial class LoginAdm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            BLL.Login lo = new BLL.Login();

            lo.Usuario = txtNome.Text;
            lo.Senha = BLL.Criptografia.getMdIHash(txtSenha.Text);

            DAL.LoginDAL loDAL = new DAL.LoginDAL();

            lo = loDAL.Login(lo);

            if (lo.IdLogin == 0)
            {
                Response.Write("<script>alert('Login inválido')</script>");

                txtNome.Text = "";
                txtSenha.Text = "";
                txtNome.Focus();
            }
            else
            {
                //Response.Write("<script>alert('Acesso permitido!')</script>");
                //NÃO APARECE O ALERT

                if(lo.Tipo == 3)
                {
                    Session.Add("idlogin", lo.IdLogin);
                    Session.Add("usuario", lo.Usuario);

                    Response.Redirect("PagAdmin.aspx");
                }
                else if(lo.Tipo == 2)
                {
                    Session.Add("idlogin", lo.IdLogin);
                    Session.Add("usuario", lo.Usuario);

                    Response.Redirect("../PROFESSOR/PagAdmComum.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Login inválido')</script>");

                    txtNome.Text = "";
                    txtSenha.Text = "";
                    txtNome.Focus();
                }
            }
        }

    }
}