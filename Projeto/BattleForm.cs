using System;
using System.Drawing;
using System.Windows.Forms;

namespace DT
{
    public partial class BattleForm : Form
    {
        int petm = 1;
        int dmm = 1;
        public BattleForm()
        {
            InitializeComponent();
        }

        private void BattleForm_Load(object sender, EventArgs e)
        {
            this.Text = "Batalha!";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            petMove.Enabled = true;
        }

        private void petMove_Tick(object sender, EventArgs e)
        {
            petm++;
            if (petm == 90)
            {
                petImagem.Location = new Point(286, 59);
                petMove.Stop();
            }
            else if (petm == 10)
            {
                petImagem.Location = new Point(286, 59);
            }
            else if (petm == 20)
            {
                petImagem.Location = new Point(281, 54);
            }
            else if (petm == 30)
            {
                petImagem.Location = new Point(278, 51);
            }
            else if (petm == 40)
            {
                petImagem.Location = new Point(275, 54);
            }
            else if (petm == 50)
            {
                damageMove.Start();
                petImagem.Location = new Point(270, 59);
            }
            else if (petm == 60)
            {
                petImagem.Location = new Point(275, 54);
            }
            else if (petm == 70)
            {
                petImagem.Location = new Point(278, 51);
            }
            else if (petm == 80)
            {
                petImagem.Location = new Point(281, 54);
            }
        }

        private void damageMove_Tick(object sender, EventArgs e)
        {
            dmm++;
            if (dmm == 80)
            {
                damageBox.Location = new Point(106, 71);
                damageBox.Visible = false;
                petVS.Image = Properties.Resources.boom;
                damageMove.Stop();
            }
            else if (dmm == 10)
            {
                damageBox.Visible = true;
                damageBox.Location = new Point(201, 71);
            }
            else if (dmm == 20)
            {
                damageBox.Location = new Point(185, 71);
            }
            else if (dmm == 30)
            {
                damageBox.Location = new Point(159, 71);
            }
            else if (dmm == 40)
            {
                damageBox.Location = new Point(142, 71);
            }
            else if (dmm == 50)
            {
                damageBox.Location = new Point(125, 71);
            }
            else if (dmm == 60)
            {
                damageBox.Location = new Point(111, 71);
            }
            else if (dmm == 70)
            {
                damageBox.Visible = false;
                petVS.Image = Properties.Resources.boom;
            }
        }
    }
}
