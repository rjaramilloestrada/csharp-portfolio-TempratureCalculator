using System;

namespace EnhancedIfStatementsChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current temperature: ");
            string userTemp = Console.ReadLine();
            int temp;
            bool tempIsNumerical = Int32.TryParse(userTemp, out temp);

            if (tempIsNumerical)
            {

                userTemp = temp <= 15 ? "It is too cold outside" : temp >= 16 && temp <= 28 ? "It is ok" : temp > 28 ? "It is hot here" : "";
                Console.Write(userTemp);
                Console.Read();

            } else
            {
                Console.WriteLine("Not a valid temperature");
                Console.Read();
            }

            
        }
    }
}
