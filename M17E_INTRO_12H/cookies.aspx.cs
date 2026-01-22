using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_INTRO_12H
{
    public partial class cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //se o cookie existe
            if (Request.Cookies["12_H"] != null)
                div_aviso.Visible = false;  //esconder a div
        }
    }
}