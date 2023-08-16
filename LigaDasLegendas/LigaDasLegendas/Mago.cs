using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaDasLegendas
{
    internal class Mago : Personagem
    {
        public int xpmag = 0;
        public int magpnts = 0;

        public void bataFim(Mago an2, Cavaleiro cav2)
        {

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
                an2.xpmag += 15;

                if (xpmag == 15)
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

                Console.WriteLine(an2.xpmag);
                if (cav2.xpcav == 15)
                {
                    cav2.Nivel++;
                    Console.WriteLine($"Parabéns! O {cav2.Classe} evoluiu para o nível{cav2.Nivel}");
                    Console.WriteLine($"Ganhou {cav2.cavpnts} pontos \n");
                    cav2.Vida = 8;
                }
            }

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


            if (cav2.Vida == 0)
            {
                Console.WriteLine($"O {an2.Classe} ganhou");
                an2.xpmag += 15;
                an2.Pontos += 5;

                if (an2.xpmag == 15)
                {
                    an2.Nivel++;
                    Console.WriteLine($"Parabéns! O {an2.Classe} evoluiu para o nível {an2.Nivel}!!");
                    Console.WriteLine($"Ganhou {an2.Pontos} pontos \n");
                    an2.Vida = 5;

                }
            }
            else if (an2.Vida <= 0)
            {
                Console.WriteLine($"O {cav2.Classe} ganhou");
                xpmag += 15;


                Console.WriteLine(xpmag);
                if (xpmag == 15)
                {
                    cav2.Nivel++;
                    Console.WriteLine($"Parabéns! O {cav2.Classe} evoluiu para o nível{cav2.Nivel}");
                    Console.WriteLine($"Ganhou {cav2.cavpnts} pontos \n");
                    cav2.Vida = 5;


                }
            }


        }
    }


}
