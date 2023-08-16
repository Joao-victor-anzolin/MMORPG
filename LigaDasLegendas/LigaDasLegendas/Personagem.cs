using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LigaDasLegendas
{
    internal class Personagem
    {
        public string Classe { get; set; }
        public int Vida { get; set; }
        public int Forca { get; set; }
        public int Velocidade { get; set; }
        public int Nivel { get; set; }
        public int Defesa { get; set; }
        public int Pontos { get; set; }

        public void ApresentarSe()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Classe:{Classe}\n Nível:{Nivel}\n Vida:{Vida}\n Força: {Forca}\n Velocidade:{Velocidade}\n Defesa: {Defesa} ");
            Console.WriteLine("--------------------------------\n");
        }
        public void AumentarAtributos(int vida, int defesa, int forca )
        {
            this.Vida += vida;
            this.Defesa += defesa;   
            this.Forca += forca;
        }



    }
}
