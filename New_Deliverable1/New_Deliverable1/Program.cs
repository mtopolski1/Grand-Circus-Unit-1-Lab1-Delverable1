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
                        message = "foot";
                        feet = meme / 5;
                        Console.WriteLine(meme * feet + " " + message);
                    }
                    if (userInput.ToLower() == "foot")
                    {
                        message = "meme";
                        meme = feet / 5;
                        Console.WriteLine(feet * meme + " " + message);
                    }
                    if (userInput.ToLower() == "inch")
                    {
                        message = "fidget spinner";
                        inch = spinner / 3.5;
                        Console.WriteLine(spinner * inch + " " + message);
                    }
                    if (userInput.ToLower() == "fidget spinner")
                    {
                        message = "inch";
                        spinner = inch / 3.5;
                        Console.WriteLine(inch * spinner + " " + message);
                    }
                Console.WriteLine("Would you like to try again, yes/no");
                Console.ReadLine();
           }

        }
    }
}