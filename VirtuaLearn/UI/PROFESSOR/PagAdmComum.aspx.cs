using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI.PROFESSOR
{
    public partial class PagAdmComum : System.Web.UI.Page
    {
        BLL.Login lo = new BLL.Login();
        DAL.LoginDAL loDAL = new DAL.LoginDAL();
        BLL.Professor pro = new BLL.Professor();
        DAL.ProfessorDAL proDAL = new DAL.ProfessorDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] != null)
                {
                    if (Session["usuario"].ToString() != string.Empty)
                    {
                        Response.Write("<script>alert('Bem-vindo, " + Session["usuario"] + "')</script>");

                        pro.IdLogin = Convert.ToInt32(Session["idlogin"]);
                        pro.IdProfessor = proDAL.AcharProf(pro);

                        pro = proDAL.PreencherPeloID(pro);

                        Session.Add("idprof", pro.IdProfessor);
                        Session.Add("nome", pro.Nome);
                        Session.Add("email", pro.Email);
                        Session.Add("telefone", pro.Telefone);
                        Session.Add("descricao", pro.Descricao);
                        Session.Add("foto", pro.Foto);
                        Session.Add("cpf", pro.Cpf);
                        //se precisar faz para idlogin
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

        protected void btnIndex_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("PagAdmComum.aspx");
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