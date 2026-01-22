using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_INTRO_12H
{
    public partial class resultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //div_resultado.InnerText = "Erro não existe o parâmetro resultado!";
            //ler da url o parâmetro resultado
            if (Request.QueryString["resultado"] != null)
            {
                int resultado = 0;
                bool converteu=int.TryParse(Request.QueryString["resultado"],
                                            out resultado);
                if (converteu)
                    div_resultado.InnerText = "Resultado: " + resultado;
                else
                    Response.Write("<script>alert('Ocorreu um erro!');</script>");
            }
            else
            {
                //Response.Write("<script>alert('Não existe o parâmetro resultado!');</script>");
                //redirecionar para a página index.aspx
                //mostrar uma mensagem de erro na index.aspx
                string url = "index.aspx?erro=1";
                Response.Redirect(url);
            }
        }
    }
}