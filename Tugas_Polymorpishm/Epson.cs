using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Polymorpishm
{
    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension: 10*12");
        }
        public override void Print()
        {
            Console.WriteLine("Canon printer printing...");
        }
    }
}
