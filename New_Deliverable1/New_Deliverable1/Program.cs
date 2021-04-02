using System;

namespace New_Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 5 memes = 1 foot
            // 1 inch = 3.5 fidget spinners
            //numbers reference
            double spinner = 3.5;
            double meme = 5;
            double inch = 1;
            double feet = 1;

            //user Input
            string userInput = "";
            string userInput2 = "";
            string message = "";

            //Loop
            bool yes = true;

            while (yes == true)
            {
                Console.Clear();

                if (userInput == "no")
                {
                    userInput = Console.ReadLine();
                    break;
                }

                Console.Write("Enter Measurement Type : ");
                userInput = Console.ReadLine();

                Console.Write("Enter a number : ");
                userInput2 = Console.ReadLine();
                double number = double.Parse(userInput2);


                if (userInput.ToLower() == "meme")
                {
                    message = "feet";
                    number = number / 5;
                    Console.WriteLine(number + " " + message);
                }
                if (userInput.ToLower() == "feet")
                {
                    message = "meme";
                    number = number * 5;
                    Console.WriteLine(number + " " + message);
                }
                if (userInput.ToLower() == "inch")
                {
                    message = "fidget spinner";
                    number = number * 3.5;
                    Console.WriteLine(number + " " + message);
                }
                if (userInput.ToLower() == "fidget spinner")
                {
                    message = "inch";
                    number = number / 3.5;
                    Console.WriteLine(number + " " + message);
                }
                Console.WriteLine("Would you like to try again, yes/no");
                Console.ReadLine();
            }

        }
    }
}
