using EnxamePhobos.BLL;
using EnxamePhobos.DTO;
using ExamePhobos.UI.Utilities;
using System;

namespace ExamePhobos.UI
{
    public partial class Login : System.Web.UI.Page
    {
        UsuarioDTO user = new UsuarioDTO();
        UsuarioBLL userBLL = new UsuarioBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblResult.Text = "Bem vindo a nossa aplicação tosca!!!";
        }
        //load page

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            //pegar as informaçoes digitadas pelo usuario
            string nome = txtNome.Text.Trim();
            string senha = txtSenha.Text.Trim();

            //chamando o procedimento de autenticação
            user = userBLL.AuthenticateUserBLL(nome, senha);
            if (user != null)
            {
                lblResult.Text = $"Usuário {nome} com aceso permitido !!";
            }
            else
            {
                lblResult.Text = $"usuário não cadastrado !!";
            }
        }
        //entrar

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            //Antigo
            //txtNome.Text = txtSenha.Text = string.Empty;
            //txtNome.Focus();

            //Novo
            Clear.ClearControl(this);
            txtNome.Focus();
        }
        //limpar formulario
    }
}