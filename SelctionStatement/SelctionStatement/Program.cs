namespace SelctionStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("What is your favorite school subject");

            var subject = Console.ReadLine();

            switch(subject)
            {

                case "Math":
                    Console.WriteLine("Math is lame, so you are lame");
                    break;

                case "Reading":
                    Console.WriteLine("NERDDDDDDDDD");
                        break;
                case "Lunch":
                    Console.WriteLine("OINK OINK LITTLE PIGGY!");
                        break;
                case "Recess":
                    Console.WriteLine("If you can dodge a wrench you can dodge a ball");
                        break;
                case "Science":
                    Console.WriteLine("Frog MURDERER");
                        break;
                default : Console.WriteLine("SKIP SCHOOL START FIGHTS");
                    break;
                case ("Social Studies"):
                    Console.WriteLine("That's Marlenes Favorite too!");
                        break;

            }

            
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("whats your favorite number?");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {

                Console.WriteLine("you suck too low");

            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high, no prize for you");

            }
            else
            {

                Console.WriteLine("You sunk my battleship");
            }


        }


    }
}  