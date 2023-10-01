namespace NumbersGame2                              //**Patrik Petterson NET23**//
{
    internal class Program    
    {
        static void Main(string[] args)
        {
          //Information to user
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Console.WriteLine();
            Console.WriteLine("skriv in ditt nummer:");


            Program program = new Program();         
            int randNumber = program.NumberGenerator(); //Calls method NumberGenerator

            int guess = program.CheckGuess(randNumber); //Calls method CheckGuess       
        }
        public int NumberGenerator() //Method NumberGenerator
        {
            Random random = new Random(); 
            int randNumber = random.Next(1, 20); //Stores a randomized number in int randNumber
            return randNumber;
        }
        public int CheckGuess(int secretNumber) //Metho CheckGuess
        {
            int maxTries = 5; //Numbers of tries the user have to guess right number
            int Tries = 0;

            while (Tries < maxTries) //Loop to control number of tries
            {
                string userInput = Console.ReadLine(); //Reads user input

                if (int.TryParse(userInput, out int guess))  //converts string to int
                {
                    if (guess == secretNumber) //checks the user guess against randomnumber 
                    {
                        Console.WriteLine($"Wohoo! Du klarade det! Med {maxTries - Tries} försök tillgodo!");
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