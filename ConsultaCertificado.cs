using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Desafio_Jix
{
    public partial class Visualizar : Form
    {
        public Visualizar()
        {
            InitializeComponent();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            //conta os id existentes
            string id = @"SELECT COUNT (*) CONT_ID 
                          FROM alunos WHERE aluno_id = '" + txtId.Text + "';";

            SqlCommand cmd_id = new SqlCommand(id, cn);

            cn.Open();

            //LÊ O COUNT ID
            SqlDataReader read_id = cmd_id.ExecuteReader();


            if (read_id.Read())
            {
                id = read_id["CONT_ID"].ToString();


                //VERIFICAR PRIMEIRAMENTE SE A TEXT BOX ESTA VAZIA.
                //EM TODOS AS VALIDAÇÕES

                if ((txtId.Text == "" || id == "") || (txtId.Text == "" && id == ""))
                {
                    pctId_Erro.Visible = false;

                    txtId.BackColor = Color.White;

                    id1.Visible = false;

                    txtMatricula.Text = "";
                    txtNome.Text = "";
                    txtCpf.Text = "";

                }

                else if (id == "0")
                {
                    pctId_Erro.Visible = true;

                    pctId_Erro.BackgroundImage = Properties.Resources.erro;

                    txtId.BackColor = Color.LightCoral;

                    id1.Visible = true;

                    txtMatricula.Text = "";
                    txtNome.Text = "";
                    txtCpf.Text = "";
                }

                else /*if (id == "1")*/
                {
                    pctId_Erro.Visible = true;

                    pctId_Erro.BackgroundImage = Properties.Resources.voto_positivo;

                    id1.Visible = false;

                    txtId.BackColor = Color.LightGreen;

                    //MOSTRAR AO USUARIO O ALUNO REFERENTE AO ID SELECIONADO.
                    SqlConnection cn1 = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

                    //SELECIONA TODOS OS REGISTROS DA TABELA ALUNOS, COM BASE NO QUE FOI DIGITADO NO txtId
                    string sql = @"SELECT * 
                                   FROM alunos 
                                   WHERE aluno_id = '" + txtId.Text + "';";


                    SqlCommand cmd = new SqlCommand(sql, cn1);


                    cn1.Open();

                    try
                    {

                        SqlDataReader Buscar = cmd.ExecuteReader();

                        if (Buscar.Read())
                        {
                            
                            txtMatricula.Text = Buscar["aluno_matricula"].ToString();
                            txtNome.Text = Buscar["aluno_nome"].ToString();
                            txtCpf.Text = Buscar["aluno_cpf"].ToString();


                        }
                        else
                        {
                            MessageBox.Show("ALUNO NÃO ENCONTRADO !", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Alerta" + ex.Number, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        cn1.Close();
                    }
                }

            }

            else
            {


            }

            cn.Close();
        }

        //ABRE A TELA PARA ENVIO DE DOCUMENTOS
        private void btnEnviarDoc_Click(object sender, EventArgs e)
        {
            EnviaDocumento envio = new EnviaDocumento();
            envio.StartPosition = FormStartPosition.CenterScreen;
            envio.Show();
        }

        //ABRE A TELA PARA CADASTRO DE ALUNOS
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CadastroAluno cad_aluno = new CadastroAluno();
            cad_aluno.StartPosition = FormStartPosition.CenterScreen;
            cad_aluno.Show();
        }


        //AO CLICAR NO BOTÃO DE CONSULTAR, DESABILITA O MESMO, PARA REALIZAR UMA NOVA CONSULTA CLICAR NO BOTAO "NOVA"
        private void button1_Click(object sender, EventArgs e)
        {
            btnConsultar.Enabled = false;

            btnNova.Visible = true;
            lblNova.Visible = true;

            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            //SELECIONA OS CAMPOS CITADOS ABAIXO, COM BASE NO txtId
            string sql = @"SELECT 
                           id_documento         ID_DOC, 
                           aluno_id             ALUNO_ID, 
                           aluno_nome_documento NOME, 
                           aluno_tipo_atividade TIPO_ATIVIDADE, 
                           aluno_qt_horas       HORAS, 
                           aluno_status         STATUS_DOC 
                           FROM alunos_documentos
                           WHERE aluno_id = '" + txtId.Text + "';";

            SqlCommand cmd = new SqlCommand(sql, cn);

            cn.Open();

            cmd.CommandType.ToString();

           
            SqlDataReader dr = cmd.ExecuteReader();


            //Obtem o número de colunas
            int nColunas = dr.FieldCount;

            //percorre as colunas obtendo o seu nome e incluindo no Grid
            for (int i = 0; i < nColunas; i++)

            {
                GridDocumentos.Columns.Add(dr.GetName(i).ToString(), dr.GetName(i).ToString());
            }



            //Define um Array de strings com nColunas
            string[] linhaDados = new string[nColunas];

            //Percorre o DataRead
            while (dr.Read())
            {
                //Percorre cada uma das colunas
                for (int a = 0; a < nColunas; a++)
                {
                    //verifica o tipo de dados da coluna
                    //e converte para string
                    //independente do tipo armazenado no banco, ele converte para string.
                    if (dr.GetFieldType(a).ToString() == "System.Int32")
                    {
                        linhaDados[a] = dr.GetInt32(a).ToString();
                    }
                    if (dr.GetFieldType(a).ToString() == "System.String")

                    {
                        linhaDados[a] = dr.GetString(a).ToString();
                    }
                    if (dr.GetFieldType(a).ToString() == "System.DateTime")

                    {
                        linhaDados[a] = dr.GetDateTime(a).ToString();
                    }

                    
                }

                //atribui a linha ao datagridview
                GridDocumentos.Rows.Add(linhaDados);

            }

  
        }

        private void btnNova_Click(object sender, EventArgs e)
        {

            //HABILITA O BOTÃO NOVAMENTE
            btnConsultar.Enabled = true;

            //LIMPA O CAMPO txtId
            txtId.Text = "";

            //REMOVE A IMAGEM DO PICTURE
            pctExibir.Image = null;

            //LIMPA O COMBO BOX
            cbxExibeDocs.Text = "";

            //LIMPA O GRID
            GridDocumentos.DataSource = null;
            GridDocumentos.ResetBindings();
            GridDocumentos.Rows.Clear();
            GridDocumentos.DataSource = null;   //DEIXO NULO, O DATA SOURCE QUE ALIMENTA O GRID
            GridDocumentos.Columns.Clear();     //LIMPO AS COLUNAS
            GridDocumentos.Rows.Clear();        //LIMPO AS LINHAS
            GridDocumentos.Refresh();           //ATUALIZO O GRID
            
        }

        private void cbxExibeDocs_MouseClick(object sender, MouseEventArgs e)
        {
            //string de conexão
            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            //SELECIONA OS CAMPOS ABAIXO, COM BASE NO txtId (ID DO ALUNO NO CASO, FOREING KEY)
            string sql = @"SELECT 
                           id_documento    as ID_DOC,
                           aluno_id        as ID_ALUNO,
                           aluno_documento as ANEXO
                           FROM alunos_documentos
	                       WHERE aluno_id = '" + txtId.Text + "';";

            //abre a conexão
            cn.Open();


            //para preencher um DATASET/DATATABLE com linhas de uma consulta feita em um banco de dados.

            SqlDataAdapter adapter = new SqlDataAdapter(sql, cn);

            //INSTÂNCIO UM DATA TABLE
            DataTable table = new DataTable();
            table.Clear();                                  //ANTES DE CADA CONSULTA, LIMPA O DATA TABLE
            cbxExibeDocs.DataSource = null;
            adapter.Fill(table); 
            cbxExibeDocs.DataSource = table;
            cbxExibeDocs.ValueMember = "ID_ALUNO";
            cbxExibeDocs.DisplayMember = "ID_DOC";
            
        }



        private void btnConsultar_EnabledChanged(object sender, EventArgs e)
        {
            if (btnConsultar.Enabled == false)
            {
                MessageBox.Show("PARA CONSULTAR OUTRO ALUNO, CLIQUE NO BOTÃO NOVA CONSULTA !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //ACONTECE NADA
            }
        }

        private void cbxExibeDocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //EXIBIR NO PICTURE A IMAGEM SELECIONADA COM BASE NO ID_DOCUMENTO

            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            string sql = @"SELECT aluno_documento as Anexo
                            FROM alunos_documentos
	                       WHERE id_documento = '" + cbxExibeDocs.Text + "';";

            SqlCommand cmd = new SqlCommand(sql, cn);

            cn.Open();

            //LENDO OS DADOS
            SqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                //LENDO O DOCUMENTO, NA FORMA QUE ELE FOI ARMAZENADO
                //UM ARRAY DE BYTES

                byte[] doc = (byte[])read["Anexo"];

                MemoryStream ms = new MemoryStream(doc);

                Image documento = Image.FromStream(ms);

                pctExibir.Image = documento;

                cn.Close();

            }

        }

    }
}
