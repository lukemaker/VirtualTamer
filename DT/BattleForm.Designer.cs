
namespace DT
{
    partial class BattleForm
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
            this.components = new System.ComponentModel.Container();
            this.tamaArea = new System.Windows.Forms.Panel();
            this.damageBox = new System.Windows.Forms.PictureBox();
            this.petVS = new System.Windows.Forms.PictureBox();
            this.petImagem = new System.Windows.Forms.PictureBox();
            this.gbHP = new System.Windows.Forms.GroupBox();
            this.petHP = new System.Windows.Forms.ProgressBar();
            this.txtVS = new System.Windows.Forms.TextBox();
            this.txtPet = new System.Windows.Forms.TextBox();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.petMove = new System.Windows.Forms.Timer(this.components);
            this.vsMove = new System.Windows.Forms.Timer(this.components);
            this.damageMove = new System.Windows.Forms.Timer(this.components);
            this.tamaArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.damageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petImagem)).BeginInit();
            this.gbHP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tamaArea
            // 
            this.tamaArea.BackColor = System.Drawing.Color.White;
            this.tamaArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tamaArea.Controls.Add(this.damageBox);
            this.tamaArea.Controls.Add(this.petVS);
            this.tamaArea.Controls.Add(this.petImagem);
            this.tamaArea.Location = new System.Drawing.Point(10, 43);
            this.tamaArea.Name = "tamaArea";
            this.tamaArea.Size = new System.Drawing.Size(398, 202);
            this.tamaArea.TabIndex = 1;
            // 
            // damageBox
            // 
            this.damageBox.BackColor = System.Drawing.Color.White;
            this.damageBox.Image = global::DT.Properties.Resources.sattack;
            this.damageBox.Location = new System.Drawing.Point(248, 77);
            this.damageBox.Name = "damageBox";
            this.damageBox.Size = new System.Drawing.Size(46, 42);
            this.damageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.damageBox.TabIndex = 4;
            this.damageBox.TabStop = false;
            this.damageBox.Visible = false;
            // 
            // petVS
            // 
            this.petVS.BackColor = System.Drawing.Color.White;
            this.petVS.Image = global::DT.Properties.Resources.toko;
            this.petVS.Location = new System.Drawing.Point(14, 59);
            this.petVS.Name = "petVS";
            this.petVS.Size = new System.Drawing.Size(98, 84);
            this.petVS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.petVS.TabIndex = 3;
            this.petVS.TabStop = false;
            // 
            // petImagem
            // 
            this.petImagem.BackColor = System.Drawing.Color.White;
            this.petImagem.Image = global::DT.Properties.Resources.toko;
            this.petImagem.Location = new System.Drawing.Point(286, 59);
            this.petImagem.Name = "petImagem";
            this.petImagem.Size = new System.Drawing.Size(98, 84);
            this.petImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.petImagem.TabIndex = 2;
            this.petImagem.TabStop = false;
            // 
            // gbHP
            // 
            this.gbHP.Controls.Add(this.petHP);
            this.gbHP.ForeColor = System.Drawing.Color.White;
            this.gbHP.Location = new System.Drawing.Point(10, 251);
            this.gbHP.Name = "gbHP";
            this.gbHP.Size = new System.Drawing.Size(397, 49);
            this.gbHP.TabIndex = 2;
            this.gbHP.TabStop = false;
            this.gbHP.Text = "Seu HP";
            // 
            // petHP
            // 
            this.petHP.Location = new System.Drawing.Point(15, 17);
            this.petHP.Name = "petHP";
            this.petHP.Size = new System.Drawing.Size(370, 23);
            this.petHP.TabIndex = 0;
            // 
            // txtVS
            // 
            this.txtVS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVS.Location = new System.Drawing.Point(10, 12);
            this.txtVS.Name = "txtVS";
            this.txtVS.Size = new System.Drawing.Size(176, 25);
            this.txtVS.TabIndex = 3;
            this.txtVS.Text = "<PetVS>";
            this.txtVS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPet
            // 
            this.txtPet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPet.Location = new System.Drawing.Point(231, 12);
            this.txtPet.Name = "txtPet";
            this.txtPet.Size = new System.Drawing.Size(176, 25);
            this.txtPet.TabIndex = 4;
            this.txtPet.Text = "<Pet>";
            this.txtPet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.ForeColor = System.Drawing.Color.White;
            this.lblVS.Location = new System.Drawing.Point(201, 15);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(16, 17);
            this.lblVS.TabIndex = 5;
            this.lblVS.Text = "X";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Red;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(313, 306);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 28);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Começar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            this.btnSair.Location = new System.Drawing.Point(10, 306);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 28);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Fechar";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // petMove
            // 
            this.petMove.Enabled = true;
            this.petMove.Interval = 30;
            this.petMove.Tick += new System.EventHandler(this.petMove_Tick);
            // 
            // vsMove
            // 
            this.vsMove.Interval = 20;
            // 
            // damageMove
            // 
            this.damageMove.Interval = 10;
            this.damageMove.Tick += new System.EventHandler(this.damageMove_Tick);
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(419, 344);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.txtPet);
            this.Controls.Add(this.txtVS);
            this.Controls.Add(this.gbHP);
            this.Controls.Add(this.tamaArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BattleForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batalha!";
            this.Load += new System.EventHandler(this.BattleForm_Load);
            this.tamaArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.damageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petImagem)).EndInit();
            this.gbHP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel tamaArea;
        private System.Windows.Forms.GroupBox gbHP;
        private System.Windows.Forms.Label lblVS;
        public System.Windows.Forms.PictureBox petVS;
        public System.Windows.Forms.PictureBox petImagem;
        public System.Windows.Forms.ProgressBar petHP;
        public System.Windows.Forms.TextBox txtVS;
        public System.Windows.Forms.TextBox txtPet;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.PictureBox damageBox;
        private System.Windows.Forms.Timer petMove;
        private System.Windows.Forms.Timer vsMove;
        private System.Windows.Forms.Timer damageMove;
    }
}