using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace Desafio_Jix
{
    public partial class EnviaDocumento : Form
    {
        public EnviaDocumento()
        {
            InitializeComponent();

            txtId.Focus();
        }



        private void txtId_TextChanged_1(object sender, EventArgs e)
        {
            txtId2.Text = txtId.Text;

            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            //VERIFICANDO SE O ID DO ALUNO DIGITADO, EXISTE NO BANCO
            string id = "SELECT COUNT (*) AS CONT_ID FROM alunos WHERE aluno_id = '" + txtId.Text + "';";

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

                //SE O COUNT RETORNAR 0, SIGNIFICA QUE O ID DIGITADO NÃO EXISTE
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

                //CASO RETORNE DIFERENTE DE 0, SIGNIFICA QUE EXISTE NO BANCO.
                //EXISTINDO, RODA AS CONSULTAS ABAIXO
                else //(id == "1")
                {
                    pctId_Erro.Visible = true;

                    pctId_Erro.BackgroundImage = Properties.Resources.voto_positivo;

                    id1.Visible = false;

                    txtId.BackColor = Color.LightGreen;

                    //MOSTRAR AO USUARIO O ALUNO REFERENTE AO ID SELECIONADO.
                    SqlConnection cn1 = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

                    //COMANDO SQL
                    string sql = "SELECT * FROM alunos WHERE aluno_id = '" + txtId.Text + "';";

                    //EXECUTO OS COMANDOS
                    SqlCommand cmd = new SqlCommand(sql, cn1);

                    //ABRO A CONEXÃO
                    cn1.Open();

                    try
                    {
                        //DATA READER, LENDO OS DADOS DO BANCO
                        SqlDataReader Buscar = cmd.ExecuteReader();

                        //AO LER, INSERE OS VALORES NAS TEXT's BOX
                        if (Buscar.Read())
                        {
                            txtMatricula.Text = Buscar["aluno_matricula"].ToString();
                            txtNome.Text      = Buscar["aluno_nome"].ToString();
                            txtCpf.Text       = Buscar["aluno_cpf"].ToString();

                        }
                        //CASO NAO ENCONTRE...
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

        private void btnAnexo_Click(object sender, EventArgs e)
        {
            if ((txtNomeDoc.Text == "" || txtTpDoc.Text == "" || txtQtHoras.Text == "") || (txtNomeDoc.Text == "" && txtTpDoc.Text == "" && txtQtHoras.Text == ""))
            {
                MessageBox.Show("Não é possivel prosseguir pois, há campos que se encontram em branco !\nPreencha todos os campos e tente novamente !", "CAMPOS VÁZIOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtId.BackColor == Color.LightCoral)
            {
                MessageBox.Show("Não é possivel prosseguir pois, este aluno não existe !\n\nPara efetuar o envio do certificado, \ncadastre o aluno com o ID ("+txtId.Text+") informado!", "ALUNO INEXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if(txtIdDoc.BackColor == Color.LightCoral)
            {
                MessageBox.Show("Não é possivel prosseguir, este ID de documento já existe !\n\nDigite outro ID de Documento", "ID DE DOCUMENTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else 
            {
                //ABRINDO O WINDOWS EXPLORER, PARA REALIZAR O UPLOAD
                //DE ALGUM ARQUIVO/FILE

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //RETORNA O NOME DO ARQUIVO SELECIONADO
                    string nomeArquivo = openFileDialog1.FileName;

                    Bitmap bmp = new Bitmap(nomeArquivo);

                    //EXIBIR A IMAGEM NO CONTROLE PICTUREBOX
                    pctAnexo.Image = bmp;


                    //CONFIRMAÇÃO DE IMAGEM, POIS PODE OCORRER DO USUARIO SELECIONAR UMA IMAGEM INCORRETA
                    //ANTES DE RODAR OS COMANDOS DE INSERÇÃO FAZ ESSA VERIFICAÇÃO SE É REALMENTE ESTA IMAGEM QUE DEVE SER INSERIDA.

                    if (MessageBox.Show("CONFIRMA O ENVIO DESTA IMAGEM ?\n\nCONFIRMA OS DADOS DIGITADOS ?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //TRANSNFORMANDO A IMAGEM E UM ARRAY DE BYTES
                        //PARA SER ARMAZENADA NO BANCO DE FORMA BINÁRIA

                        MemoryStream ms = new MemoryStream();

                        bmp.Save(ms, ImageFormat.Bmp);

                        byte[] certificado = ms.ToArray();


                        //STRING DE CONEXÃO AO BANCO
                        SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

                        //COMANDO SQL
                        string sql = "insert into alunos_documentos (id_documento, aluno_id, aluno_nome_documento, aluno_tipo_atividade, aluno_qt_horas, aluno_status, aluno_documento) values(@id_documento, @aluno_id, @aluno_nome_documento, @aluno_tipo_atividade, @aluno_qt_horas, @aluno_status, @aluno_documento)";


                        //EXECUTANDO OS DOIS COMANDOS ACIMA 
                        SqlCommand cmd = new SqlCommand(sql, cn);


                        //PARAMETROS A SEREM INSERIDOS NO BANCO
                        SqlParameter paramCerti = new SqlParameter("@aluno_documento", SqlDbType.Binary);
                        paramCerti.Value = certificado;

                        cmd.Parameters.Add(new SqlParameter("@id_documento", this.txtIdDoc.Text));
                        cmd.Parameters.Add(new SqlParameter("@aluno_id", this.txtId2.Text));
                        cmd.Parameters.Add(new SqlParameter("@aluno_nome_documento", this.txtNomeDoc.Text));
                        cmd.Parameters.Add(new SqlParameter("@aluno_tipo_atividade", this.txtTpDoc.Text));
                        cmd.Parameters.Add(new SqlParameter("@aluno_qt_horas", this.txtQtHoras.Text));
                        cmd.Parameters.Add(new SqlParameter("@aluno_status", this.txtStatus.Text));
                        cmd.Parameters.Add(paramCerti);

                        //MENSAGEM DE SUCESSO!
                        MessageBox.Show("Certificado Enviado Para Ánalise !\n\nAguarde a Homologação do Documento !", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        //APÓS INSERIR LIMPA OS CAMPOS
                        pctAnexo.Image = null;
                        txtIdDoc.Text = "";
                        txtNomeDoc.Text = "";
                        txtTpDoc.Text = "";
                        txtQtHoras.Text = "";
                        


                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }

                    //SE CASO O USUARIO, INSERIR UMA IMAGEM INCORRETA
                    //LIMPA OS CAMPOS, E ELE PODERÁ REALIZAR UMA NOVA SELEÇÃO.
                    else
                    {
                        pctAnexo.Image = null;

                        txtIdDoc.Text = "";
                        txtNomeDoc.Text = "";
                        txtTpDoc.Text = "";
                        txtQtHoras.Text = "";
                        
                    }
                }
                else
                {
                    //
                }
            }
        }

        private void txtIdDoc_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=PCDANIEL\SQLEXPRESS;Initial Catalog=Certificado;User ID=sa;Password=danielonet1");

            //VERIFICANDO SE O ID DO ALUNO DIGITADO, EXISTE NO BANCO
            string id = "SELECT COUNT (*) AS CONT_ID_DOCUMENTO FROM alunos_documentos WHERE id_documento = '" + txtIdDoc.Text + "' AND aluno_id = '" + txtId.Text + "';";

            SqlCommand cmd_doc = new SqlCommand(id, cn);

            cn.Open();

            //LÊ O COUNT ID
            SqlDataReader read_id = cmd_doc.ExecuteReader();


            if (read_id.Read())
            {
                id = read_id["CONT_ID_DOCUMENTO"].ToString();


                //VERIFICAR PRIMEIRAMENTE SE A TEXT BOX ESTA VAZIA.
                //EM TODOS AS VALIDAÇÕES

                if ((txtIdDoc.Text == "" || id == "") || (txtIdDoc.Text == "" && id == ""))
                {
                    pctDoc_Erro.Visible = false;

                    txtIdDoc.BackColor = Color.White;

                }

                //SE O COUNT RETORNAR 0, SIGNIFICA QUE O ID DE DOCUMENTO DIGITADO NÃO EXISTE
                else if (id == "0")
                {
                    pctDoc_Erro.Visible = true;

                    pctDoc_Erro.BackgroundImage = Properties.Resources.voto_positivo;

                    txtIdDoc.BackColor = Color.LightGreen;
                }

                //CASO RETORNE DIFERENTE DE 0, SIGNIFICA QUE EXISTE NO BANCO.
                //EXISTINDO NÃO PODERA SER ENVIADO DOCUMENTOS COM ID's IGUAIS.
                else //(id == "1")
                {
                    pctDoc_Erro.Visible = true;

                    pctDoc_Erro.BackgroundImage = Properties.Resources.erro;

                    txtIdDoc.BackColor = Color.LightCoral;
                }
            }
        }

        private void txtFoto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

