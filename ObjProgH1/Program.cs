using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjProgH1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bottle bottle = new Bottle("Fødevarebanken Drikkevand", 500);
            bottle.Drink();

            Chair chair = new Chair("DXRacer");
            chair.HoldHandle();
        }
    }
}
