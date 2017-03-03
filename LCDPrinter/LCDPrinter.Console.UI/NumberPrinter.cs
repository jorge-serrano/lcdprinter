using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCDPrinter.UI
{
    public class  NumberPrinter
    {
        public static void Print(int Xpos, int Ypos, byte[]pattern, int size)
        {
            SetPosition(Xpos, Ypos);
            if (pattern[0]==1)
                LcdPrinter.PrintHorizontal(size, Xpos, Ypos);
            Xpos += size+2;
            Ypos++;
            SetPosition(Xpos, Ypos);

            if (pattern[1] == 1)
                LcdPrinter.PrintVertical(size,Xpos,Ypos);
            Ypos += size;
            SetPosition(Xpos, Ypos);

            if (pattern[2] == 1)
                LcdPrinter.PrintVertical(size,Xpos,Ypos);
            Ypos += size;
            SetPosition(Xpos, Ypos);


            Xpos -= size+2;
            SetPosition(Xpos,Ypos);
            if (pattern[3] == 1)
                LcdPrinter.PrintHorizontal(size,Xpos, Ypos);

            Ypos -= size ;
            SetPosition(Xpos, Ypos);

            if (pattern[4] == 1)
                LcdPrinter.PrintVertical(size, Xpos, Ypos);

            Ypos -= size ;
            SetPosition(Xpos, Ypos);

            if (pattern[5] == 1)
                LcdPrinter.PrintVertical(size, Xpos, Ypos);

            Ypos += size-1;
            SetPosition(Xpos, Ypos);
            if (pattern[6] == 1)
                LcdPrinter.PrintHorizontal(size,Xpos,Ypos);

        }

        private static void SetPosition(int xpos, int ypos)
        {
            Console.SetCursorPosition(xpos,ypos);
        }
    }
}
