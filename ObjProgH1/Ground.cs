using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjProgH1
{
    class Ground
    {
    }

    class Bed : Ground
    {

    }
    class Chair : Ground
    {
        public bool isOccupied;
        public int height;
        public int leanAngle;
        public int rotatePosition;
        public string brandName;

        private readonly string[] responseArray =
        {
            "You are already sitting in the chair",
            "You are not sitting in the chair",
            "The chair does not go that low",
            "The chair does not go that high",
            "There were nobody in the chair to stop the backrest from moving forward",
            "3",
            "4"
        };

        public Chair(string BrandName)
        {
            brandName = BrandName;
        }

        public void SitIn()
        {
            if (!isOccupied) { isOccupied = true; }
            else { Console.WriteLine(responseArray[0]); }
        }
        public void LeaveChair()
        {
            if (isOccupied) { isOccupied = false; }
            else { Console.WriteLine(responseArray[1]); }
        }
        public void AngleChair(int angle)
        {
            const int maxAngle = 170;
            const int minAngle = 25;

            if (isOccupied && angle <= maxAngle && angle >= minAngle)
            { leanAngle = angle; }
            else if (angle < minAngle) 
            { Console.WriteLine(responseArray[2]); }
            else if (angle > maxAngle)
            { Console.WriteLine(responseArray[3]); }
            else
            {
                leanAngle = minAngle;
                Console.WriteLine(responseArray[4]);
            }
        }
        public void HoldHandle()
        {
            const int maxHeight = 10;
            const int minHeight = 0;

            if (isOccupied) { height = minHeight; }
            else { height = maxHeight; }
        }
    }
    class Cupboard : Ground
    {

    }
}
