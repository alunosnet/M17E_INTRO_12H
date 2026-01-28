using M17E_INTRO_12H.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_INTRO_12H
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt_login_Click(object sender, EventArgs e)
        {
            //validar
            if (tb_email.Text=="" || tb_password.Text=="")
            {
                lb_erro.Text = "Login falhou. Tente novamente.";
                return;
            }
            //consulta à tabela de utilizadores
            Utilizadores novo = new Utilizadores();
            //TODO: CONTINUAR AQUI!!!!!!!!!!!
            //Sessão - perfil, email, nome
            //redirecionar o utilizador de acordo com perfil
        }
    }
}