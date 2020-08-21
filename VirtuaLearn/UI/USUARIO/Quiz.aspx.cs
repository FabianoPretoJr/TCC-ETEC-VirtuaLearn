using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI.USUARIO
{
    public partial class Quiz : System.Web.UI.Page
    {
        BLL.Quizz zz = new BLL.Quizz();
        DAL.QuizzDAL zzDAL = new DAL.QuizzDAL();
        BLL.Pergunta pe = new BLL.Pergunta();
        DAL.PerguntaDAL peDAL = new DAL.PerguntaDAL();
        BLL.RespostaUsu re = new BLL.RespostaUsu();
        DAL.RespostaUsuDAL reDAL = new DAL.RespostaUsuDAL();

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



                        zz.IdQuizz = 1002;

                        zz = zzDAL.PreencherPeloID(zz);

                        lblNome.Text = zz.Nome;

                        pe.IdQuizz = zz.IdQuizz;

                        pe = peDAL.PreencherPeloID2(pe);

                        lblQuestao.Text = pe.Questao;
                        lblRes1.Text = pe.Res1;
                        lblRes2.Text = pe.Res2;
                        lblRes3.Text = pe.Res3;
                        lblRes4.Text = pe.Res4;
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

        protected void btnProxima_Click(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {

            }
            else if(RadioButton2.Checked)
            {

            }
            else if (RadioButton3.Checked)
            {

            }
            else if (RadioButton4.Checked)
            {

            }
            else
            {

            }
        }
    }
}