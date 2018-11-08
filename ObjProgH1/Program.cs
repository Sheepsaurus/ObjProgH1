namespace ObjProgH1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bottle bottle = new Bottle("Fødevarebanken Drikkevand", 500);
            bottle.Drink();

            Chair chair = new Chair("DXRacer")
            {
                height = 10,
                isOccupied = true
            };
            chair.HoldHandle();
        }
    }
}
