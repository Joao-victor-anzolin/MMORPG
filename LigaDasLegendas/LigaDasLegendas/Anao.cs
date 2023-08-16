using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace LigaDasLegendas
{
    internal class Anao : Personagem
    {
        public int xpana = 0;
        public int anpnts = 0;


        public void bataAna(Mago mg1)
        {
            int dano = this.Forca - mg1.Defesa;

            if (dano <= 0)
            {
                dano = 0;
                Console.WriteLine($"O ataque foi ineficaz, o dano foi: {dano}");
            }
            else if (dano > 0)
            {
                mg1.Vida -= dano;
                if (mg1.Vida == 0)
                {
                    Console.WriteLine($"O O dano foi de:{dano}; a vida do {mg1.Classe} é de: {mg1.Vida}");
                }

                Console.WriteLine($"O dano foi de:{dano}; a vida do {mg1.Classe} é de: {mg1.Vida}");
            }


            if (this.Vida <= 0)
            {
                Console.WriteLine($"O {mg1.Classe} ganhou");
                xpana += 15;

                if (xpana == 15)
                {
                    this.Nivel++;
                    Console.WriteLine($"Parabéns! O {this.Classe} evoluiu para o nível {this.Nivel}!!");
                }
            }
            else if (mg1.Vida <= 0)
            {
                Console.WriteLine($"O {this.Classe} ganhou");
                mg1.xpmag += 15;
                Console.WriteLine(mg1.xpmag);
                if (mg1.xpmag == 15)
                {
                    mg1.Nivel++;
                    Console.WriteLine($"Parabéns! O {mg1.Classe} evoluiu para o nível{mg1.Nivel}");
                }
            }


            int dano2 = mg1.Forca - this.Defesa;

            if (dano2 <= 0)
            {
                dano2 = 0;
                Console.WriteLine($"O ataque foi ineficaz, o dano foi: {dano2}");
            }
            else if (dano2 > 0)
            {
                this.Vida -= dano2;
                if (this.Vida >= 0)
                {
                    Console.WriteLine($"O dano foi de:{dano2}; a vida do {this.Classe} é de: {this.Vida}");
                }
            }


            if (this.Vida <= 0)
            {
                Console.WriteLine($"O {mg1.Classe} ganhou");
                mg1.xpmag += 15;
                mg1.Pontos += 5;

                if (mg1.xpmag == 30)
                {
                    mg1.Nivel++;
                    Console.WriteLine($"Parabéns! O {mg1.Classe} evoluiu para o nível {mg1.Nivel}!!");
                    Console.WriteLine($"Ganhou {mg1.magpnts = 5} pontos");
                    mg1.Vida += 6;

                }
            }
            else if (mg1.Vida <= 0)
            {
                Console.WriteLine($"O {this.Classe} ganhou");
                xpana += 15;


                Console.WriteLine(xpana);
                if (xpana == 15)
                {
                    this.Nivel++;
                    Console.WriteLine($"Parabéns! O {this.Classe} evoluiu para o nível{this.Nivel}");

                }
            }

        }
    }
}
