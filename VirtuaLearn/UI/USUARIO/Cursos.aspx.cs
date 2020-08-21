using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI.USUARIO
{
    public partial class Cursos : System.Web.UI.Page
    {
        BLL.Aula au = new BLL.Aula();
        DAL.AulaDAL auDAL = new DAL.AulaDAL();

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



                        string html = "";
                        int qtd = 0;
                        //pega o id do usuario e faz um listar por ele
                        System.Data.DataTable dt = auDAL.Listar();
                        html += "<table style='width: 100 % '><tr>";

                        //Laço para Rodar todas as linhas que retornam da select do BD
                        for (int lin = 0; lin < dt.Rows.Count; lin++)
                        {
                            if (qtd == 1)
                            {
                                html += "<tr>";
                                qtd = 0;
                            }

                            html += "<td style='width: 100%'>";
                            //html += "<div class='container'>";



                            html += "<div class='row align-content-center'>";
                            html += "<div class='col-md-2'>";
                            html += "</div>";
                            html += "<div class='col-md-12'>";
                            html += "<div class='card3'>";
                            html += "<div id='main'>";
                            html += "<h3>" + dt.Rows[lin].ItemArray[1].ToString() + "<span class='badge badge-secondary'></span></h3>"; //nome da aula
                            html += "<br/>";
                            html += "<div class='accordion' id='faq'>";
                            html += "<div class='cartt'>";
                            html += "<div class='cartt-cab' id='faqhead1'>";
                            html += "<a href='#' class='btnn btnn-cab-linkedd' data-toggle='collapse' data-target='#faq1'";
                            html += "aria-expanded='true' aria-controls='faq1'>Material de Apoio</a>";
                            html += "</div>";
                            html += "<div id='faq1' class='collapse show' aria-labelledby='faqhead1' data-parent='#faq'>";
                            html += "<div class='cartt-body'>";
                            html += "<br/>";
                            html += "<br/>";
                            html += "<div class='cardTransf-container'>";
                            html += "<div class='cardTransf'>";
                            html += "<div class='front'>";
                            html += "<span class='fa fa-book'></span>";
                            html += "</div>";
                            html += "<div class='back'><a href='" + dt.Rows[lin].ItemArray[3].ToString() + "' target='_blank'>Baixar</a></div>";
                            html += "</div>";
                            html += "</div>";
                            html += "<br/>";
                            html += "<br/>";
                            html += "</div>";
                            html += "</div>";
                            html += "</div>";
                            html += "<div class='cartt'>";
                            html += "<div class='cartt -header' id='faqhead2'>";
                            html += "<a href='#' class='btnn btnn-cab-linkedd collapsed' data-toggle='collapse' data-target='#faq2'";
                            html += "aria-expanded='true' aria-controls='faq2'>Vídeo Aula</a>";
                            html += "</div>";
                            html += "<div id='faq2' class='collapse' aria-labelledby='faqhead2' data-parent='#faq'>";
                            html += "<div class='cartt -body'>";
                            html += "<br/>";
                            html += "<br/>";
                            html += "<div class='cardTransf-container'>";
                            html += "<div class='cardTransf'>";
                            html += "<div class='front'>";
                            html += "<span class='fa fa-film'></span>";
                            html += "</div>";
                            html += "<div class='back'><a title='UpInside Tecnologia' href='" + dt.Rows[lin].ItemArray[2].ToString() + "' target='_blank' rel='shadowbox; width=600; height=540;'>assistir</a></div>";
                            html += "</div>";
                            html += "</div>";
                            html += "<br/>";
                            html += "<br/>";
                            html += "</div>";
                            html += "</div>";
                            html += "</div>";
                            html += "</div>";
                            html += "</div>";
                            html += "</div>";
                            html += "</div>";
                            html += "<div class='col -md-2'>";
                            html += "</div>";
                            html += "</div>";
                            html += "<br/>";
                            html += "<br/>";
                            html += "<br/>";



                            //html += "</div>";
                            html += "</td>";
                            qtd++;

                            if (qtd == 1)
                            {
                                html += "</tr>";
                            }
                        }

                        html += "</tr></table>";

                        litAula.Text = html;
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




        //dt.Rows[lin].ItemArray[5].ToString();


        /*<div class="row align-content-center">
    <div class="col-md-2">
    </div>
    <div class="col-md-12">
        <div class="card3">
            <div id = "main" >

                < h3 > Curso < span class="badge badge-secondary"></span></h3>
                <br />
                <div class="accordion" id="faq">
                    <div class="cartt">
                        <div class="cartt-cab" id="faqhead1">
                            <a href = "#" class="btnn btnn-cab-linkedd" data-toggle="collapse" data-target="#faq1"
                                aria-expanded="true" aria-controls="faq1">Material de Apoio</a>
                        </div>

                        <div id = "faq1" class="collapse show" aria-labelledby="faqhead1" data-parent="#faq">
                            <div class="cartt-body">
                                <br />
                                <br />
                                <div class="cardTransf-container">
                                    <div class="cardTransf">
                                        <div class="front">
                                            <span class="fa fa-book"></span>
                                        </div>
                                        <div class="back"><a href = "#" > Baixar </ a ></ div >

                                    </ div >
                                </ div >
                                < br />
                                < br />

                            </ div >
                        </ div >
                    </ div >
                    < div class="cartt">
                        <div class="cartt-header" id="faqhead2">
                            <a href = "#" class="btnn btnn-cab-linkedd collapsed" data-toggle="collapse" data-target="#faq2"
                                aria-expanded="true" aria-controls="faq2">Vídeo Aula</a>
                        </div>

                        <div id = "faq2" class="collapse" aria-labelledby="faqhead2" data-parent="#faq">
                            <div class="cartt-body">
                                <br />
                                <br />
                                <div class="cardTransf-container">
                                    <div class="cardTransf">
                                        <div class="front">
                                            <span class="fa fa-film"></span>
                                        </div>
                                        <div class="back"><a title = "UpInside Tecnologia" href="https://www.youtube.com/embed/CvBfHwUxHIk?rel=0&amp;showinfo=0" rel="shadowbox; width=600; height=540;">assistir</a></div>

                                    </div>
                                </div>
                                <br />
                                <br />
                            </div>
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>
    <div class="col-md-2">
    </div>
</div>
<br />
<br />
<br />*/
    }
}