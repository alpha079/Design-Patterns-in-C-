using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Pizza
{
    class CornPizza : Pizzas
    {
        internal override void Prepare()
        {
            Console.WriteLine("Preparing Corn Pizza in 5 minutes");
        }
    }
}
