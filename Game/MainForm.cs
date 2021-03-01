using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace DT
{
    public partial class MainForm : Form
    {
        int tempoIdade = 1;
        int tamanho = 1;
        int horaUm = 1;
        int horaDois = 2;
        int minuto = 0;
        int segundo = 0;
        int petMove = 0;
        Monstro Pet = new Monstro();
        public MainForm()
        {
            InitializeComponent();
        }

        private void imagemPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarImagem = new OpenFileDialog();
            selecionarImagem.Filter = "Imagens Bitmap|*.png;*.jpg;*.bmp;";
            if (selecionarImagem.ShowDialog() == DialogResult.OK)
            {
                Image imagem = Image.FromFile(selecionarImagem.FileName);
                imagemPerfil.Image = imagem;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Pet.virarToko();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Pet.ToString(), "Informações do PET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            horario.Text = Convert.ToString(horaUm) + Convert.ToString(horaDois) + ":" + Convert.ToString(minuto) + Convert.ToString(segundo);
            segundo++;
            if (horaUm == 2 && horaDois > 3)
            {
                horaUm = 0;
                horaDois = 0;
                minuto = 0;
                segundo = 0;
            }
            else
            {
                if (segundo > 9)
                {
                    segundo = 0;
                    minuto += 1;
                    if (minuto > 5)
                    {
                        minuto = 0;
                        segundo = 0;
                        horaDois += 1;
                        if (horaDois > 9)
                        {
                            horaUm += 1;
                            segundo = 0;
                            minuto = 0;
                            horaDois = 0;
                        }
                    }
                }
            }
        }

        private void btnPresente_Click(object sender, EventArgs e)
        {

        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void move_Tick(object sender, EventArgs e)
        {
            petMove++;
            if (petMove.Equals(80))
            {
                petImagem.Location = new Point(128, 59);
                petMove = 0;
            }
            else
            {
                if (petMove.Equals(10))
                {
                    petImagem.Location = new Point(155, 59);
                }
                else if (petMove.Equals(20))
                {
                    petImagem.Location = new Point(190, 59);
                }
                else if (petMove.Equals(30))
                {
                    petImagem.Location = new Point(155, 59);
                }
                else if (petMove.Equals(40))
                {
                    petImagem.Location = new Point(128, 59);
                }
                else if (petMove.Equals(50))
                {
                    petImagem.Location = new Point(95, 59);
                }
                else if (petMove.Equals(60))
                {
                    petImagem.Location = new Point(60, 59);
                }
                else if (petMove.Equals(70))
                {
                    petImagem.Location = new Point(95, 59);
                }
            }
        }
        private void carregarJogo_Click(object sender, EventArgs e)
        {
            //Em breve
        }

        private void btnOpcoes_Click(object sender, EventArgs e)
        {
            Opcoes opcoes = new Opcoes();
            opcoes.ShowDialog();
        }

        private void btnBatalhar_Click(object sender, EventArgs e)
        {
            BattleForm batalha = new BattleForm();
            switch (Pet.Estagio)
            {
                case "Bebê":
                    MessageBox.Show("Seu Pet não pode batalhar pois ele ainda é um bebê!", "Não foi possível continuar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "Criança":
                    //Imagem apenas para teste.
                    batalha.petImagem.Image = Properties.Resources.toko;
                    batalha.petHP.Value = Pet.Vida;
                    batalha.txtPet.Text = Pet.Nome;
                    batalha.ShowDialog();
                    break;
            }
        }
        // Não funcional:
        
        private void btnPetTreinar_Click(object sender, EventArgs e)
        {
            petImagem.Location = new Point(141, 73);
            petAndando.Enabled = false;
            treinamento.Enabled = true;

        }
        int treinando;
        private void treinamento_Tick(object sender, EventArgs e)
        {
            treinando++;
            if (treinando == 40)
            {
                Pet.descerFome();
                Pet.checarTudo();
                Pet.mensagemTreinar();
                Pet.ganharExp();
                Pet.Força += 1;
                Pet.Vida += 1;
                System.Threading.Thread.Sleep(250);
                treinando = 0;
                petAndando.Enabled = true;
                treinamento.Stop();
            }
        }
    }
}
