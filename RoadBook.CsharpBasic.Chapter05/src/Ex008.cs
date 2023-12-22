using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter05.src
{
    class Ex008
    {
        public void Run()
        {
            GasolineCar008 gasolineCar = new GasolineCar008();
            gasolineCar.Color = "Black";
            gasolineCar.Size = "SUV";
            ElectronicCar008 electronicCar = new ElectronicCar008();
            electronicCar.Color = "Red";
            electronicCar.Size = "Small";

            Console.WriteLine("{0} colored {1} is gonna ", gasolineCar.Color, gasolineCar.Size);
            gasolineCar.Go();
            Console.WriteLine("{0} colored {1} is gonna ", electronicCar.Color, electronicCar.Size);
            electronicCar.Left();
        }
    }
    class Car008
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public void Engine_on()
        {
            Console.WriteLine("engine on");
        }
        public void Engine_off()
        {
            Console.WriteLine("engine off");
        }
        public void Go()
        {
            Console.WriteLine("go forward");
        }
        public void Back()
        {
            Console.WriteLine("go back");
        }
        public void Left()
        {
            Console.WriteLine("turn Left");
        }
        public void Right()
        {
            Console.WriteLine("turn right");
        }
    }

    class GasolineCar008 : Car008 { }
    class ElectronicCar008 : Car008 { }

}
