using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace VirtualTamer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        int tempoIdade = 1;
        int tamanho = 1;
        int horaUm = 1;
        int horaDois = 2;
        int minuto = 0;
        int segundo = 0;
        int petMove = 0;
        Classes.Monstro Pet = new Classes.Monstro();
        private void MainForm_Load(object sender, EventArgs e)
        {
            Pet.virarToko();
        }
        private void btnPetInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Pet.ToString(), "Informações do PET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void petAndando_Tick(object sender, EventArgs e)
        {
            //Neste método, a imagem do PET irá se mover dentro do panel "tamaArea".
            petMove++;
            if (petMove.Equals(80))
            {
                petImagem.Location = new Point(141, 73);
                petMove = 0;
            }
            else
            {
                if (petMove.Equals(10))
                {
                    petImagem.Location = new Point(188, 73);
                }
                else if (petMove.Equals(20))
                {
                    petImagem.Location = new Point(248, 73);
                }
                else if (petMove.Equals(30))
                {
                    petImagem.Location = new Point(188, 73);
                }
                else if (petMove.Equals(40))
                {
                    petImagem.Location = new Point(141, 73);
                }
                else if (petMove.Equals(50))
                {
                    petImagem.Location = new Point(90, 73);
                }
                else if (petMove.Equals(60))
                {
                    petImagem.Location = new Point(46, 73);
                }
                else if (petMove.Equals(70))
                {
                    petImagem.Location = new Point(90, 73);
                }
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void periodos_Tick(object sender, EventArgs e)
        {
            if (horaUm == 1 && horaDois == 8)
            {
                periodo.Text = "Noite";
            }
            else if (horaUm == 0 && horaDois == 0)
            {
                periodo.Text = "Manhã";
            }
            else if (horaUm == 1 && horaDois == 2)
            {
                periodo.Text = "Tarde";
            }
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
            else
            {
                //O else significa que quando fechar o FileDialog, nada irá ocorrer, apenas irá fechar normalmente.
            }
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            if (tamanho == 1)
            {
                this.Size = new Size(785, 434);
                tamanho += 1;
            }
            else
            {
                tamanho = 1;
                this.Size = new Size(637, 434);
            }
        }
        Forms.BattleForm batalha = new Forms.BattleForm();
        private void btnBatalhar_Click(object sender, EventArgs e)
        {
            if (Pet.Estagio.Equals("Bebê"))
            {
                MessageBox.Show("O " + Pet.Nome + " não pode batalhar!\nEle está no estágio " + Pet.Estagio + ".");
            }
            else
            {
                batalha.ShowDialog();
            }
        }
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
        MainForm novodt = new MainForm();
        private void btnNovoDT_Click(object sender, EventArgs e)
        {
            if (novodt.ShowDialog() == DialogResult.OK)
            {
                btnNovoDT.Enabled = true;
            }
            else
            {
                btnNovoDT.Enabled = false;
                novodt.Show();
                novodt.btnNovoDT.Enabled = false;
            }
        }
    }
}
