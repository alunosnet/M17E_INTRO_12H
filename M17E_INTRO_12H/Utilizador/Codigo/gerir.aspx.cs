using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_INTRO_12H.Utilizador.Codigo
{
    public partial class gerir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                AtualizaGrid();
        }

        protected void bt_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                //validar o form
                string nome = tb_nome.Text.Trim();
                if (nome.Length < 3)
                {
                    throw new Exception("O nome tem de ter pelo menos 3 letras");
                }
                string email = tb_email.Text.Trim();
                if (email == String.Empty || email.Contains("@") == false ||
                   email.Contains('.') == false)
                {
                    throw new Exception("O email indicado não é válido");
                }

                string password = tb_password.Text.Trim();
                if (password.Length < 5)
                {
                    throw new Exception("A password tem de ter pelo menos 5 letras");
                }
                int perfil = int.Parse(dd_perfil.SelectedValue);
                Random rnd = new Random();
                int sal = rnd.Next(1000);

                Classes.Utilizadores utilizador = new Classes.Utilizadores();
                utilizador.nome = nome;
                utilizador.email = email;
                utilizador.sal = sal;
                utilizador.palavra_passe = password;
                utilizador.perfil = perfil;

                utilizador.Adicionar();

                //limpar form
                tb_email.Text = "";
                tb_nome.Text = "";
            }
            catch (Exception erro)
            {
                lb_erro.Text = "Ocorreu o seguinte erro: " + erro.Message;
                lb_erro.CssClass = "alert alert-danger";
            }
            //atualizar grid
            AtualizaGrid();
        }
        private void AtualizaGrid()
        {
            //limpar gridview
            gvUtilizadores.Columns.Clear();
            gvUtilizadores.DataSource = null;
            gvUtilizadores.DataBind();

            Classes.Utilizadores utilizador = new Classes.Utilizadores();
            DataTable dados = utilizador.ListaTodosUtilizadores();

            gvUtilizadores.DataSource = dados;
            gvUtilizadores.AutoGenerateColumns = false;

            //remover
            DataColumn dcRemover = new DataColumn();
            dcRemover.ColumnName = "Remover";
            dcRemover.DataType = Type.GetType("System.String");
            dados.Columns.Add(dcRemover);
            //editar
            DataColumn dcEditar = new DataColumn();
            dcEditar.ColumnName = "Editar";
            dcEditar.DataType = Type.GetType("System.String");
            dados.Columns.Add(dcEditar);

            //histórico
            DataColumn dcHistorico = new DataColumn();
            dcHistorico.ColumnName = "Historico";
            dcHistorico.DataType = Type.GetType("System.String");
            dados.Columns.Add(dcHistorico);

            //Formatação Gridview
            //remover
            HyperLinkField hlRemover = new HyperLinkField();
            hlRemover.HeaderText = "Remover";
            hlRemover.DataTextField = "Remover";    //columnname do datatable
            hlRemover.Text = "Remover";
            //RemoverUtilizador.aspx?id={0}
            hlRemover.DataNavigateUrlFormatString = "RemoverUtilizador.aspx?id={0}";
            hlRemover.DataNavigateUrlFields = new string[] { "id" };
            hlRemover.ControlStyle.CssClass = "btn btn-danger";
            gvUtilizadores.Columns.Add(hlRemover);
            //editar
            HyperLinkField hlEditar = new HyperLinkField();
            hlEditar.HeaderText = "Editar";
            hlEditar.DataTextField = "Editar";    //columnname do datatable
            hlEditar.Text = "Editar";
            hlEditar.DataNavigateUrlFormatString = "EditarUtilizador.aspx?id={0}";
            hlEditar.DataNavigateUrlFields = new string[] { "id" };
            hlEditar.ControlStyle.CssClass = "btn btn-info";
            gvUtilizadores.Columns.Add(hlEditar);

            //histórico
            HyperLinkField hlHistorico = new HyperLinkField();
            hlHistorico.HeaderText = "Histórico";
            hlHistorico.DataTextField = "Historico";    //columnname do datatable
            hlHistorico.Text = "Histórico";
            hlHistorico.DataNavigateUrlFormatString = "HistoricoUtilizador.aspx?id={0}";
            hlHistorico.DataNavigateUrlFields = new string[] { "id" };
            hlHistorico.ControlStyle.CssClass = "btn btn-success";
            gvUtilizadores.Columns.Add(hlHistorico);

            //id
            BoundField bfId = new BoundField();
            bfId.HeaderText = "Id";
            bfId.DataField = "id";
            bfId.Visible = false;
            gvUtilizadores.Columns.Add(bfId);
            //email
            BoundField bfEmail = new BoundField();
            bfEmail.HeaderText = "Email";
            bfEmail.DataField = "email";
            gvUtilizadores.Columns.Add(bfEmail);
            //nome
            BoundField bfNome = new BoundField();
            bfNome.HeaderText = "Nome";
            bfNome.DataField = "nome";
            gvUtilizadores.Columns.Add(bfNome);
            //perfil
            BoundField bfPerfil = new BoundField();
            bfPerfil.HeaderText = "Perfil";
            bfPerfil.DataField = "perfil";
            gvUtilizadores.Columns.Add(bfPerfil);
            //Como fazer para aparecer a palavra Admin ou utilizador em vez 0 e 1?
            gvUtilizadores.DataBind();
        }
    }
}