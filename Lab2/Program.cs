using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus' Room Detail Generator!");
            Console.WriteLine();

            bool keepGoing = false;
            do
            {
                Console.Write("Enter Length in feet: ");
                var lengthInput = Console.ReadLine();
                Console.Write("Enter Width in feet: ");
                var widthInput = Console.ReadLine();
                Console.Write("Enter Height in feet: ");
                var heightInput = Console.ReadLine();

                var isLengthDouble = double.TryParse(lengthInput, out double length);
                var isWidthDouble = double.TryParse(widthInput, out double width);
                var isHeightDouble = double.TryParse(heightInput, out double height);


                var areaFt = Math.Truncate(length * width);
                var areaIn = Math.Truncate((length * width * 12) % 12); 

                var perimeterFt = Math.Truncate(length * 2 + width * 2);
                var perimeterIn = Math.Truncate(((length * 2 + width * 2) * 12) % 12);

                var volume = Math.Round(length * width * height);
                const string quote = "\"";

                Console.WriteLine();
                Console.WriteLine($"Area: {areaFt}' {areaIn}{quote} ");
                Console.WriteLine($"Perimeter: {perimeterFt}' {perimeterIn}{quote} ");
                Console.WriteLine($"Volume: {volume} cubic feet");
                Console.WriteLine();

                bool getInput = true;
                while (getInput)
                {
                    Console.Write("Do you want to continue? (y/n): ");
                    string continueInput = Console.ReadLine();
                    Console.WriteLine();
                    if (continueInput == "y" || continueInput == "Y")
                    {
                        keepGoing = true;
                        getInput = false;
                    } else if (continueInput == "n" || continueInput == "N")
                    {
                        getInput = false;
                        keepGoing = false;
                    } else
                    {
                        Console.WriteLine("You must enter a y or n. Try again! ");
                        Console.WriteLine();
                    }
                }
            } while (keepGoing == true);
        }
    }
}
