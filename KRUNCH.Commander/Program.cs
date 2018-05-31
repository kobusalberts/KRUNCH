namespace KRUNCH.Commander
{
    using System;

    using Krunch.DomainLogic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("==============================================================================================");
            Console.WriteLine("Welcome to 'Krunch Commander'. Please enter the text that will be krunched below.");
            Console.WriteLine("NOTE: Only upper case characters will be accepted and all characters will be forced to uppercase.");
            Console.WriteLine("==============================================================================================");

            var textToBeKrunched = Console.ReadLine();
            var result = textToBeKrunched.ToUpper().Krunch();

            Console.WriteLine("The following result was generated:");
            Console.WriteLine(result);

            Console.WriteLine("Do you want to save to file (y/n):");
            var save = Console.ReadKey();
            if (save.KeyChar == 'y')
            {
                var file = KrunchProcessor.Save(result);
                Console.WriteLine();
                Console.WriteLine($"Output saved to {file}");
            }
            Console.ReadKey();
        }
    }
}