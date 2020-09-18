using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Pizza
{
    class CheezPizza : Pizzas
    {
        internal override void Prepare()
        {
            Console.WriteLine("Preparing Cheese Pizza in 5 Minutes");
        }
    }
}
