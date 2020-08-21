using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI.USUARIO
{
    public partial class Certificado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] != null)
                {
                    if (Session["usuario"].ToString() != string.Empty)
                    {
                        /*Response.Write("<script>alert('Bem-vindo, " + Session["usuario"] + "')</script>");

                        adm.IdLogin = Convert.ToInt32(Session["idlogin"]);
                        adm.IdAdm = admDAL.AcharAdm(adm);

                        adm = admDAL.PreencherPeloID(adm);

                        Session.Add("idadm", adm.IdAdm);
                        Session.Add("nome", adm.Nome);
                        Session.Add("email", adm.Email);
                        Session.Add("foto", adm.Foto);*/
                    }
                    else
                    {
                        Response.Redirect("../EXTERNO/Login.aspx");
                    }
                }
                else
                {
                    Response.Redirect("../EXTERNO/Login.aspx");
                }
            }
        }
    }
}