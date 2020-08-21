using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI.ADMINISTRADOR
{
    public partial class CertificadoAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] != null)
                {
                    if (Session["usuario"].ToString() != string.Empty)
                    {
                        Response.Write("<script>alert('Bem-vindo, " + Session["usuario"] + "')</script>");

                        /*adm.IdLogin = Convert.ToInt32(Session["idlogin"]);
                        adm.IdAdm = admDAL.AcharAdm(adm);

                        adm = admDAL.PreencherPeloID(adm);

                        Session.Add("idadm", adm.IdAdm);
                        Session.Add("nome", adm.Nome);
                        Session.Add("email", adm.Email);
                        Session.Add("foto", adm.Foto);*/
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