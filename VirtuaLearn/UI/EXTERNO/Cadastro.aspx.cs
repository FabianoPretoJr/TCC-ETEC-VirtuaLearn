using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtuaLearn.UI
{
    public partial class Cadastro : System.Web.UI.Page
    {
        BLL.Login lo = new BLL.Login();
        DAL.LoginDAL loDAL = new DAL.LoginDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.Termos te = new BLL.Termos();
            DAL.TermosDAL teDAL = new DAL.TermosDAL();

            te.IdTermos = 2;

            te = teDAL.PreencherPeloID(te);
            string html = "";

            html += ("<a href='" + te.TermosUso + "' target='_blank'>&nbsp termos de uso e condições.</a>");

            litTermos.Text = html;
        }

        /*protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }*/

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            BLL.Aluno alu = new BLL.Aluno();

            lo.Usuario = txtUsuario.Text;
            lo.Senha = BLL.Criptografia.getMdIHash(txtSenha.Text);
            lo.Tipo = 1;



            alu.Nome = txtNome.Text;
            alu.Cpf = txtCpf.Text;
            alu.Rg = txtRg.Text;
            alu.Nascimento = DateTime.Parse(txtNasc.Text);
            alu.Cep = txtCep.Text;
            alu.Estado = DropDownList.SelectedValue;
            alu.Bairro = txtBairro.Text;
            alu.Cidade = txtCidade.Text;
            alu.RuaAv = txtRuaAv.Text;
            alu.Numero = txtNum.Text;
            alu.Email = txtEmail.Text;
            alu.Telefone = txtTelefone.Text;

            if(CheckBox1.Checked == true)
            {
                alu.IdLogin = loDAL.Cadastrar(lo);

                DAL.AlunoDAL aluDAL = new DAL.AlunoDAL();

                aluDAL.Cadastrar(alu);

                txtUsuario.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtSenha.Text = "";
                txtRg.Text = "";
                txtNasc.Text = "";
                txtCep.Text = "";
                DropDownList.SelectedIndex = 1;
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtRuaAv.Text = "";
                txtNum.Text = "";
                txtEmail.Text = "";
                txtTelefone.Text = "";
                txtNome.Focus();

                Response.Write("<script>alert('Cadastro efetuado!')</script>");
            }
            else
            {
                litAviso.Text = "Você deve concordar com termos para continuar!";
            }


            //btnLogin_Click(null, null);
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