using System;
using System.Drawing;
using System.Windows.Forms;
namespace VirtualTamer.Classes
{
    class Monstro
    {
        public string Nome;
        public string Estagio;
        public int Exp;
        public int Força;
        public int Vitoria;
        public int Fome;
        public int Vida;
        public int Idade;
        bool vivo = true;

        public void checarTudo()
        {
            checarSaude();
            checarVivo();
        }

        public void descerFome()
        {
            if (this.Estagio == "Bebê")
            {
                this.Fome -= 1;
            }
            else if (this.Estagio == "Criança")
            {
                this.Fome -= 2;
            }
            else if (this.Estagio == "Perfeito" || this.Estagio == "Dark")
            {
                this.Fome -= 3;
            }
            else if (this.Estagio == "Final")
            {
                this.Fome -= 4;
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

                case "Perfeito":
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
            switch(Estagio)
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

                case "Perfeito":
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
            if (this.Nome == "Toko" && Exp == 5 && Força == 10)
            {
                virarEvoToko();
            }
            else if (this.Nome == "EvoToko" && Exp == 10 && Força == 15 && Idade == 5)
            {
                virarUltimateToko();
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
            return "\n" + "Nome: " + Nome + "              Estagio: "+ Estagio + "\nExperiência: " + Exp + "\nForça: " + Força + "\nVida: " + Vida + "\nIdade: " + Idade + "\nFome: " + Fome;
        } 

        public void mensagemTreinar()
        {
            MessageBox.Show("- A força do " + Nome + " subiu +1\n- A vida do " + Nome + " subiu +1\n\n" + Nome + " ganhou +1 de experiência!" , "Informações do Treino");
        }

        //Pets:

        public void virarToko()
        {
            Nome = "Toko";
            Estagio = "Bebê";
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
        public void virarUltimateToko()
        {
            //Requer idade 10 / Peso 2.50 ou superior / Vitória maior que 15 / Dano 15
            Nome = "UltimateToko";
            Estagio = "Ultimate";
            Vitoria = 15;
            Força = 15;
            Fome = 10;
            Idade = 10;
            Vida = 50;
        }
    }
}
