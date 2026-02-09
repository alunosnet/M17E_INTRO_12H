using M17E_INTRO_12H.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_INTRO_12H.Utilizador.Codigo
{
    public partial class EditarUtilizador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //consultar a bd para recolher os dados do utilizador
            if (IsPostBack) return;
            try
            {
                if (Request["id"] == null)
                    Response.Redirect("~/Utilizador/Codigo/gerir.aspx");
                int id = int.Parse(Request["id"].ToString());
                Utilizadores utilizador = new Utilizadores();
                DataTable dados = utilizador.devolveDadosUtilizador(id);
                if (dados == null || dados.Rows.Count != 1)
                {
                    throw new Exception("Utilizador não existe");
                }
                tbNome.Text = dados.Rows[0]["nome"].ToString();
            }
            catch
            {
                lbErro.Text = "O utilizador indicado não existe.";
                ScriptManager.RegisterStartupScript(this, typeof(Page),
                    "Redirecionar", "returnMain('/Utilizador/Codigo/gerir.aspx')", true);
            }
        }

        protected void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = tbNome.Text.Trim();
                if (string.IsNullOrEmpty(nome) || nome.Length < 3)
                {
                    throw new Exception("O nome não é válido.");
                }

                int id = int.Parse(Request["id"].ToString());
                Utilizadores utilizador = new Utilizadores();
                utilizador.id = id;
                utilizador.nome = nome;
                utilizador.atualizarUtilizador();
            }
            catch (Exception error)
            {
                lbErro.Text = "Ocorreu um erro: " + error.Message;
                return;
            }
            lbErro.Text = "Utilizador atualizado com sucesso.";
            ScriptManager.RegisterStartupScript(this, typeof(Page),
                    "Redirecionar", "returnMain('/Utilizador/Codigo/gerir.aspx')", true);
        }
    }
}