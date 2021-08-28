using System;

namespace ZTataDeliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userRepeatAnswer;
            
            do {
                Console.WriteLine("Hello, and welcome to the MilHip/Imperial Conversion App.");
                Console.Write("Please enter the unit you would like to convert (inches, feet, fidget spinners, memes): ");
                string userUnit = Console.ReadLine();
                userUnit = userUnit.ToLower();
                    if (userUnit == "fidget spinners")
                {
                        Console.Write("Please enter the amount of fidget spinners you would like to convert to inches: ");
                        string userQuantity = Console.ReadLine();
                        double userDouble = double.Parse(userQuantity);
                        double fidgetConversion = 3.50;
                        double fidgetConversionResult = userDouble / fidgetConversion;
                        Console.WriteLine($"{userDouble} fidget spinners = {fidgetConversionResult} inches");

                }
                    else if (userUnit == "memes")
                {
                        Console.Write("Please enter the amount of memes you would like to convert to feet: ");
                        string userQuantity = Console.ReadLine();
                        double userDouble = double.Parse(userQuantity);
                        double memesConverion = 5;
                        double memesConversionResult = userDouble / memesConverion;
                        Console.WriteLine($"{userDouble} memes = {memesConversionResult} feet");
                }
                    else if (userUnit == "inches")
                {
                        Console.Write("Please enter the amount of inches you would like to convert to fidget spinners: ");
                        string userQuantity = Console.ReadLine();
                        double userDouble = double.Parse(userQuantity);
                        double inchesConversion = 3.5;
                        double inchesConversionResult = userDouble * inchesConversion;
                        Console.WriteLine($"{userDouble} inches = {inchesConversionResult} fidget spinners.");
                }
                    else if (userUnit == "feet")
                {
                        Console.Write("Please enter the amount of feet you would like to convert to memes: ");
                        string userQuantity = Console.ReadLine();
                        double userDouble = double.Parse(userQuantity);
                        double feetConversion = 5;
                        double feetConversionResult = userDouble * feetConversion;
                        Console.WriteLine($"{userDouble} feet = {feetConversionResult} memes.");
                }
                    else
                {
                        Console.WriteLine("Please enter one of the units specified above.");
                }
                Console.WriteLine("Would you like to perform another conversion?");
                Console.Write("Y/N?: ");
                userRepeatAnswer = Console.ReadLine();
                userRepeatAnswer = userRepeatAnswer.ToUpper();
            } while (userRepeatAnswer == "Y");
            Console.WriteLine("Please press any key to exit.");
            Console.ReadKey();
        }
    }
}
