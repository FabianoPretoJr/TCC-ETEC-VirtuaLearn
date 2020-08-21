using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI
{
    public partial class Usuario : System.Web.UI.Page
    {
        BLL.Curso cu = new BLL.Curso();
        DAL.CursoDAL cuDAL = new DAL.CursoDAL();

        BLL.Aluno alu = new BLL.Aluno();
        DAL.AlunoDAL aluDAL = new DAL.AlunoDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] != null)
                {
                    if (Session["usuario"].ToString() != string.Empty)
                    {
                        Response.Write("<script>alert('Bem-vindo, " + Session["usuario"] + "')</script>");

                        alu.IdLogin = Convert.ToInt32(Session["idlogin"]);
                        alu = aluDAL.PreencherPeloID(alu);

                        Session.Add("idaluno", alu.IdAluno);

                        string html = "";
                        int qtd = 0;
                        //pega o id do usuario e faz um listar por ele
                        System.Data.DataTable dt = cuDAL.Listar();
                        html += "<table style='width: 100 % '><tr>";

                        //Laço para Rodar todas as linhas que retornam da select do BD
                        for (int lin = 0; lin < dt.Rows.Count; lin++)
                        {
                            if (qtd == 4)
                            {
                                html += "<tr>";
                                qtd = 0;
                            }

                            html += "<td style='width: 100%'>";
                            //html += "<div class='container'>";



                            html += "<div class='card'>";
                            html += "<img class='card__image' src='" + dt.Rows[lin].ItemArray[1].ToString() + "'  alt='wave'/>"; //imagem
                            html += "<div class='card-title'>";
                            html += "<a href='#' class='toggle-info btn'>";
                            html += "<span class='left'></span>";
                            html += "<span class='right'></span>";
                            html += "</a><br/>";
                            html += "<h2>" + dt.Rows[lin].ItemArray[2].ToString(); //nome
                            html += "</h2>";
                            html += "</div>";
                            html += "<div class='card-flap flap1'>";
                            html += "<div class='card-description'>";
                            html += dt.Rows[lin].ItemArray[5].ToString(); //descrição
                            html += "</div>";
                            html += "<div class='card-flap flap2'>";
                            html += "<div class='card-actions'>";
                            html += "<a href = 'Cursos.aspx' class='btn'>Estudar</a>"; //fazer botão com id
                            html += "</div>";
                            html += "</div>";
                            html += "</div>";
                            html += "</div>";


                            //html += "</div>";
                            html += "</td>";
                            qtd++;

                            if (qtd == 4)
                            {
                                html += "</tr>";
                            }
                        }

                        html += "</tr></table>";

                        litCurso.Text = html;
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

        protected void btnCurso_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cursos.aspx");
        }
    }
}