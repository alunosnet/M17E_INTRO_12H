using M17E_INTRO_12H.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_INTRO_12H
{
    public partial class recuperarpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt_recuperar_Click(object sender, EventArgs e)
        {
            try
            {
                //validar a password
                string password = tb_palavra_passe.Text.Trim();
                if (password.Length == 0)
                    throw new Exception("");

                //guid => token
                string token = Server.UrlDecode(Request["token"].ToString());
                //atualizar a palavra passe
                Utilizadores utilizador = new Utilizadores();
                utilizador.atualizarPassword(token, password);

            }
            catch (Exception ex)
            {
            }
            //redirecionar para login
            Response.Redirect("login.aspx");
        }
    }
}