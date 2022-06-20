using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Desafio_Jix
{
    public partial class CadastroAluno : Form
    {
        

        //FUNÇÃO QUE PEGA O MAIOR ID DA TABELA DE ALUNOS E SOMA + 1
        private void MaxId_Aluno()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            //PEGO O MAIOR ID EXISTENTE E SOMO + 1
            string max_id = @"select max (aluno_id + 1) maior_id 
                                from alunos;";

            SqlCommand cmd_id = new SqlCommand(max_id, cn);

            cn.Open();

            //LÊ O MAX_ID
            SqlDataReader read_id = cmd_id.ExecuteReader();


            while (read_id.Read())
            {
                max_id = read_id["maior_id"].ToString();

                txtId.Text = max_id;
                
                txtId.BackColor = Color.LightGreen;

            }
        }

        public CadastroAluno()
        {
            InitializeComponent();
            MaxId_Aluno();
        }


        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            //conta os id existentes
            string matricula = "SELECT COUNT (*) AS CONT_MATRICULA FROM alunos WHERE aluno_matricula = '" + txtMatricula.Text + "';";

            SqlCommand cmd_matricula = new SqlCommand(matricula, cn);

            cn.Open();

            //LÊ O COUNT ID
            SqlDataReader read_matricula = cmd_matricula.ExecuteReader();


            if (read_matricula.Read())
            {
                matricula = read_matricula["CONT_MATRICULA"].ToString();

                //CASO A CAIXA TEXTO E/OU A VARIAVEL id SEJAM VAZIAS... 
                if ((txtMatricula.Text == "" || matricula == "") || (txtMatricula.Text == "" && matricula == ""))
                {
                    pctMat_Erro.Visible = false;

                    txtMatricula.BackColor = Color.White;

                    m1.Visible = false;
                }

                //EXISTINDO ESSE ID NO BANCO...
                else if (matricula == "1")
                {
                    pctMat_Erro.Visible = true;
                    pctMat_Erro.BackgroundImage = Properties.Resources.erro;

                    txtMatricula.BackColor = Color.LightCoral;

                    m1.Visible = true;
                }

                else
                {
                    pctMat_Erro.Visible = true;

                    txtMatricula.BackColor = Color.LightGreen;
                    pctMat_Erro.BackgroundImage = Properties.Resources.voto_positivo;

                    m1.Visible = false;
                }
            }

            else
            {


            }

            cn.Close();
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            //conta os cpf's existentes
            string cpf = "SELECT COUNT (*) AS CONT_CPF FROM alunos WHERE aluno_cpf = '" + txtCpf.Text + "';";

            SqlCommand cmd_cpf = new SqlCommand(cpf, cn1);

            cn1.Open();

            //LÊ O COUNT CPF
            SqlDataReader read_cpf = cmd_cpf.ExecuteReader();


            if (read_cpf.Read())
            {
                cpf = read_cpf["CONT_CPF"].ToString();

                //CASO A CAIXA TEXTO E/OU A VARIAVEL id SEJAM VAZIAS...
                if ((txtCpf.Text == "" || cpf == "") || (txtCpf.Text == "" && cpf == ""))
                {
                    pctCpf_Erro.Visible = false;

                    txtCpf.BackColor = Color.White;

                    cpf1.Visible = false;
                }

                //EXISTINDO ESSE ID NO BANCO...
                else if (cpf == "1")
                {
                    pctCpf_Erro.Visible = true;

                    pctCpf_Erro.BackgroundImage = Properties.Resources.erro;

                    txtCpf.BackColor = Color.LightCoral;

                    cpf1.Visible = true;
                }


                else
                {
                    pctCpf_Erro.Visible = true;

                    txtCpf.BackColor = Color.LightGreen;
                    pctCpf_Erro.BackgroundImage = Properties.Resources.voto_positivo;

                    cpf1.Visible = false;
                }

            }
            else
            {

            }

            cn1.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            string sql = "insert into alunos (aluno_id, aluno_matricula, aluno_nome, aluno_cpf) values(@aluno_id, @aluno_matricula, @aluno_nome, @aluno_cpf)";


            try
            {

                //ANTES SE INSERIR, VERIFICAR SE ALGUNS DOS CAMPOS ABAIXO ESTÃO VAZIOS.
                if ((txtId.Text == "") | (txtNome.Text == "") | (txtCpf.Text == "") | (txtMatricula.Text == ""))
                {
                    MessageBox.Show("HÁ CAMPOS EM BRANCO, POR FAVOR VERIFIQUE !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //VERIFICA SE O CAMPO CPF ESTA COM A QUATIDADE CERTA.
                else if ((txtCpf.Text.Length < 11 && txtMatricula.Text.Length < 3) || (txtCpf.Text.Length < 11 || txtMatricula.Text.Length < 3))
                {
                    MessageBox.Show("Erro nos seguintes campos: \n\nCPF - 11 Digitos.\nMatrícula - 3 Digitos.\n\nDescrição: Os seguintes campos, estão faltando caracteres", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //VERIFICA SE TODOS OS CAMPOS SAO VAZIOS.
                else if ((txtId.Text == "") & (txtNome.Text == "") & (txtCpf.Text == "") & (txtMatricula.Text == ""))
                {
                    MessageBox.Show("NÃO FOI POSSIVEL REALIZAR O CADASTRO,\nPOIS TODOS OS CAMPOS ESTÃO EM BRANCO. \nPOR FAVOR VERIFIQUE.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if ((txtId.BackColor == Color.LightCoral) | (txtCpf.BackColor == Color.LightCoral) | (txtMatricula.BackColor == Color.LightCoral))
                {
                    MessageBox.Show("OS CAMPOS EM VERMELHO, JÁ CONSTAM NO SISTEMA !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                else
                {
                    SqlCommand cmd = new SqlCommand(sql, cn1);
                    cmd.Parameters.Add(new SqlParameter("@aluno_id", this.txtId.Text));
                    cmd.Parameters.Add(new SqlParameter("@aluno_matricula", this.txtMatricula.Text));
                    cmd.Parameters.Add(new SqlParameter("@aluno_nome", this.txtNome.Text));
                    cmd.Parameters.Add(new SqlParameter("@aluno_cpf", this.txtCpf.Text));
                    

                    //Abre a conexão com o banco de dados
                    cn1.Open();

                    //Executa o comando sql
                    cmd.ExecuteNonQuery();


                    //LIMPA OS CAMPOS
                    txtId.Text = "";
                    txtMatricula.Text = "";
                    txtNome.Text = "";
                    txtCpf.Text = "";


                    //Mensagem de sucesso para o usuário
                    MessageBox.Show("ALUNO CADASTRADO !", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro" + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn1.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMatricula.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
                
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
