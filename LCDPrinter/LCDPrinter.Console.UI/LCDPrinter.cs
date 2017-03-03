using System;
using System.Linq;

namespace LCDPrinter.UI
{
    public class LcdPrinter
    {
        public  const char Hrztl = '-';
        public const char Vrtcl = '|';
        public const char Space = ' ';

        public static void PrintVertical( int size, int xPos, int yPos)
        {
            for (int i = 0; i < size; i++)
            {
                Console.SetCursorPosition(xPos,yPos);
                Console.Write(Vrtcl);
                yPos++;
            }
            

        }
        public static void PrintHorizontal(int size, int xPos, int yPos)
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.Write(Space);
            Console.Write(string.Join("", Enumerable.Repeat(Hrztl , size)));
            Console.Write(Space);
        }

        public static void PrintSpace()
        {
            Space.Write();
        }
        public static void PrintBlankLine()
        {
            Console.WriteLine();
        }
    }
}
