using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Desafio_Jix
{
    public partial class EsqueciSenha : Form
    {




        public EsqueciSenha(string login)
        {
            InitializeComponent();
            txtLogin.Text = login;
        }


        private void Usuario_Email()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            string usu_email = @"select count (*) usuario_email
                                   from login_sistema
                                  where login_usuario = '" + txtLogin.Text + "' and email_usuario = '" + txtEmail.Text + "'";

            SqlCommand cmd = new SqlCommand(usu_email, cn);

            cn.Open();

            SqlDataReader read_emailusuario = cmd.ExecuteReader();

            if (read_emailusuario.Read())
            {
                usu_email = read_emailusuario["usuario_email"].ToString();
                
                if(usu_email == "1")
                {
                    pctLogin.Visible = true;
                    pctEmail.Visible = true;

                    pctLogin.BackgroundImage = Properties.Resources.ok;
                    pctEmail.BackgroundImage = Properties.Resources.ok;

                    txtLogin.Enabled = false;
                    txtEmail.Enabled = false;

                    btnEnvia.Enabled = true;


                }
                else
                {
                    pctLogin.Visible = true;
                    pctEmail.Visible = true;

                    pctLogin.BackgroundImage = Properties.Resources.erro;
                    pctEmail.BackgroundImage = Properties.Resources.erro;

                    
                }

            }
            else 
            { 
            
            }
        }


        private void GeraCodigo()
        {
            //GERO UM CODIGO, RANDOMICO
            //PARA QUE O DESTINATARIO DO EMAIL CONFIRME 
            Random aleatorio = new Random();
            string codigo = Convert.ToString(aleatorio.Next());

            txtRecebeCodigo.Text = codigo;
        }


        private void EnviaCodigo()
        {
            /*
            O Simple Mail Transfer Protocol SMTP
            é um protocolo de comunicação padrão 
            da Internet para transmissão de correio eletrônico. 
            Servidores de correio e outros agentes de transferência 
            de mensagens usam SMTP para enviar e 
            receber mensagens de correio.
            */
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();

            //Host seria no caso o tipo do email a ser usado, por exemplo Gmail, Outlook e Yahoo.
            //NESSE CASO FAREI USO DO SERVIDOR DO OUTLOOK
            client.Host = "smtp-mail.outlook.com";

            client.EnableSsl = true;

            client.Port = 587;


            //Abre o Outlook,Gmail e etc, com email e senha.          --email                     --senha 
            client.Credentials = new System.Net.NetworkCredential("danisilvi.oli@hotmail.com", "!28052018!");

            //Instância para criação da mensagem.
            MailMessage mail = new MailMessage();

            //Email que será o remetente.
            mail.From = new MailAddress("danisilvi.oli@hotmail.com");

            //Email destinatario que será, o email inserido na caixa de texto.
            mail.To.Add(new MailAddress(txtEmail.Text));

            //Titulo do email.
            mail.Subject = "CÓDIGO DE VERIFICAÇÃO DE EMAIL";

            //A mensagem que será enviada.
            mail.Body = ("Segue abaixo seu código de verificação:\n" + txtRecebeCodigo.Text);

            mail.Priority = MailPriority.High;


            try
            {
                //Realiza o envio.
                client.Send(mail);
                MessageBox.Show("EMAIL ENVIADO PARA SUA CAIXA DE ENTRADA !! \n\nPOR FAVOR VERIFICAR !!");

                txtConfirmaCodigo.Visible = true;
                lblA.Visible = true;


            }
            catch (System.Exception)
            {
                //trata erro.
            }
            finally
            {
                //Após a operação o email, retorna como nulo.
                mail = null;
            }
       
        }


        private void ValidaCodigo()
        {
            if(txtConfirmaCodigo.Text == txtRecebeCodigo.Text)
            {
                pctOk.Visible = true;
                lblOk.Visible = true;

                txtConfirmaCodigo.Enabled = false;

                lblSenha.Visible = true;
                txtSenha.Visible = true;
                lblConfirma.Visible = true;
                txtConfirmaSenha.Visible = true;

                pctErro.Visible = false;
                lblErro.Visible = false;


            }

            else
            {
                pctErro.Visible = true;
                lblErro.Visible = true;
            }
        }


        private void ValidaCampos_Senha()
        {

            if (txtConfirmaSenha.Text == txtSenha.Text)
            {
                GravarSenha();
            }
            else 
            {
                MessageBox.Show("As senhas precisam ser iguais", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void GravarSenha()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            string sql = String.Format(@"update login_sistema 
                                            set senha_usuario = '{0}'
                                          where login_usuario = '{1}'", txtConfirmaSenha.Text, txtLogin.Text);

            SqlCommand cmd = new SqlCommand(sql, cn);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Senha Redefinida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();            
                

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Erro" + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }







        private void btnEnvia_Click(object sender, EventArgs e)
        {
            GeraCodigo();

            EnviaCodigo();

            btnEnvia.Text = "Ainda não recebeu? Enviar novamente";
        }

        private void txtConfirmaCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidaCodigo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ValidaCampos_Senha(); 
            //se as senhas forem iguais, o metodo de valida campos
            //chama o metodo que atualiza a senha, no caso o GravarSenha().
        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {
            Usuario_Email();
        }

        private void txtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.BackColor = Color.SpringGreen;
            btnSalvar.Visible = true;
            btnSalvar.Enabled = true;
        }
    }
}
