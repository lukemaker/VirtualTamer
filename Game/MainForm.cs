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
