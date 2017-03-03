using System;

namespace LCDPrinter.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            var ploter = new LcdPloter();
            ploter.PrintLines(new []{"2,12345","3,67890"});
            Console.ResetColor();
            Console.ReadLine();
        }

        

        
        
    }
}
