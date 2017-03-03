using System;
using System.Linq;

namespace LCDPrinter.UI
{
    public class LcdPloter
    {
        public int Xpos { get; set; }
        public int Ypos { get; set; }

        public void PrintLines(string[] lines)
        {
            Console.Clear();
            Xpos = 0;
            Ypos = 0;
            foreach (var line in lines)
            {
                
                PrintLine(line);
            }
        }

        private void PrintLine(string line)
        {
            string[] config = line.Split(',');
            ValidateConfig(config);
            int size = int.Parse(config[0]);
            string LineToPrint = config[1];
            PrintNumber(LineToPrint, size);
            Xpos = 0;
            Ypos += 2*size + 5;
        }

        private void PrintNumber(string lineToPrint, int size)
        {
            foreach (char n in lineToPrint)
            {
                PrintDigit(int.Parse(n.ToString()), size);
                Xpos += size + 3;
            }
            Console.WriteLine();
        }

        private void PrintDigit(int digit, int size)
        {
            byte[] printPattern = Constants.DisplayBytes.Cast<byte>().Skip(digit*7).Take(7).ToArray();
            NumberPrinter.Print(Xpos,Ypos,printPattern,size);
        }

        private void ValidateConfig(string[] config)
        {
            if(config.Length!=2)
                throw new ArgumentException("The imput format is incorrect. Correct is size,numbers");
            if (!config[0].IsNumeric() || !config[1].IsNumeric())
                throw new ArgumentException("Only numbers are accepted");
        }
    }
}
