using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            int attempts = 0;
            int attempt = 0;

            Console.WriteLine("Entrez le numéro à faire deviner à l'autre joueur.");
            Console.WriteLine("Il doit être compris entre 1 et 50. (0 = Aléatoire)");
            while (true)
            {
                answer = int.Parse(Console.ReadLine());
                if (answer > 0 && answer < 51)
                {
                    Console.WriteLine("Votre choix est fait. Appuyez sur n'importe quelle touche pour continuer.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else
                {
                    if (answer == 0)
                    {
                        Random randomizer = new Random();
                        answer = randomizer.Next(1, 51);
                        Console.WriteLine("Votre choix est fait, le nombre sera généré aléatoirement. "+Environment.NewLine+" Appuyez sur n'importe quelle touche pour continuer.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                    Console.WriteLine("On a dit entre 1 et 50 !!");
                }
            }

            while (attempt != answer)
            {
                if (attempts == 0)
                {
                    Console.WriteLine("Trouvez le bon numéro entre 1 et 50 !");
                }
                else
                {
                    if (attempt < answer)
                    {
                        Console.WriteLine("C'est plus !");
                    }
                    else
                    {
                        Console.WriteLine("C'est moins !");
                    }
                }
                attempt = int.Parse(Console.ReadLine());
                attempts++;
            }

            Console.WriteLine($"Félicitations vous avez trouvé le numéro au bout de { attempts } essais !");
        }
    }
}
