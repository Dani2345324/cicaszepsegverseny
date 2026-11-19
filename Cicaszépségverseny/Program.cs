using System.ComponentModel.DataAnnotations;

namespace Cicaszépségverseny
{
    internal class Program
    {

        static int[,] pontok;
        static Random r = new Random();

        static void bekeres()
        {
            Console.Write("Kérem adja meg hány cica versenyzik: ");

            int cicakszama = Convert.ToInt32(Console.ReadLine());
            int[,] seged = new int[cicakszama,4];
            pontok = seged;

            
        }
        static void feltoltes()
        {
            for (int i = 0; i < pontok.GetLength(0); i++)
            {
                pontok[i, 0] = i+1;
                for (int j = 1; j < pontok.GetLength(1); j++)
                {
                    pontok[i, j] = r.Next(1, 11);
                    
                }
                
            }
        }
        static void kiiratas()
        {
            for (int i = 0; i < pontok.GetLength(0); i++)
            {
                Console.Write($"{pontok[i, 0],4}. cica: ");
                for (int j = 1; j < pontok.GetLength(1); j++)
                {
                    string allapotok = "";
                    if (j == 1)
                    {
                        allapotok = "lustaság";
                    }
                    else if (j == 2) {
                        allapotok = "játékosság";
                    }
                    else
                    {
                        allapotok = "éhség";
                    }

                    Console.Write($"{pontok[i,j],4} {allapotok,4}");

                }
                Console.WriteLine();

            }
        }
        static void gyoztesek() {
            int max_lustasag = -1;
            int max_jatekossag = -1;
            int max_ehseg = -1;
            int max_la = 0;
            int max_ja = 0;
            int max_ea = 0;

            for (int i = 0; i < pontok.GetLength(0); i++)
            {
                for (int j = 1; j < pontok.GetLength(1); j++)
                {
                    


                    if (j == 1)
                    {
                        if (pontok[i, j] > max_lustasag)
                        {
                            max_lustasag = pontok[i, j];
                            max_la = pontok[i, 0];
                        }
                    }
                    else if (j == 2)
                    {
                        if (pontok[i, j] > max_jatekossag)
                        {
                            max_jatekossag = pontok[i, j];
                            max_ja = pontok[i, 0];
                        }
                    }
                    else
                    {
                        if (pontok[i, j] > max_ehseg)
                        {
                            max_ehseg = pontok[i, j];
                            max_ea = pontok[i, 0];
                        }
                    }
                }
            }
            Console.WriteLine($"A leglustább macska: {max_la}, lustasága: {max_lustasag}");
            Console.WriteLine($"A legljátékosabb macska: {max_ja}, : {max_jatekossag}");
            Console.WriteLine($"A legéhesebb macska: {max_ea}, : {max_ehseg}");

        }

        static void Main(string[] args)
        {
            bekeres();
            feltoltes();
            kiiratas();
            gyoztesek();
        }
    }
}
