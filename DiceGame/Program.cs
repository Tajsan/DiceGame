using System.Diagnostics.CodeAnalysis;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till spel 21");
            Console.WriteLine("Vill du slå eller stanna?");
            
            string answer = Console.ReadLine();

            int playerpoints = 0;

            while (answer != "stanna")
            {
                Random rand = new Random();

                int DiceNumber = rand.Next(1, 7);

                playerpoints += DiceNumber;

                Console.WriteLine("Du slog " + DiceNumber + ", dina poäng är nu " + playerpoints);  

                answer = Console.ReadLine();


            }

            int dealerpoints = 0;
            while (dealerpoints <= 17)
            {
                Random rand = new Random();

                int DiceNumber = rand.Next(1, 7);

                dealerpoints += DiceNumber;

                Console.WriteLine("Dealern slog " + DiceNumber + ", Dealerns poäng är nu " + dealerpoints);
            }






        }
    }
}
