
namespace Desafio_Jix
{
    partial class Visualizar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridDocumentos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNova = new System.Windows.Forms.Label();
            this.btnNova = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.pctId_Erro = new System.Windows.Forms.PictureBox();
            this.txtCpf2 = new System.Windows.Forms.Label();
            this.txtMatricula2 = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.Label();
            this.txtNome2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxExibeDocs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pctExibir = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridDocumentos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctId_Erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExibir)).BeginInit();
            this.SuspendLayout();
            // 
            // GridDocumentos
            // 
            this.GridDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridDocumentos.Location = new System.Drawing.Point(323, 49);
            this.GridDocumentos.Name = "GridDocumentos";
            this.GridDocumentos.RowTemplate.Height = 25;
            this.GridDocumentos.Size = new System.Drawing.Size(598, 193);
            this.GridDocumentos.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox2.Controls.Add(this.lblNova);
            this.groupBox2.Controls.Add(this.btnNova);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Controls.Add(this.txtCpf);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.txtMatricula);
            this.groupBox2.Controls.Add(this.pctId_Erro);
            this.groupBox2.Controls.Add(this.txtCpf2);
            this.groupBox2.Controls.Add(this.txtMatricula2);
            this.groupBox2.Controls.Add(this.id1);
            this.groupBox2.Controls.Add(this.txtNome2);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(30, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 589);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // lblNova
            // 
            this.lblNova.AutoSize = true;
            this.lblNova.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNova.Location = new System.Drawing.Point(94, 527);
            this.lblNova.Name = "lblNova";
            this.lblNova.Size = new System.Drawing.Size(90, 20);
            this.lblNova.TabIndex = 23;
            this.lblNova.Text = "Nova Consulta";
            this.lblNova.Visible = false;
            // 
            // btnNova
            // 
            this.btnNova.BackgroundImage = global::Desafio_Jix.Properties.Resources.nova_pagina;
            this.btnNova.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNova.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNova.Location = new System.Drawing.Point(48, 450);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(178, 72);
            this.btnNova.TabIndex = 22;
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Visible = false;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(112, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Consultar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImage = global::Desafio_Jix.Properties.Resources.lupa;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Location = new System.Drawing.Point(48, 334);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(178, 72);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.EnabledChanged += new System.EventHandler(this.btnConsultar_EnabledChanged);
            this.btnConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCpf.Location = new System.Drawing.Point(48, 236);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(178, 26);
            this.txtCpf.TabIndex = 19;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(48, 176);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(178, 26);
            this.txtNome.TabIndex = 18;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Enabled = false;
            this.txtMatricula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatricula.Location = new System.Drawing.Point(48, 118);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(178, 26);
            this.txtMatricula.TabIndex = 17;
            // 
            // pctId_Erro
            // 
            this.pctId_Erro.BackgroundImage = global::Desafio_Jix.Properties.Resources.voto_positivo;
            this.pctId_Erro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctId_Erro.Location = new System.Drawing.Point(107, 59);
            this.pctId_Erro.Name = "pctId_Erro";
            this.pctId_Erro.Size = new System.Drawing.Size(27, 26);
            this.pctId_Erro.TabIndex = 16;
            this.pctId_Erro.TabStop = false;
            this.pctId_Erro.Visible = false;
            // 
            // txtCpf2
            // 
            this.txtCpf2.AutoSize = true;
            this.txtCpf2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCpf2.Location = new System.Drawing.Point(52, 216);
            this.txtCpf2.Name = "txtCpf2";
            this.txtCpf2.Size = new System.Drawing.Size(32, 16);
            this.txtCpf2.TabIndex = 14;
            this.txtCpf2.Text = "CPF:";
            // 
            // txtMatricula2
            // 
            this.txtMatricula2.AutoSize = true;
            this.txtMatricula2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatricula2.Location = new System.Drawing.Point(51, 98);
            this.txtMatricula2.Name = "txtMatricula2";
            this.txtMatricula2.Size = new System.Drawing.Size(52, 16);
            this.txtMatricula2.TabIndex = 11;
            this.txtMatricula2.Text = "Matricula:";
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id1.Location = new System.Drawing.Point(151, 66);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(78, 14);
            this.id1.TabIndex = 15;
            this.id1.Text = "Não existente !";
            this.id1.Visible = false;
            // 
            // txtNome2
            // 
            this.txtNome2.AutoSize = true;
            this.txtNome2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome2.Location = new System.Drawing.Point(51, 156);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(38, 16);
            this.txtNome2.TabIndex = 9;
            this.txtNome2.Text = "Nome:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(48, 59);
            this.txtId.MaxLength = 3;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(54, 26);
            this.txtId.TabIndex = 6;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(51, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Aluno ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(328, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Documentos Enviados";
            // 
            // cbxExibeDocs
            // 
            this.cbxExibeDocs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExibeDocs.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxExibeDocs.FormattingEnabled = true;
            this.cbxExibeDocs.Location = new System.Drawing.Point(379, 315);
            this.cbxExibeDocs.Name = "cbxExibeDocs";
            this.cbxExibeDocs.Size = new System.Drawing.Size(189, 31);
            this.cbxExibeDocs.TabIndex = 11;
            this.cbxExibeDocs.SelectedIndexChanged += new System.EventHandler(this.cbxExibeDocs_SelectedIndexChanged);
            this.cbxExibeDocs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxExibeDocs_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(379, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "SELECIONE O ID DO DOCUMENTO\r\n";
            // 
            // pctExibir
            // 
            this.pctExibir.Location = new System.Drawing.Point(612, 259);
            this.pctExibir.Name = "pctExibir";
            this.pctExibir.Size = new System.Drawing.Size(309, 379);
            this.pctExibir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExibir.TabIndex = 13;
            this.pctExibir.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(417, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "PARA VISUALIZA-LO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(30, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Selecione o ID do Aluno:\r\n";
            // 
            // Visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(939, 650);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pctExibir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxExibeDocs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GridDocumentos);
            this.Name = "Visualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos Enviados";
            ((System.ComponentModel.ISupportInitialize)(this.GridDocumentos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctId_Erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExibir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDocumentos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pctId_Erro;
        private System.Windows.Forms.Label id1;
        private System.Windows.Forms.Label txtCpf2;
        private System.Windows.Forms.Label txtMatricula2;
        private System.Windows.Forms.Label txtNome2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblNova;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxExibeDocs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pctExibir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

