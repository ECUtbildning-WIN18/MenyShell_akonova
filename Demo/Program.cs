using System;

namespace Demo
{
    class Vehicle
    {
        public int WheelsCount { get; set; }
        public int MaxSpeed { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // экземпляры класса типа Vehicle (колёсное транспортное средство)
            Vehicle v1 = new Vehicle();
            v1.Name = "Univega Lady Terrano Sport 26''";
            v1.MaxSpeed = 40;

            Vehicle v2 = new Vehicle();
            v2.Name = "Volvo S40";
            v2.MaxSpeed = 220;


            for (int i = 0; i < 100000000; i++)
            {
                Vehicle v = new Vehicle();
                v.Name = "Univega Lady Terrano Sport 26''";
                v.MaxSpeed = 40;
            }



            Console.WriteLine("Hello World!");
        }
    }
}
