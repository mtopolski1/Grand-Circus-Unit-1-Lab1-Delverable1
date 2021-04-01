using System;


namespace deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Please enter a measurement & amount, 1 Inch, 1 Foot, 3.5 Fidget Spinners or 5 Memes");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "1 foot")
                {
                    string message = "1 Foot = 5 Memes";
                    Console.WriteLine(message);
                }
                if (userInput.ToLower() == "5 memes")
                {
                    string message = "5 Memes = 1 Foot";
                    Console.WriteLine(message);
                }
                if (userInput.ToLower() == "1 inch")
                {
                    string message = "1 Inch = 3.5 Fidget Spinners";
                    Console.WriteLine(message);
                }
                if (userInput.ToLower() == "3.5 fidget spinners")
                {
                    string message = "3.5 Fidget Spinners = 1 Inch";
                    Console.WriteLine(message);
                }
            }
        }
    }
}








// convert and store converstion
//1 inch = 3.5 Fidget Spinners
//1 Foot = 5 Memes
