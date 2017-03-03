using System;

namespace LCDPrinter.UI
{
    public static class clasCharExtensions
    {
        public static void Write(this char mychar)
        {
            Console.Write(mychar);
        }
        public static void WriteLn(this char mychar)
        {
            Console.WriteLine(mychar);
        }

        public static bool IsNumeric(this string ChainToTest)
        {
            int a;
            return int.TryParse(ChainToTest, out a);
        }
    }
}
