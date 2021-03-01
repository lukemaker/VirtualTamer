
namespace DT
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tamaArea = new System.Windows.Forms.Panel();
            this.petImagem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.horario = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.btnTreinar = new System.Windows.Forms.Button();
            this.btnDormir = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.btnBatalhar = new System.Windows.Forms.Button();
            this.btnBanheiro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPresente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpcoes = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imagemPerfil = new System.Windows.Forms.PictureBox();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.move = new System.Windows.Forms.Timer(this.components);
            this.treinamento = new System.Windows.Forms.Timer(this.components);
            this.tamaArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petImagem)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // tamaArea
            // 
            this.tamaArea.BackColor = System.Drawing.Color.White;
            this.tamaArea.Controls.Add(this.petImagem);
            this.tamaArea.Controls.Add(this.label1);
            this.tamaArea.Controls.Add(this.horario);
            this.tamaArea.Location = new System.Drawing.Point(26, 65);
            this.tamaArea.Name = "tamaArea";
            this.tamaArea.Size = new System.Drawing.Size(398, 233);
            this.tamaArea.TabIndex = 0;
            // 
            // petImagem
            // 
            this.petImagem.BackColor = System.Drawing.Color.White;
            this.petImagem.Image = global::DT.Properties.Resources.toko;
            this.petImagem.Location = new System.Drawing.Point(128, 59);
            this.petImagem.Name = "petImagem";
            this.petImagem.Size = new System.Drawing.Size(132, 120);
            this.petImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.petImagem.TabIndex = 2;
            this.petImagem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarde";
            // 
            // horario
            // 
            this.horario.AutoSize = true;
            this.horario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horario.Location = new System.Drawing.Point(11, 7);
            this.horario.Name = "horario";
            this.horario.Size = new System.Drawing.Size(49, 21);
            this.horario.TabIndex = 0;
            this.horario.Text = "00:00";
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Red;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(26, 18);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(95, 32);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Informação";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.BackColor = System.Drawing.Color.Red;
            this.btnAlimentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlimentar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlimentar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAlimentar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAlimentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlimentar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlimentar.ForeColor = System.Drawing.Color.White;
            this.btnAlimentar.Location = new System.Drawing.Point(127, 18);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(95, 32);
            this.btnAlimentar.TabIndex = 2;
            this.btnAlimentar.Text = "Alimentar";
            this.btnAlimentar.UseVisualStyleBackColor = false;
            // 
            // btnTreinar
            // 
            this.btnTreinar.BackColor = System.Drawing.Color.Red;
            this.btnTreinar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTreinar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTreinar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnTreinar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTreinar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreinar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreinar.ForeColor = System.Drawing.Color.White;
            this.btnTreinar.Location = new System.Drawing.Point(228, 18);
            this.btnTreinar.Name = "btnTreinar";
            this.btnTreinar.Size = new System.Drawing.Size(95, 32);
            this.btnTreinar.TabIndex = 3;
            this.btnTreinar.Text = "Treinar";
            this.btnTreinar.UseVisualStyleBackColor = false;
            this.btnTreinar.Click += new System.EventHandler(this.btnTreinar_Click);
            // 
            // btnDormir
            // 
            this.btnDormir.BackColor = System.Drawing.Color.Red;
            this.btnDormir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDormir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDormir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDormir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDormir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDormir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDormir.ForeColor = System.Drawing.Color.White;
            this.btnDormir.Location = new System.Drawing.Point(329, 18);
            this.btnDormir.Name = "btnDormir";
            this.btnDormir.Size = new System.Drawing.Size(95, 32);
            this.btnDormir.TabIndex = 4;
            this.btnDormir.Text = "Dormir";
            this.btnDormir.UseVisualStyleBackColor = false;
            // 
            // btnResetar
            // 
            this.btnResetar.BackColor = System.Drawing.Color.Red;
            this.btnResetar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResetar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnResetar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnResetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetar.ForeColor = System.Drawing.Color.White;
            this.btnResetar.Location = new System.Drawing.Point(329, 313);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(95, 32);
            this.btnResetar.TabIndex = 8;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.UseVisualStyleBackColor = false;
            // 
            // btnBatalhar
            // 
            this.btnBatalhar.BackColor = System.Drawing.Color.Red;
            this.btnBatalhar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatalhar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBatalhar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnBatalhar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBatalhar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatalhar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatalhar.ForeColor = System.Drawing.Color.White;
            this.btnBatalhar.Location = new System.Drawing.Point(127, 313);
            this.btnBatalhar.Name = "btnBatalhar";
            this.btnBatalhar.Size = new System.Drawing.Size(95, 32);
            this.btnBatalhar.TabIndex = 6;
            this.btnBatalhar.Text = "Batalhar";
            this.btnBatalhar.UseVisualStyleBackColor = false;
            this.btnBatalhar.Click += new System.EventHandler(this.btnBatalhar_Click);
            // 
            // btnBanheiro
            // 
            this.btnBanheiro.BackColor = System.Drawing.Color.Red;
            this.btnBanheiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanheiro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBanheiro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnBanheiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBanheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanheiro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanheiro.ForeColor = System.Drawing.Color.White;
            this.btnBanheiro.Location = new System.Drawing.Point(26, 313);
            this.btnBanheiro.Name = "btnBanheiro";
            this.btnBanheiro.Size = new System.Drawing.Size(95, 32);
            this.btnBanheiro.TabIndex = 5;
            this.btnBanheiro.Text = "Banheiro";
            this.btnBanheiro.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPresente);
            this.panel2.Controls.Add(this.btnInfo);
            this.panel2.Controls.Add(this.btnAlimentar);
            this.panel2.Controls.Add(this.btnResetar);
            this.panel2.Controls.Add(this.btnDormir);
            this.panel2.Controls.Add(this.tamaArea);
            this.panel2.Controls.Add(this.btnBanheiro);
            this.panel2.Controls.Add(this.btnTreinar);
            this.panel2.Controls.Add(this.btnBatalhar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(159, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 362);
            this.panel2.TabIndex = 10;
            // 
            // btnPresente
            // 
            this.btnPresente.BackColor = System.Drawing.Color.Red;
            this.btnPresente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPresente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPresente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPresente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresente.ForeColor = System.Drawing.Color.White;
            this.btnPresente.Location = new System.Drawing.Point(228, 313);
            this.btnPresente.Name = "btnPresente";
            this.btnPresente.Size = new System.Drawing.Size(95, 32);
            this.btnPresente.TabIndex = 9;
            this.btnPresente.Text = "Presente";
            this.btnPresente.UseVisualStyleBackColor = false;
            this.btnPresente.Click += new System.EventHandler(this.btnPresente_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 362);
            this.panel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpcoes);
            this.groupBox2.Controls.Add(this.btnSobre);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(14, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 125);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tópicos";
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.BackColor = System.Drawing.Color.Red;
            this.btnOpcoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcoes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOpcoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnOpcoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcoes.ForeColor = System.Drawing.Color.White;
            this.btnOpcoes.Location = new System.Drawing.Point(21, 25);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(92, 32);
            this.btnOpcoes.TabIndex = 12;
            this.btnOpcoes.Text = "Opções";
            this.btnOpcoes.UseVisualStyleBackColor = false;
            this.btnOpcoes.Click += new System.EventHandler(this.btnOpcoes_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.Red;
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobre.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSobre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Location = new System.Drawing.Point(21, 72);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(92, 32);
            this.btnSobre.TabIndex = 11;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(45, 315);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(72, 27);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imagemPerfil);
            this.groupBox1.Controls.Add(this.txtPerfil);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfil";
            // 
            // imagemPerfil
            // 
            this.imagemPerfil.BackColor = System.Drawing.Color.White;
            this.imagemPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imagemPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagemPerfil.Image = global::DT.Properties.Resources.dtprogram;
            this.imagemPerfil.Location = new System.Drawing.Point(11, 19);
            this.imagemPerfil.Name = "imagemPerfil";
            this.imagemPerfil.Size = new System.Drawing.Size(111, 93);
            this.imagemPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemPerfil.TabIndex = 2;
            this.imagemPerfil.TabStop = false;
            this.imagemPerfil.Click += new System.EventHandler(this.imagemPerfil_Click);
            // 
            // txtPerfil
            // 
            this.txtPerfil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfil.Location = new System.Drawing.Point(11, 118);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(111, 25);
            this.txtPerfil.TabIndex = 0;
            this.txtPerfil.Text = "<database._Perfil>";
            this.txtPerfil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tempo
            // 
            this.tempo.Enabled = true;
            this.tempo.Interval = 200;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // move
            // 
            this.move.Enabled = true;
            this.move.Interval = 230;
            this.move.Tick += new System.EventHandler(this.move_Tick);
            // 
            // treinamento
            // 
            this.treinamento.Tick += new System.EventHandler(this.treinamento_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(609, 362);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<Database._NomeDoProduto>";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tamaArea.ResumeLayout(false);
            this.tamaArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petImagem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tamaArea;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Button btnTreinar;
        private System.Windows.Forms.Button btnDormir;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Button btnBatalhar;
        private System.Windows.Forms.Button btnBanheiro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.PictureBox imagemPerfil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpcoes;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label horario;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPresente;
        private System.Windows.Forms.PictureBox petImagem;
        private System.Windows.Forms.Timer move;
        private System.Windows.Forms.Timer treinamento;
    }
}

