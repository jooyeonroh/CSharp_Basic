using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter05.src
{
    class Ex009
    {
        public void Run()
        {
            GasolineCar009 gasolineCar = new GasolineCar009();
            gasolineCar.Color = "Black";
            gasolineCar.Size = "SUV";
            ElectronicCar009 electronicCar = new ElectronicCar009();
            electronicCar.Color = "Green";
            electronicCar.Size = "small";

            Console.WriteLine("{0} colored {1} is gonna ", gasolineCar.Color, gasolineCar.Size);
            gasolineCar.InputGas();
            Console.WriteLine("{0} colored {1} is gonna", electronicCar.Color, electronicCar.Size);
            electronicCar.InputGas();
        }
    }
    class Car009
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public void Engine_on()
        {
            Console.WriteLine("Engine_on");
        }
        public void Engine_off()
        {
            Console.WriteLine("Engine_off");
        }
        public void Go()
        {
            Console.WriteLine("go straight");
        }
        public void Back()
        {
            Console.WriteLine("go back");
        }
        public void Left()
        {
            Console.WriteLine("turn left");
        }
        public void right()
        {
            Console.WriteLine("turn right");
        }
        public virtual void InputGas()
        {
            Console.WriteLine("put some oil");
        }
    }

    class GasolineCar009 : Car009
    {
        public override void InputGas()
        {
            Console.WriteLine("put some A.oil");

        }
    }
    class ElectronicCar009 : Car009
    {
        public override void InputGas()
        {
            Console.WriteLine("put some B.oil");
        }
    }
}
