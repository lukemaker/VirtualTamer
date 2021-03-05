using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace DT
{
    public partial class MainForm : Form
    {
        int horaUm = 1;
        int horaDois = 2;
        int minuto = 0;
        int segundo = 0;
        int petMove = 0;
        int treinando = 1;
        int atualizado = 10;
        int comer = 0;
        bool mover = false;
        bool centro = false;
        Monstro Pet = new Monstro();
        Database db = new Database();
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
            janelaInicial.Visible = true;
            janelaInicial.Dock = DockStyle.Fill;
            carregar();
        }

        private void carregar()
        {
            txtPerfil.Text = db._Perfil;
            this.Text = $"{db._NomeDoProduto}";
            // {Convert.ToString(db._VersaoDoProduto, CultureInfo.InvariantCulture)}
            Pet.virarToko();
            if (File.Exists(db.info1) && File.Exists(db.slot1local))
            {
                string[] slot = File.ReadAllLines(db.slot1local);
                horaUm = int.Parse(slot[0]);
                horaDois = int.Parse(slot[1]);
                minuto = int.Parse(slot[2]);
                segundo = int.Parse(slot[3]);
                string[] pet = File.ReadAllLines(db.info1);
                Pet.Nome = pet[0];
                Pet.Vida = int.Parse(pet[1]);
                Pet.Idade = int.Parse(pet[2]);
                Pet.Força = int.Parse(pet[3]);
                Pet.Fome = int.Parse(pet[4]);
                Pet.Exp = int.Parse(pet[5]);
                Pet.Vitoria = int.Parse(pet[6]);
                Pet.Estagio = pet[7];
                Pet.Derrota = int.Parse(pet[8]);
                Pet.Mistake = int.Parse(pet[9]);
                Pet.vivo = bool.Parse(pet[10]);
                salvarJanela.Visible = false;
                hora();
            }
            else
            {

            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Pet.ToString(), "Informações do PET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            if (Pet.vivo == true)
            {
                hora();
                segundo++;
                if (horaUm == 2 && horaDois > 3)
                {
                    checarPeriodo();
                    Pet.Dias += 1;
                    Pet.checarDias(); // Método que irá checar os dias para evoluir o pet.
                    horaUm = 0;
                    horaDois = 0;
                    minuto = 0;
                    segundo = 0;
                    petImagem.Image = Pet.pet;
                    mover = true;
                    petImagem.Size = new Size(100, 95);
                    centralizar();
                    if (Pet.vivo == false)
                    {
                        mover = false;
                    }
                }
                else
                {
                    if (segundo > 9)
                    {
                        checarPeriodo();
                        segundo = 0;
                        minuto += 1;
                        if (minuto > 5)
                        {
                            checarPeriodo();
                            minuto = 0;
                            segundo = 0;
                            horaDois += 1;
                            if (horaDois > 9)
                            {
                                checarPeriodo();
                                horaUm += 1;
                                segundo = 0;
                                minuto = 0;
                                horaDois = 0;
                            }
                        }
                    }
                }
            }
        }
        void centralizar()
        {
            petMove = 0;
            petImagem.Location = new Point(149, 63);
        }
        public void checarPeriodo()
        {
            if (horaUm == 1 && horaDois == 2)
            {
                txtInfoDia.Text = "Tarde";
            }
            else if (horaUm == 1 && horaDois == 8)
            {
                txtInfoDia.Text = "Noite";
            }
            else if (horaUm == 0 && horaDois == 0)
            {
                txtInfoDia.Text = "Manhã";
            }
        }
        void hora()
        {
            horario.Text = Convert.ToString(horaUm) + Convert.ToString(horaDois) + ":" + Convert.ToString(minuto) + Convert.ToString(segundo);
        }


        private void btnSobre_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void move_Tick(object sender, EventArgs e)
        {
            if (mover == false)
            {

            }
            else
            {
                petMove++;
                if (petMove.Equals(80))
                {
                    centralizar();
                    petMove = 0;
                }
                else
                {
                    if (petMove.Equals(10))
                    {
                        petImagem.Location = new Point(180, 63);
                    }
                    else if (petMove.Equals(20))
                    {
                        petImagem.Location = new Point(220, 63);
                    }
                    else if (petMove.Equals(30))
                    {
                        petImagem.Location = new Point(177, 63);
                    }
                    else if (petMove.Equals(40))
                    {
                        petImagem.Location = new Point(125, 63);
                    }
                    else if (petMove.Equals(50))
                    {
                        petImagem.Location = new Point(73, 63);
                    }
                    else if (petMove.Equals(60))
                    {
                        petImagem.Location = new Point(28, 63);
                    }
                    else if (petMove.Equals(70))
                    {
                        petImagem.Location = new Point(81, 63);
                    }
                }
            }
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnTreinar_Click(object sender, EventArgs e)
        {
            petImagem.Location = new Point(128, 59);
            move.Enabled = false;
            treinamento.Enabled = true;
        }
        private void btnCarregarJogo_Click(object sender, EventArgs e)
        {
            processarArquivo();
        }
        private void btnCarregarJogoDois_Click(object sender, EventArgs e)
        {
            processarArquivoDois();
        }
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
                move.Enabled = true;
                treinamento.Stop();
            }
        }
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (btnCarregar.Text == "Voltar")
            {
                btnCarregar.Text = "Arquivos";
                salvarJanela.Visible = false;
            }
            else
            {
                salvarJanela.Visible = true;
                salvarJanela.Dock = DockStyle.Fill;
                btnCarregar.Text = "Voltar";
                carregarArquivo();
                carregarArquivoDois();
            }
        }
        void processarArquivo()
        {
            if (File.Exists(db.slot1local) && File.Exists(db.info1))
            {
                string[] slot = File.ReadAllLines(db.slot1local);
                horaUm = int.Parse(slot[0]);
                horaDois = int.Parse(slot[1]);
                minuto = int.Parse(slot[2]);
                segundo = int.Parse(slot[3]);
                string[] pet = File.ReadAllLines(db.info1);
                Pet.Nome = pet[0];
                Pet.Vida = int.Parse(pet[1]);
                Pet.Idade = int.Parse(pet[2]);
                Pet.Força = int.Parse(pet[3]);
                Pet.Fome = int.Parse(pet[4]);
                Pet.Exp = int.Parse(pet[5]);
                Pet.Vitoria = int.Parse(pet[6]);
                Pet.Estagio = pet[7];
                Pet.Derrota = int.Parse(pet[8]);
                Pet.Mistake = int.Parse(pet[9]);
                Pet.vivo = bool.Parse(pet[10]);
                salvarJanela.Visible = false;
                hora();
            }
            else
            {
                msgArquivo();
            }
        }
        void processarArquivoDois()
        {
            if (File.Exists(db.slot2local) && File.Exists(db.info2))
            {
                string[] slot = File.ReadAllLines(db.slot2local);
                horaUm = int.Parse(slot[0]);
                horaDois = int.Parse(slot[1]);
                minuto = int.Parse(slot[2]);
                segundo = int.Parse(slot[3]);
                string[] pet = File.ReadAllLines(db.info2);
                Pet.Nome = pet[0];
                Pet.Vida = int.Parse(pet[1]);
                Pet.Idade = int.Parse(pet[2]);
                Pet.Força = int.Parse(pet[3]);
                Pet.Fome = int.Parse(pet[4]);
                Pet.Exp = int.Parse(pet[5]);
                Pet.Vitoria = int.Parse(pet[6]);
                Pet.Estagio = pet[7];
                Pet.Derrota = int.Parse(pet[8]);
                Pet.Mistake = int.Parse(pet[9]);
                Pet.vivo = bool.Parse(pet[10]);
                salvarJanela.Visible = false;
                hora();
            }
            else
            {
                msgArquivo();
            }
        }
        void carregarArquivo()
        {
            if (File.Exists(db.slot1local) && File.Exists(db.info1))
            {
                string[] slot1 = File.ReadAllLines(db.info1);
                txtInfoPet.Text = $"Nome: {slot1[0]}\nEstágio: {slot1[7]}\nIdade: {slot1[2]}\nExp: {slot1[5]}\nForça: {slot1[3]}";
                txtInfo2Pet.Text = $"Fome: {slot1[4]}\nVida: {slot1[1]}\nVitoria: {slot1[6]}\nDerrotas: {slot1[8]}";
                string[] time1 = File.ReadAllLines(db.slot1local);
                txtSaveName.Text = $"Slot 1 - {time1[0]}{time1[1]}:{time1[2]}{time1[3]}";
            }
            else
            {
                txtSaveName.Text = "Slot 1 vazio";
                txtInfoPet.Text = "Nenhum arquivo salvo.";
                txtInfo2Pet.Text = "";
            }
        }
        void carregarArquivoDois()
        {
            if (File.Exists(db.slot2local) && File.Exists(db.info2))
            {
                string[] slot2 = File.ReadAllLines(db.info2);
                txtInfoPet2.Text = $"Nome: {slot2[0]}\nEstágio: {slot2[7]}\nIdade: {slot2[2]}\nExp: {slot2[5]}\nForça: {slot2[3]}";
                txtInfo2Pet2.Text = $"Fome: {slot2[4]}\nVida: {slot2[1]}\nVitoria: {slot2[6]}\nDerrotas: {slot2[8]}";
                string[] time2 = File.ReadAllLines(db.slot2local);
                txtSaveNameDois.Text = $"Slot 2 - {time2[0]}{time2[1]}:{time2[2]}{time2[3]}";
            }
            else
            {
                txtSaveNameDois.Text = "Slot 2 vazio";
                txtInfoPet2.Text = "Nenhum arquivo salvo.";
                txtInfo2Pet2.Text = "";
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (aguarde.Enabled == false)
            {
                btnAtualizar.Text = "Atualizando...";
                carregarArquivo();
                carregarArquivoDois();
                aguarde.Start();
            }
        }
        private void aguarde_Tick(object sender, EventArgs e)
        {
            btnAtualizar.Text = $"Aguarde {atualizado}s";
            atualizado--;
            if (atualizado == 0)
            {
                btnAtualizar.Text = "Atualizar";
                atualizado = 10;
                aguarde.Stop();
            }
        }
        void msgArquivo()
        {
            MessageBox.Show("Não foi possível localizar o arquivo.", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnPresente_Click(object sender, EventArgs e)
        {
            // Em breve.
        }

        private void btnDeletarJogo_Click(object sender, EventArgs e)
        {
            DeleteFile df = new DeleteFile();
            df.Text = "Deletar arquivo - slot 1";
            df.ShowDialog();
        }

        private void btnDeletarJogoDois_Click(object sender, EventArgs e)
        {
            DeleteFile df = new DeleteFile();
            df.Text = "Deletar arquivo - slot 2";
            df.ShowDialog();
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            dirEsq();
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            dirEsq();
        }
        void dirEsq()
        {
            switch (centro)
            {
                case false:
                    eggImagem.Image = db.eggDark;
                    centro = true;
                    break;
                case true:
                    eggImagem.Image = db.eggCasual;
                    centro = false;
                    break;
            }
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            if (centro == false)
            {
                horaUm = 1;
                horaDois = 2;
                minuto = 0;
                segundo = 0;
                petImagem.Image = db.eggCasual;
                Pet.eggInicialCasual();
                janelaInicial.Visible = false;
            }
            else
            {
                petImagem.Image = db.eggCasual;
                Pet.eggInicialEscuro();
                janelaInicial.Visible = false;
            }
        }

        private void comendo_Tick(object sender, EventArgs e)
        {
            comer++;
            comida.Visible = true;
            if (comer == 5)
            {
                comida.Visible = false;
                if (Pet.Fome == 0)
                {
                    comendo.Stop();
                }
                else
                {
                    Pet.Fome -= 1;
                    comendo.Stop();
                    move.Start();
                }
            }
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            centralizar();
            move.Stop();
            comendo.Start();
            comida.Image = db.carne;
        }
    }
}
