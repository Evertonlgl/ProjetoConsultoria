using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cadastro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btCadastrar_Click(object sender, EventArgs e)
    {

        Usuario user = new Usuario();


        user.Nome = txbNome.Text;
        user.Email = txbemail.Text;
        user.Cpf = Convert.ToInt64(tbxcpf.Text);
        user.Cidade = txbcidade.Text;
        user.Bairro = tbxbairro.Text;
        user.Numero = tbxnumeroc.Text;
        user.Rua = tbxbrua.Text;
        user.URF = ddlestado.Text;
        user.Telefone = Convert.ToInt32(tbxtel.Text);
        user.Celular = Convert.ToInt32(tbxcel.Text);

        if (tbxsenha.Text != tbxconfirma.Text)
        {
            Response.Write("<script language='javascript'>alert('senha ou diferente da confirmação!!');</script>");
        }

        user.Password = tbxconfirma.Text;

        //pagina pra testar aplicação do bootstrap web continuando o desenvolvimento de acordo com documentação

    }
}