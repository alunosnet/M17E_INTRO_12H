using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_INTRO_12H
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar se tem sessão iniciada
            if (Session["perfil"] == null)
                Response.Redirect("login.aspx");
            //verificar o perfil do utilizador
            if (Session["perfil"].ToString()!="0")
                Response.Redirect("login.aspx");

            //verificar o ip e useragent
            if (Session["ip"].ToString()!= Request.UserHostAddress ||
                Session["useragent"].ToString() != Request.UserAgent)
            {
                //terminar sessão
                bt_logout_Click(sender, e);
            }

        }

        protected void bt_logout_Click(object sender, EventArgs e)
        {
            //terminar sessão
            Session.Clear();
            Session.Abandon();
            Response.Redirect("login.aspx");

        }
    }
}