using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI
{
    public partial class Cursos1 : System.Web.UI.Page
    {
        DAL.CursoDAL cuDAL = new DAL.CursoDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string html = "";
            int qtd = 0;
            System.Data.DataTable dt = cuDAL.Listar();
            html += "<table style='width: 100 % '><tr>";

            //Laço para Rodar todas as linhas que retornam da select do BD
            for (int lin = 0; lin < dt.Rows.Count; lin++)
            {
                if (qtd == 3)
                {
                    html += "<tr>";
                    qtd = 0;
                }

                html += "<td style='width: 100%'>";
                html += "<div class='container'>";
                html += "<div class='card'>";
                html += "<div class='face face1'>";
                html += "<div class='content'>";
                html += "<img src='" + dt.Rows[lin].ItemArray[1].ToString() + "' />"; //imagem
                html += "<h3>" + dt.Rows[lin].ItemArray[2].ToString() + " </h3>"; //nome
                html += "<h5><br/>R$" + dt.Rows[lin].ItemArray[3].ToString().Replace(",0000", "") + ",00</h5>"; //valor
                html += "</div>";
                html += "</div>";
                html += "<div class='face face2'>";
                html += "<div class='content'>";
                html += "<p>(" + dt.Rows[lin].ItemArray[4].ToString() + "h)"; //horas
                html += "<br/>" + dt.Rows[lin].ItemArray[5].ToString() + "</ p >"; //descrição
                html += "<br/><center><a href='Carrinho.aspx?id='" + dt.Rows[lin].ItemArray[0].ToString() + ">Comprar</center></a>";
                html += "</div>";
                html += "</div>";
                html += "</div>";
                html += "</div>";
                html += "</td>"; 
                qtd++;

                if (qtd == 3)
                {
                    html += "</tr>";
                }
            }

            html += "</tr></table>";

            litConteudo.Text = html;
        }

        /*<div class="card">
             <div class="face face1">
                     <div class="content">
                         <img src = "img/hand.png" />

                         < h3 > TÉCNICAS DE NEGOCIAÇÃO</h3>

                         <h5><br/>R$ 80,00</h5>
                     </div>
                 </div>
                 <div class="face face2">
                     <div class="content">

                         <p>(20h)<br/>Neste curso você verá as técnicas mais adequadas para empregar em processos de negociação, 
                                     de tal forma que potencialize suas chances de sucesso.
                 </p>
                 <a href = "#" > Comprar </ a >

                     </ div >

                 </ div >

             </ div >*/

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
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