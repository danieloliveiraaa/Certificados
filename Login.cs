using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Desafio_Jix
{
    public partial class Login : Form
    {

        private void MaxId_Usu()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            //PEGO O MAIOR ID EXISTENTE E SOMO + 1
            string max_id = @"select max (id_usuario + 1) maior_id 
                                from login_sistema;";

            SqlCommand cmd_id = new SqlCommand(max_id, cn);

            cn.Open();

            //LÊ O MAX_ID
            SqlDataReader read_id = cmd_id.ExecuteReader();


            while (read_id.Read())
            {
                max_id = read_id["maior_id"].ToString();

                txtIdCad.Text = max_id;

                txtIdCad.BackColor = Color.LightGreen;

            }
        }



        public Login()
        {
            InitializeComponent();
            MaxId_Usu();
        }

        //BUSCAR USUARIO NO BANCO
        private void UsuarioExiste()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            
            string login = @"select count (*) count_login 
                               from login_sistema 
                              where login_usuario = '" + txtLogin.Text + "';";

            SqlCommand cmd = new SqlCommand(login, cn);

            cn.Open();

            //VALIDANDO EXISTÊNCIA DO USUÁRIO

            SqlDataReader read_login = cmd.ExecuteReader();

            if (read_login.Read())
            {
                login = read_login["count_login"].ToString();

                if (login == "1")
                {
                    pctPositivo.Visible = true;
                }

                else
                {
                    pctPositivo.Visible = false;

                }
            }
        }


        //CHAMAR O NOME DO BANCO DE DADOS
        private void Retorna_Nome()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            //retorno o nome do usuario
            string busca_nome = @"select nome_usuario nome
                                    from login_sistema
                                   where login_usuario = '" + txtLogin.Text + "' and senha_usuario = '" + txtSenha.Text + "';";

            SqlCommand nome = new SqlCommand(busca_nome, cn);

            cn.Open();

            SqlDataReader read_nome = nome.ExecuteReader();

            if(read_nome.Read())
            {
                busca_nome = read_nome["nome"].ToString();

                lblRecebeNome.Text = busca_nome;

                MessageBox.Show("Bem-Vindo " + busca_nome + "!");

                cn.Close();
            }
            else 
            { 
               
            }
        }


        private void Logar()
        {

            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            
            string login = @"select count (*) usuario 
                               from login_sistema
                              where login_usuario = '" + txtLogin.Text + "' and senha_usuario = '" + txtSenha.Text + "';";

            
            SqlCommand cmd = new SqlCommand(login, cn);
            
            cn.Open();


            SqlDataReader read_usuario = cmd.ExecuteReader();

            if (read_usuario.Read())
            {
                login = read_usuario["usuario"].ToString();

 
                if (login == "1")
                {
                    Retorna_Nome();

                    Menu m = new Menu(lblRecebeNome.Text, txtLogin.Text);
                    m.StartPosition = FormStartPosition.CenterScreen;
                    m.Show();
                    this.Hide();
                                               
   
                }

                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        //EVITAR LOGINS IGUAIS NO BANCO DE DADOS
        private void ExisteLogin()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");


            string login = @"select count (*) count_login 
                               from login_sistema 
                              where login_usuario = '" + txtLoginCad.Text + "';";

            try
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand(login, cn);
                
                SqlDataReader read_login = cmd.ExecuteReader();


                while (read_login.Read())
                {
                    login = read_login["count_login"].ToString();
                    
                    if(login == "1")
                    {
                        txtLoginCad.BackColor = Color.LightCoral;
                        pctAlerta.Visible = true;
                        btnCadastrar.Visible = false;
                    }
                    else
                    {
                        txtLoginCad.BackColor = Color.LightGreen;
                        pctAlerta.Visible = false;
                        btnCadastrar.Visible = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro" + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }



        private void CadastroUsuario() 
        {

            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");
            string sql = @"insert into login_sistema (id_usuario, nome_usuario, login_usuario, senha_usuario, email_usuario) values(@id_usuario, @nome_usuario, @login_usuario, @senha_usuario, @email_usuario)";
            
            try
            {

                //ANTES SE INSERIR, VERIFICAR SE ALGUNS DOS CAMPOS ABAIXO ESTÃO VAZIOS.
                if ((txtNomeCad.Text == "") | (txtLoginCad.Text == "") | (txtSenhaCad.Text == "") | (txtEmailCad.Text == ""))
                {
                    MessageBox.Show("HÁ CAMPOS EM BRANCO, POR FAVOR VERIFIQUE !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //VERIFICA SE TODOS OS CAMPOS SAO VAZIOS.
                else if ((txtNomeCad.Text == "") & (txtLoginCad.Text == "") & (txtSenhaCad.Text == "") & (txtEmailCad.Text == ""))
                {
                    MessageBox.Show("NÃO FOI POSSIVEL REALIZAR O CADASTRO,\nPOIS TODOS OS CAMPOS ESTÃO EM BRANCO. \nPOR FAVOR VERIFIQUE.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if ((txtLoginCad.BackColor == Color.LightCoral))
                {
                    MessageBox.Show("Já existe um usuário com este login!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {

                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.Add(new SqlParameter("@id_usuario", this.txtIdCad.Text));
                    cmd.Parameters.Add(new SqlParameter("@nome_usuario", this.txtNomeCad.Text));
                    cmd.Parameters.Add(new SqlParameter("@login_usuario", this.txtLoginCad.Text));
                    cmd.Parameters.Add(new SqlParameter("@senha_usuario", this.txtSenhaCad.Text));
                    cmd.Parameters.Add(new SqlParameter("@email_usuario", this.txtEmailCad.Text));


                    //Abre a conexão com o banco de dados
                    cn.Open();

                    //Executa o comando sql
                    cmd.ExecuteNonQuery();


                    //Mensagem de sucesso para o usuário
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIdCad.Text = "";
                    MaxId_Usu();

                    txtNomeCad.Text = "";
                    txtLoginCad.Text = "";
                    txtLoginCad.BackColor = Color.White;
                    txtSenhaCad.Text = "";
                    txtEmailCad.Text = "";
                }

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




        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            UsuarioExiste();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pctPositivo.Visible == true)
            {
                EsqueciSenha esq = new EsqueciSenha(txtLogin.Text);
                esq.StartPosition = FormStartPosition.CenterScreen;
                esq.Show();
            }
            else
            {
                MessageBox.Show("Digite um usuário válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroUsuario();            
        }

        private void txtLoginCad_TextChanged(object sender, EventArgs e)
        {
            ExisteLogin();
        }
    }
}
