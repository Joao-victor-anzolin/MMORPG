using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LigaDasLegendas
{
    internal class Cavaleiro : Personagem
    {
        public int xpcav = 0;
        public int cavpnts = 0;
        public void bataCav(Mago mg1)
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
                xpcav += 15;

                if (xpcav == 15)
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

                if (mg1.xpmag == 15)
                {
                    mg1.Nivel++;
                    Console.WriteLine($"Parabéns! O {mg1.Classe} evoluiu para o nível {mg1.Nivel}!!");
                    Console.WriteLine($"Ganhou {mg1.magpnts} pontos \n");
                    mg1.Vida = 5;

                }
            }
            else if (mg1.Vida <= 0)
            {
                Console.WriteLine($"O {mg1.Classe} ganhou");
                xpcav += 15;


                Console.WriteLine(xpcav);
                if (xpcav == 15)
                {
                    this.Nivel++;
                    Console.WriteLine($"Parabéns! O {this.Classe} evoluiu para o nível{this.Nivel}");
                    

                }
            }

        }

        public void bataAnCav(Anao an2, Cavaleiro cav2)
        {

            int dano2 = an2.Forca - cav2.Defesa;

            if (dano2 <= 0)
            {
                dano2 = 0;
                Console.WriteLine($"O ataque foi ineficaz, o dano foi: {dano2}");
            }
            else if (dano2 > 0)
            {
                cav2.Vida -= dano2;
                if (cav2.Vida >= 0)
                {
                    Console.WriteLine($"O dano foi de:{dano2}; a vida do {cav2.Classe} é de: {cav2.Vida}");
                }
            }


            if (cav2.Vida <= 0)
            {
                Console.WriteLine($"O {an2.Classe} ganhou");
                an2.xpana += 15;
                an2.Pontos += 5;

                if (an2.xpana == 15)
                {
                    an2.Nivel++;
                    Console.WriteLine($"Parabéns! O {an2.Classe} evoluiu para o nível {an2.Nivel}!!");
                    Console.WriteLine($"Ganhou {an2.anpnts} pontos \n");
                    an2.Vida = 5;

                }
            }
            else if (an2.Vida <= 0)
            {
                Console.WriteLine($"O {cav2.Classe} ganhou");
                xpcav += 15;


                Console.WriteLine(xpcav);
                if (xpcav == 15)
                {
                    cav2.Nivel++;
                    Console.WriteLine($"Parabéns! O {cav2.Classe} evoluiu para o nível{cav2.Nivel}");
                    Console.WriteLine($"Ganhou {cav2.cavpnts} pontos \n");
                    cav2.Vida = 5;


                }
            }
            int dano = cav2.Forca - an2.Defesa;

            if (dano <= 0)
            {
                dano = 0;
                Console.WriteLine($"O ataque foi ineficaz, o dano foi: {dano}");
            }
            else if (dano > 0)
            {
                an2.Vida -= dano;
                if (an2.Vida == 0)
                {
                    Console.WriteLine($"O O dano foi de:{dano}; a vida do {an2.Classe} é de: {an2.Vida}");
                }

                Console.WriteLine($"O dano foi de:{dano}; a vida do {an2.Classe} é de: {an2.Vida}");
            }


            if (cav2.Vida <= 0)
            {
                Console.WriteLine($"O {an2.Classe} ganhou");
                an2.xpana += 15;

                if (xpcav == 15)
                {
                    cav2.Nivel++;
                    Console.WriteLine($"Parabéns! O {an2.Classe} evoluiu para o nível {an2.Nivel}!!");
                }
            }
            else if (an2.Vida <= 0)
            {
                Console.WriteLine($"O {cav2.Classe} ganhou");
                cav2.xpcav += 15;
                cav2.Pontos = 5;

                Console.WriteLine(an2.xpana);
                if (cav2.xpcav == 15)
                {
                    cav2.Nivel++;
                    Console.WriteLine($"Parabéns! O {cav2.Classe} evoluiu para o nível{cav2.Nivel}");
                    Console.WriteLine($"Ganhou {cav2.Pontos} pontos \n");
                    cav2.Vida = 8;
                }
            }
        }



    }
}
