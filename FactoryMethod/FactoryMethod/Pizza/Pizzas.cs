using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Pizza
{
    abstract class Pizzas
    {
        public string Color;
        public string Name;
        internal abstract void Prepare();

        internal void Bake()
        {
            Console.WriteLine("Baking at 135 degree Celsius for 20 minutes");
        }
        internal void PName()
        {
            Console.WriteLine("Pizza name is "+ Name);
        }
        internal void Cut()
        {
            Console.WriteLine("Cutting into diagonal pieces");
        }
        internal void Box()
        {
            Console.WriteLine("Putting pizza in " + Color + " coloured box");
        }
        


    }
}
