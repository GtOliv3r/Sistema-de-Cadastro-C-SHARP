using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Evento de Clique do botão Cadastrar
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //Armazenamento de atributos
            var user = this.txtUser.Text;
            var email = this.txtEmail.Text;
            var password = this.txtPassword.Text;

            //Limpeza dos campos
            txtUser.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";

            if(Validar_Usuario(email,user) == false) //Executa se a função Validar_usuario retornou false 
            {
                MessageBox.Show("Seu username ou e-mail é inválido ou já existe! tente novamente, por favor"); //Mensagem na tela avisando sobre erro de validação
            }

            else
            {
                //Passa as informações digitadas para os campos de texto inferiores
                txtUserCad.Text = user; 
                txtEmailCad.Text = email;
                txtPasswordCad.Text = password;

            
                MessageBox.Show("Obrigado por se cadastrar! Faça bom proveito de nossa aplicação!"); // Mensagem de Sucesso
            }
        }



        private bool Validar_Email(String email) // Método de validação de e-mail
        {
            if (!email.Contains("@")) {
                return false;
            }

            return true;
        }

        private bool Validar_User_Cadastrado(String user, String email) // Metodo de validação de usuario já cadastrado
        {
            if (user == txtUserCad.Text || email == txtEmailCad.Text) //Se uma dessas duas validações for True, retorna true.
            {
                return true;
            }

            return false;
        }

        private bool Validar_Usuario(String email, String user) //Chama os dois métodos de validação
        {
            bool resultado1 = Validar_Email(email);
            bool resultado2 = Validar_User_Cadastrado(user, email);

            if (resultado1 ==false || resultado2==true)
            {
                return false;
            }
            return true;
        }
    }
}
