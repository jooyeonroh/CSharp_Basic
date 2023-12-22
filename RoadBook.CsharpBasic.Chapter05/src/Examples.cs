using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter05.src
{
    class Examples
    {
        public void Ex001()
        {
            Car001 car = new Car001();
            car.setSize("SUV");
            car.setColor("White");

            Console.WriteLine("Your car {0} {1} is...", car.getColor(), car.getSize());

            car.Engine_on();
            car.Go();
            car.Back();
            car.Left();
            car.Right();
            car.Engine_off();
        }
        public void Ex002()
        {
            Car002 car = new Car002();
            car.Size = "SUV";
            car.Color = "Black";

            Console.WriteLine("Your car {0} {1} is ...", car.Color, car.Size);

            car.Engine_on();
            car.Go();
            car.Back();
            car.Left();
            car.Right();
            car.Engine_off();
        }
        public void Ex003()
        {
            Car003 car = new Car003();
            car.Size = "SUV";
            car.Color = "Green";

            Console.WriteLine("Your car {0} {1} is ...", car.Color, car.Size);

            car.Engine_on();
            car.Go();
            car.Back();
            car.Left();
            car.Right();
            car.Engine_off();
        }
        public void Ex004()
        {
            Bread custard_cream_bread = new Bread();
            custard_cream_bread.Shape = "start";
            custard_cream_bread.Source = "Cream";

            Console.WriteLine("{0} {1} Bread, custard_cream_bread.Shape, custard_cream_bread.Source");

            Bread pizza_bread = new Bread();
            pizza_bread.Shape = "Square";
            pizza_bread.Source = "pizza flavor";
            Console.WriteLine("{0} {1} Bread, pizza_bread.Shape, pizza_bread.Source");
        }
    }
    class Bread
    {
        public string Shape { get; set; }
        public string Source { get; set; }
    }
    class Car001
    {
        #region 형태
        private string size;
        private string color;

        public void setSize(string size)
        {
            this.size = size;
        }
        public string getSize()
        {
            return size;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public string getColor()
        {
            return color;
        }
        #endregion

        #region 행동
        public void Engine_on()
        {
            Console.WriteLine("Engine ON");
        }
        public void Engine_off()
        {
            Console.WriteLine("Engine OFF");
        }
        public void Go()
        {
            Console.WriteLine("Go forward");
        }
        public void Back()
        {
            Console.WriteLine("Turn Back");
        }
        public void Left()
        {
            Console.WriteLine("Turn Left");
        }
        public void Right()
        {
            Console.WriteLine("Turn Right");
        }
        #endregion
    }
    class Car002
    {
        private string size;
        private string color;

        public string Size
        {
            set { size = value; }
            get { return size; }
        }
        public string Color
        {
            set { color = value; }
            get { return color;  }
        }
        public void Engine_on()
        {
            Console.WriteLine("Engine ON");
        }
        public void Engine_off()
        {
            Console.WriteLine("Engine OFF");
        }
        public void Go()
        {
            Console.WriteLine("Go forward");
        }
        public void Back()
        {
            Console.WriteLine("Turn Back");
        }
        public void Left()
        {
            Console.WriteLine("Turn Left");
        }
        public void Right()
        {
            Console.WriteLine("Turn Right");
        }
    }
    class Car003
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public void Engine_on()
        {
            Console.WriteLine("Engine ON");
        }
        public void Engine_off()
        {
            Console.WriteLine("Engine OFF");
        }
        public void Go()
        {
            Console.WriteLine("Go forward");
        }
        public void Back()
        {
            Console.WriteLine("Turn Back");
        }
        public void Left()
        {
            Console.WriteLine("Turn Left");
        }
        public void Right()
        {
            Console.WriteLine("Turn Right");
        }
    }
}
