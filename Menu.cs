using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Desafio_Jix
{
    public partial class Menu : Form
    {
        public Menu(string nome, string login)
        {
            InitializeComponent();

            string hora = DateTime.Now.ToString("hh:mm");

            string data = DateTime.Now.ToString("dd/MM/yyyy");

            lblHora.Text = hora;
            lblData.Text = data;

            lblNomeUsu.Text = nome;



            //VERIFICANDO AS APLICAÇÕES LIBERADAS//

            //espelhar e liberar acesso a aplicações
            //APENAS O ADMIN
            
            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");


            string aplicacao1 = @"select count (*) liberar_e_espelho 
                                   from usuario_aplicacoes 
                                  where login_usuario = '"+ login +"' and nome_aplicacao in ('liberar_aplicacao','espelhar_aplicacao');";

            SqlCommand cmd1 = new SqlCommand(aplicacao1, cn);

            cn.Open();

            SqlDataReader read_aplicacao1 = cmd1.ExecuteReader();

            if (read_aplicacao1.Read())
            {
                aplicacao1 = read_aplicacao1["liberar_e_espelho"].ToString();

                if (aplicacao1 == "2")
                {
                    lblLiberaAplicacao.Visible = true;
                    btnLiberaAplicacao.Visible = true;

                    lblEspelho.Visible = true;
                    btnEspelho.Visible = true;
                    cn.Close();
                }

                else
                {
                    lblLiberaAplicacao.Visible = false;
                    btnLiberaAplicacao.Visible = false;

                    btnEspelho.Visible = false;
                    btnEspelho.Visible = false;
                    cn.Close();
                }
            }


            //CADASTRO DE ALUNOS

            string aplicacao2 = @"select count (*) cadastro_al
                                   from usuario_aplicacoes 
                                  where login_usuario = '" + login + "' and nome_aplicacao = 'cadastro_aluno';";

            SqlCommand cmd2 = new SqlCommand(aplicacao2, cn);

            cn.Open();

            SqlDataReader read_aplicacao2 = cmd2.ExecuteReader();

            if (read_aplicacao2.Read())
            {
                aplicacao2 = read_aplicacao2["cadastro_al"].ToString();

                if (aplicacao2 == "1")
                {
                    lblCadastroAluno.Visible = true;
                    btnCadastroAluno.Visible = true;
                    cn.Close();
                }

                else
                {
                    lblCadastroAluno.Visible = false;
                    btnCadastroAluno.Visible = false;
                    cn.Close();
                }
            }


            //ENVIO DE CERTIFICADOS

            string aplicacao3 = @"select count (*) envio_cert
                                   from usuario_aplicacoes 
                                  where login_usuario = '" + login + "' and nome_aplicacao = 'envia_certificado';";

            SqlCommand cmd3 = new SqlCommand(aplicacao3, cn);

            cn.Open();

            SqlDataReader read_aplicacao3 = cmd3.ExecuteReader();

            if (read_aplicacao3.Read())
            {
                aplicacao3 = read_aplicacao3["envio_cert"].ToString();

                if (aplicacao3 == "1")
                {
                    lblEnviaCertificado.Visible = true;
                    btnEnviaCertificado.Visible = true;
                    cn.Close();
                }

                else
                {
                    lblEnviaCertificado.Visible = false;
                    btnEnviaCertificado.Visible = false;
                    cn.Close();
                }
            }


            //CONSULTAR CERTIFICADOS

            string aplicacao4 = @"select count (*) consulta_cert
                                   from usuario_aplicacoes 
                                  where login_usuario = '" + login + "' and nome_aplicacao = 'consulta_certificado';";

            SqlCommand cmd4 = new SqlCommand(aplicacao4, cn);

            cn.Open();

            SqlDataReader read_aplicacao4 = cmd4.ExecuteReader();

            if (read_aplicacao4.Read())
            {
                aplicacao4 = read_aplicacao4["consulta_cert"].ToString();

                if (aplicacao4 == "1")
                {
                    lblConsultaCertificado.Visible = true;
                    btnConsultaCertificado.Visible = true;
                    cn.Close();
                }

                else
                {
                    lblConsultaCertificado.Visible = false;
                    btnConsultaCertificado.Visible = false;
                    cn.Close();
                }
            }
        }

        private void btnCadastroAluno_Click(object sender, EventArgs e)
        {
            CadastroAluno cad_aluno = new CadastroAluno();
            cad_aluno.StartPosition = FormStartPosition.CenterScreen;
            cad_aluno.Show();
        }

        private void btnEnviaCertificado_Click(object sender, EventArgs e)
        {
            EnviaDocumento envia = new EnviaDocumento();
            envia.StartPosition = FormStartPosition.CenterScreen;
            envia.Show();
        }

        private void btnConsultaCertificado_Click(object sender, EventArgs e)
        {
            Visualizar v = new Visualizar();
            v.StartPosition = FormStartPosition.CenterScreen;
            v.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Close();
            l.StartPosition = FormStartPosition.CenterScreen;
            l.Show();
        }
    }
}
