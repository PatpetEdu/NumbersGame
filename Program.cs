namespace NumbersGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök");
            Console.WriteLine();
            Console.WriteLine("skriv in ditt nummer:");


            Program program = new Program();         
            int randNumber = program.NumberGenerator();

            int guess = program.CheckGuess(randNumber);
            Console.WriteLine(guess);

        }
        public int NumberGenerator()
        {
            Random random = new Random();
            int randNumber = random.Next(1, 11);
            return randNumber;
        }
        public int CheckGuess(int secretNumber)
        {
            int maxTries = 5;
            int Tries = 0;

            while (Tries < maxTries)
            {
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int guess))
                {
                    if (guess == secretNumber)
                    {
                        Console.WriteLine("Wohoo! Du klarade det!");
                        return guess;
                    }
                    else if (guess > secretNumber)
                    {
                        Console.WriteLine("Tyvärr, du gissade för högt!");
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("Tyvärr, du gissade för lågt!");
                    }

                    Tries++;
                    Console.WriteLine($"Du har {maxTries - Tries} försök kvar.");
                }
                else
                {
                    Console.WriteLine("Ogiltigt värde. Skriv in ett heltal");
                }
            }

            Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök! Spelet är slut.");
            return 0;

        }
    }
}