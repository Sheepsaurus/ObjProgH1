using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjProgH1
{
    class Handheld
    {
    }

    /// <summary>
    /// The constructor asks for a simple Brand Name, and the capacity in mL (Example: 500mL = 0.5l)
    /// </summary>
    class Bottle : Handheld
    {
        public string brandName;
        public bool isOpened;
        public bool isFilled;
        public int capacity;
        public int volume;

        private readonly string[] responseArray =
        {
            "You push an unopened bottle against your lips. Idiot. Open it first.",
            "You were too occupied deciding how much to drink, you forgot to open it first.",
            "Do you know what happens to a bottle you turn upside down? Nothing, if you don't open it first.",
            "You tried to pour water onto a closed bottle, and now there's water everywhere. Good job. Open it first.",
            "It is already open.. What are you trying to accomplish?",
            "The bottle is already closed"
        };

        public Bottle(string BrandName, int Capacity)
        {
            brandName = BrandName;
            capacity = Capacity;
        }

        public void Drink()
        {
            if (isOpened)
            {
                if (volume > 62)
                {
                    volume -= 62;
                    isFilled = false;
                }
                else
                {
                    volume = 0;
                    isFilled = false;
                }
            }
            else { Console.WriteLine(responseArray[0]); }
        }
        public void Drink(int Volume)
        {
            if (isOpened == true)
            {
                volume -= Volume;
                isFilled = false;
            }
            else { Console.WriteLine(responseArray[1]); }
        }

        public void Empty()
        {
            if (isOpened)
            {
                volume = 0;
                isFilled = false;
            }
            else { Console.WriteLine(responseArray[2]); }
        }

        public void Fill()
        {
            if (isOpened)
            {
                volume = 1000;
                isFilled = true;
            }
            else { Console.WriteLine(responseArray[3]); }
        }

        public void Open()
        {
            if (isOpened) { isOpened = true; }
            else { Console.WriteLine(responseArray[4]); }
        }
        public void Close()
        {
            if (isOpened) { isOpened = false; }
            else { Console.WriteLine(responseArray[5]); }
        }
    }
    class Pan : Handheld
    {

    }
    class Phone : Handheld
    {

    }
}
