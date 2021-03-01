using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
