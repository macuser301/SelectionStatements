using System;

namespace SelectionStatemantsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            /*var r = new Random();
            var favNumber = r.Next(1, 10);

            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());
            
            if (userInput < favNumber)
            {
                Console.WriteLine($"Too Low! Nevermind!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High!");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine($"Correct!");*/

            /* int favNumber = 7;
             Console.WriteLine("Guess my favorite number. Hint: below 10");
             int userGuess = int.Parse(Console.ReadLine());
             if (userGuess < favNumber)
             {
                 Console.WriteLine($"Too Low!!!");
             }
             else if (userGuess > favNumber)
             {
                 Console.WriteLine($"Too High!!!");
             }
             else if (userGuess == favNumber)
             {
                 Console.WriteLine($"You are correct! Here is a cookie!");
             }
             else
             {
                 Console.WriteLine("Nevermind");*/
            
            string car = "Lamborghini";

            Console.WriteLine($"Which is your favorite exotic car make?");
            string usercar = Console.ReadLine();
            switch (usercar)
            { 
                case "Lamborghini":
                      Console.WriteLine($"You picked the right car !");
                      break;
                case "Ferrari":
                    Console.WriteLine($"They're alright. But, Lamborghini's better then Ferrari!");
                       break;
                case "Porsche":
                    Console.WriteLine($"Porsche is not as cool as Lamborghini!");
                       break;
                default:
                    Console.WriteLine($"All cars are cool . But, we all know Lamborghini is the best!");
                       break;










            }           

        }
    }
}
