using System;
using System.Windows.Forms;

namespace DT
{
    public partial class Opcoes : Form
    {
        public Opcoes()
        {
            InitializeComponent();
        }

        private void Opcoes_Load(object sender, EventArgs e)
        {
            boxDesign.Text = "Clássico (Preto e vermelho)";
            boxEstilo.Text = "Clássica";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
