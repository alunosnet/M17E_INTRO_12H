using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_INTRO_12H
{
    public partial class index : System.Web.UI.Page
    {
        // SEMPRE Executado
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar se existe o parâmetro erro na url
            //http://localhost:56677/index.aspx?erro=qq
            if (Request.QueryString["erro"] != null)
                Response.Write("<script>alert('erro');</script>");
            if (!IsPostBack)
            {
                // Só para a primeira vez que a página é pedida
                tb_x.Text = "0";
                tb_y.Text = "0";
            }
        }

        protected void bt_soma_Click(object sender, EventArgs e)
        {
            int x, y;
            x = int.Parse(tb_x.Text);
            y = int.Parse(tb_y.Text);
            lb_resultado.Text = (x + y).ToString();
        }

        protected void bt_redirect_Click(object sender, EventArgs e)
        {
            int x, y;
            x = int.Parse(tb_x.Text);
            y = int.Parse(tb_y.Text);
            int resultado = x + y;
            string url = "resultado.aspx?resultado=" + resultado.ToString();
            Response.Redirect(url);
        }

        protected void bt_cookie_Click(object sender, EventArgs e)
        {
            //Criar um cookie
            HttpCookie novo = new HttpCookie("12_H");
            //definir o prazo de validade
            novo.Expires = DateTime.Now.AddDays(30);
            //definir valor
            novo.Value = "Teste";
            //enviar para o browser
            Response.Cookies.Add(novo);
        }
    }
}