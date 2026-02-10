using M17E_INTRO_12H.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
            //Validar recaptcha
            var resposta = Request.Form["g-Recaptcha-Response"];
            var validou = ReCaptcha.Validate(resposta);
            if (validou == false)
            {
                lb_erro.Text = "Tem de provar que não é um robot.";
                return;
            }
            //consulta à tabela de utilizadores
            Utilizadores novo = new Utilizadores();
            novo.email=tb_email.Text;
            novo.palavra_passe = tb_password.Text;
            if (novo.VerificaLogin() == false)
            {
                lb_erro.Text = "Login falhou. Tente novamente.";
                return;
            }
            //Sessão - perfil, email, nome
            Session["id"] = novo.id;
            Session["email"] = novo.email;
            Session["perfil"] = novo.perfil;
            Session["nome"] = novo.nome;
            Session["ip"] = Request.UserHostAddress;
            Session["useragent"] = Request.UserAgent;
            //redirecionar o utilizador de acordo com perfil
            if (novo.perfil == 0)
            {
                Response.Redirect("admin.aspx");
            }
            if (novo.perfil == 1)
            {
                Response.Redirect("cliente.aspx");
            }
        }

        protected void bt_recuperar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_email.Text.Trim().Length == 0)
                    throw new Exception("Indique um email");
                string email = tb_email.Text.Trim();
                //Verificar se existe o email
                Classes.Utilizadores utilizador = new Classes.Utilizadores();
                DataTable dados = utilizador.devolveDadosUtilizador(email);
                if (dados == null || dados.Rows.Count != 1)
                    throw new Exception("Caso o email indicado exista, foi enviada uma mensagem para recuperação da palavra passe.");
                //TOKEN => GUID
                Guid guid = Guid.NewGuid();
                string token=guid.ToString();
                utilizador.recuperarPassword(email, token);
                //Criar uma mensagem
                string mensagem = "Clique no link para recuperar a sua password.<br/>";
                mensagem += "<a href='https://" + Request.Url.Authority + "/recuperarpassword.aspx?";
                mensagem += "token=" + Server.UrlEncode(token) + "'>Clique aqui</a>";

                //Enviar a mensagem
                string meuemail = ConfigurationManager.AppSettings["email"].ToString();
                string palavrapasse = ConfigurationManager.AppSettings["email_password"].ToString();
                Helper.enviarMail(meuemail, palavrapasse, email,
                    "Recuperação de palavra passe", mensagem);
                lb_erro.Text = @"Caso o email indicado exista, 
        foi enviada uma mensagem para recuperação da palavra passe.";
            }
            catch (Exception ex)
            {
                //Mostrar mensagem lb_erro
                lb_erro.Text = ex.Message;
            }
        }
    }
}