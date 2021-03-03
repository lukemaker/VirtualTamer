using System;
using System.Drawing;
using System.Windows.Forms;
namespace DT
{
    class Monstro
    {
        public string Nome;
        public string Estagio;
        public int Exp;
        public int Força;
        public int Vitoria;
        public int Derrota;
        public int Fome;
        public int Vida;
        public int Idade;
        public int Mistake;
        public int Corrupt;

        public bool vivo = true;

        public void checarTudo()
        {
            checarSaude();
            checarVivo();
        }

        public void descerFome()
        {
            switch (Estagio)
            {
                case "Bebê":
                    this.Fome -= 1;
                    break;

                case "Criança":
                    this.Fome -= 1;
                    break;

                case "Dark":
                    this.Fome -= 2;
                    break;

                case "Mega":
                    this.Fome -= 3;
                    break;

                case "Ultimate":
                    this.Fome -= 3;
                    break;
            }
        }
        public void subirFome()
        {
            switch (Estagio)
            {
                case "Bebê":
                    this.Fome += 1;
                    break;

                case "Criança":
                    this.Fome += 2;
                    break;

                case "Dark":
                    this.Fome += 2;
                    break;

                case "Mega":
                    this.Fome += 3;
                    break;

                case "Ultimate":
                    this.Fome += 3;
                    break;
            }
        }
        public void checarSaude()
        {
            if (this.Fome < 0 || this.Vida < 0)
            {
                vivo = false;
            }
        }

        public void ganharExp()
        {
            switch (Estagio)
            {
                case "Bebê":
                    this.Exp += 1;
                    break;

                case "Criança":
                    this.Exp += 2;
                    break;

                case "Dark":
                    this.Exp += 2;
                    break;

                case "Mega":
                    this.Exp += 3;
                    break;

                case "Ultimate":
                    this.Exp += 3;
                    break;
            }
        }
        public void checarVivo()
        {
            if (this.vivo == false)
            {
                MessageBox.Show("Seu PET morreu!");
                Application.Exit();
            }
        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nEstagio: {Estagio} \nExperiência: {Exp} \nForça: {Força}\nVida: {Vida} \nIdade: {Idade} \nFome: {Fome} \nMistakes: {Mistake}";
        }

        public void mensagemTreinar()
        {
            MessageBox.Show($"Seu pet acabou de treinar!", "Informações do Treino");
        }

        //Pets:

        public void virarToko()
        {
            Nome = "Toko";
            Estagio = "Criança";
            Vitoria = 0;
            Força = 0;
            Vida = 3;
            Fome = 3;
            Idade = 1;
        }
        public void virarEvoToko()
        {
            Nome = "EvoToko";
            Estagio = "Criança";
            ganharExp();
        }
        public void virarMegaToko()
        {
            Nome = "MegaToko";
            Estagio = "Mega";
            ganharExp();
        }
        public void virarShinka()
        {
            Nome = "Shinka";
            Estagio = "mega";
            ganharExp();
        }
        public void morrer()
        {
            vivo = false;
        }

        // Metódo Evoluir em desenvolvimento

        public void evoluir()
        {
            if (this.Nome == "Toko" && Exp >= 5 && Força >= 5)
            {
                virarEvoToko();
            }
            else if (this.Nome == "EvoToko" && Exp >= 10 && Exp <= 13 && Força >= 7 && Força <= 13)
            {
                virarMegaToko();
            }
            else if (this.Nome == "EvoToko" && Exp <= 10 && Exp >= 8 && Força >= 13 && Força <= 15)
            {
                virarShinka();
            }
            else
            {
                morrer();
            }
        }
    }
}
