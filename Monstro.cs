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
        //Metódo Evoluir apenas para testes.
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
            else
            {

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
            Força = 1;
            Vida = 10;
            Fome = 10;
            Idade = 1;
        }
        public void virarEvoToko()
        {
            //Requer idade 5 / Dano 7
            Nome = "EvoToko";
            Estagio = "Criança";
            Vitoria = 0;
            Força = 10;
            Fome = 10;
            Idade = 5;
            Vida = 25;
        }
        public void virarMegaToko()
        {
            //Requer idade 10 / Peso 2.50 ou superior / Vitória maior que 15 / Dano 15
            Nome = "MegaToko";
            Estagio = "Mega";
            Vitoria = 15;
            Força = 15;
            Fome = 10;
            Idade = 10;
            Vida = 50;
        }
    }
}
