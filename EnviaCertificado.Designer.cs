
namespace Desafio_Jix
{
    partial class EnviaDocumento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pctDoc_Erro = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdDoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtHoras = new System.Windows.Forms.TextBox();
            this.txtTpDoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pctAnexo = new System.Windows.Forms.PictureBox();
            this.txtNomeDoc = new System.Windows.Forms.TextBox();
            this.txtId2 = new System.Windows.Forms.TextBox();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.pctId_Erro = new System.Windows.Forms.PictureBox();
            this.id1 = new System.Windows.Forms.Label();
            this.txtMatricula2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDoc_Erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnexo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctId_Erro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.pctDoc_Erro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtIdDoc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQtHoras);
            this.groupBox1.Controls.Add(this.txtTpDoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pctAnexo);
            this.groupBox1.Controls.Add(this.txtNomeDoc);
            this.groupBox1.Controls.Add(this.txtId2);
            this.groupBox1.Controls.Add(this.btnAnexo);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(354, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 505);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envio de Documentos";
            // 
            // pctDoc_Erro
            // 
            this.pctDoc_Erro.BackgroundImage = global::Desafio_Jix.Properties.Resources.voto_positivo;
            this.pctDoc_Erro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctDoc_Erro.Location = new System.Drawing.Point(546, 119);
            this.pctDoc_Erro.Name = "pctDoc_Erro";
            this.pctDoc_Erro.Size = new System.Drawing.Size(23, 23);
            this.pctDoc_Erro.TabIndex = 20;
            this.pctDoc_Erro.TabStop = false;
            this.pctDoc_Erro.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(476, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Documento ID:";
            // 
            // txtIdDoc
            // 
            this.txtIdDoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdDoc.Location = new System.Drawing.Point(480, 120);
            this.txtIdDoc.MaxLength = 40;
            this.txtIdDoc.Name = "txtIdDoc";
            this.txtIdDoc.Size = new System.Drawing.Size(55, 22);
            this.txtIdDoc.TabIndex = 32;
            this.txtIdDoc.TextChanged += new System.EventHandler(this.txtIdDoc_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(481, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Status:";
            this.label8.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStatus.Location = new System.Drawing.Point(481, 396);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(138, 23);
            this.txtStatus.TabIndex = 30;
            this.txtStatus.Text = "Não Homologado";
            this.txtStatus.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(477, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Quantidade de Horas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(479, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tipo de Atividade:";
            // 
            // txtQtHoras
            // 
            this.txtQtHoras.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtHoras.Location = new System.Drawing.Point(481, 328);
            this.txtQtHoras.MaxLength = 40;
            this.txtQtHoras.Name = "txtQtHoras";
            this.txtQtHoras.Size = new System.Drawing.Size(55, 22);
            this.txtQtHoras.TabIndex = 27;
            // 
            // txtTpDoc
            // 
            this.txtTpDoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTpDoc.Location = new System.Drawing.Point(481, 251);
            this.txtTpDoc.MaxLength = 40;
            this.txtTpDoc.Name = "txtTpDoc";
            this.txtTpDoc.Size = new System.Drawing.Size(138, 22);
            this.txtTpDoc.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(481, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nome Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(481, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Aluno ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(123, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Anexar Certificado";
            // 
            // pctAnexo
            // 
            this.pctAnexo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctAnexo.Location = new System.Drawing.Point(30, 38);
            this.pctAnexo.Name = "pctAnexo";
            this.pctAnexo.Size = new System.Drawing.Size(410, 316);
            this.pctAnexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAnexo.TabIndex = 6;
            this.pctAnexo.TabStop = false;
            // 
            // txtNomeDoc
            // 
            this.txtNomeDoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeDoc.Location = new System.Drawing.Point(481, 186);
            this.txtNomeDoc.MaxLength = 40;
            this.txtNomeDoc.Name = "txtNomeDoc";
            this.txtNomeDoc.Size = new System.Drawing.Size(138, 22);
            this.txtNomeDoc.TabIndex = 21;
            // 
            // txtId2
            // 
            this.txtId2.Enabled = false;
            this.txtId2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId2.Location = new System.Drawing.Point(481, 59);
            this.txtId2.MaxLength = 3;
            this.txtId2.Name = "txtId2";
            this.txtId2.Size = new System.Drawing.Size(53, 22);
            this.txtId2.TabIndex = 20;
            // 
            // btnAnexo
            // 
            this.btnAnexo.BackgroundImage = global::Desafio_Jix.Properties.Resources.em_anexo;
            this.btnAnexo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnexo.Location = new System.Drawing.Point(30, 409);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(298, 74);
            this.btnAnexo.TabIndex = 0;
            this.btnAnexo.UseVisualStyleBackColor = true;
            this.btnAnexo.Click += new System.EventHandler(this.btnAnexo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtCpf);
            this.groupBox3.Controls.Add(this.txtNome);
            this.groupBox3.Controls.Add(this.txtMatricula);
            this.groupBox3.Controls.Add(this.pctId_Erro);
            this.groupBox3.Controls.Add(this.id1);
            this.groupBox3.Controls.Add(this.txtMatricula2);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(38, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 339);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(42, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "CPF:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(32, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Nome:";
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCpf.Location = new System.Drawing.Point(85, 268);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(118, 26);
            this.txtCpf.TabIndex = 19;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(85, 198);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(118, 23);
            this.txtNome.TabIndex = 18;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Enabled = false;
            this.txtMatricula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatricula.Location = new System.Drawing.Point(85, 125);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(54, 26);
            this.txtMatricula.TabIndex = 17;
            // 
            // pctId_Erro
            // 
            this.pctId_Erro.BackgroundImage = global::Desafio_Jix.Properties.Resources.voto_positivo;
            this.pctId_Erro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctId_Erro.Location = new System.Drawing.Point(153, 47);
            this.pctId_Erro.Name = "pctId_Erro";
            this.pctId_Erro.Size = new System.Drawing.Size(27, 26);
            this.pctId_Erro.TabIndex = 16;
            this.pctId_Erro.TabStop = false;
            this.pctId_Erro.Visible = false;
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id1.Location = new System.Drawing.Point(75, 24);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(78, 14);
            this.id1.TabIndex = 15;
            this.id1.Text = "Não existente !";
            this.id1.Visible = false;
            // 
            // txtMatricula2
            // 
            this.txtMatricula2.AutoSize = true;
            this.txtMatricula2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatricula2.Location = new System.Drawing.Point(17, 128);
            this.txtMatricula2.Name = "txtMatricula2";
            this.txtMatricula2.Size = new System.Drawing.Size(64, 20);
            this.txtMatricula2.TabIndex = 11;
            this.txtMatricula2.Text = "Matricula:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(85, 47);
            this.txtId.MaxLength = 3;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(54, 26);
            this.txtId.TabIndex = 6;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Aluno ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "DIGITE SEU ID PARA O ENVIO DO CERTIFICADO:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFoto
            // 
            this.txtFoto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFoto.Location = new System.Drawing.Point(1016, 499);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(21, 23);
            this.txtFoto.TabIndex = 32;
            this.txtFoto.Visible = false;
            this.txtFoto.TextChanged += new System.EventHandler(this.txtFoto_TextChanged);
            // 
            // EnviaDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1048, 543);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "EnviaDocumento";
            this.Text = "Enviar Documento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDoc_Erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnexo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctId_Erro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctAnexo;
        private System.Windows.Forms.Button btnAnexo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.PictureBox pctId_Erro;
        private System.Windows.Forms.Label id1;
        private System.Windows.Forms.Label txtMatricula2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtHoras;
        private System.Windows.Forms.TextBox txtTpDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeDoc;
        private System.Windows.Forms.TextBox txtId2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdDoc;
        private System.Windows.Forms.PictureBox pctDoc_Erro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}