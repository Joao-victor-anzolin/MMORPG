using LigaDasLegendas;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {

        //Mago 1
        Mago mg1 = new Mago();
        mg1.Classe = "Mago";
        mg1.Nivel = 1;
        mg1.Vida = 5;
        mg1.Forca = 3;
        mg1.Velocidade = 1;
        mg1.Defesa = 2;
        mg1.Pontos = 0;

        //Cava 1
        Cavaleiro cav1 = new Cavaleiro();
        cav1.Classe = "Cavaleiro";
        cav1.Nivel = 1;
        cav1.Vida = 4;
        cav1.Forca = 4;
        cav1.Velocidade = 1;
        cav1.Defesa = 1;
        cav1.Pontos = 0;

        //Cava 2
        Cavaleiro cav2 = new Cavaleiro();
        cav2.Classe = "Cavaleiro Campeão";
        cav2.Nivel = 3;
        cav2.Vida = 10;
        cav2.Forca = 6;
        cav2.Velocidade = 1;
        cav2.Defesa = 4;
        cav2.Pontos = 0;

        //Anão 1
        Anao an1 = new Anao();
        an1.Classe = "Anão";
        an1.Nivel = 2;
        an1.Vida = 8;
        an1.Forca = 5;
        an1.Velocidade = 2;
        an1.Defesa = 2;
        an1.Pontos = 0;

        //Anão 2
        Anao an2 = new Anao();
        an2.Classe = "Anão";
        an2.Nivel = 1;
        an2.Vida = 3;
        an2.Forca = 3;
        an2.Velocidade = 2;
        an2.Defesa = 2;
        an2.Pontos = 0;

        mg1.ApresentarSe();
        an1.ApresentarSe();
        cav1.ApresentarSe();
        cav2.ApresentarSe();


        //BATALHAS

        Console.WriteLine("<----------------------------------------------------------------------------->\n" );

        Console.WriteLine("Mago X Cavaleiro");
        while (mg1.Vida > 0 && cav1.Vida > 0)
        {
            cav1.bataCav(mg1);
        }
        mg1.AumentarAtributos(2, 1, 2);
        mg1.ApresentarSe();

        Console.WriteLine("<----------------------------------------------------------------------------->\n");

        Console.WriteLine("Anão X Mago");
        while (an1.Vida > 0 && mg1.Vida > 0)
        {
            an1.bataAna(mg1);
        }
        mg1.AumentarAtributos(0, 2, 3);
        mg1.ApresentarSe();

        Console.WriteLine("<----------------------------------------------------------------------------->\n");

        Console.WriteLine("<----------------------------------------------------------------------------->\n");

        Console.WriteLine("Anão X Cav");
        while (an2.Vida > 0 && cav2.Vida > 0)
        {
            cav1.bataAnCav(an2, cav2);
        }

        Console.WriteLine("<----------------------------------------------------------------------------->\n");
        
        Console.WriteLine(" Mago X Cavaleiro Campeão\n BATALHA FINAL");
        while (cav2.Vida > 0 && mg1.Vida > 0)
        {
            mg1.bataFim(mg1, cav2);
        }

        Console.WriteLine("<----------------------------------------------------------------------------->\n");
        Console.WriteLine("O MAGO DOS GAMES VENCEU!!!\n");
        Console.WriteLine("<----------------------------------------------------------------------------->\n");
    }
}