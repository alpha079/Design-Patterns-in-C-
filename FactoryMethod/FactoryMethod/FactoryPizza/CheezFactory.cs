using FactoryMethod.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.FactoryPizza
{
    class CheezFactory : PizzaFactory
    {

        Pizzas pizza;
        protected override Pizzas Create(string type)
        {
            if (type.Equals("Cheese"))
            {
                pizza = new CheezPizza()
                {
                    Color = "White-Cheese",
                    Name= "Double loaded Cheese"
                };
            }
            else
            {
                pizza = new CornPizza()
                {
                    Color = "Yellow-Corn",
                    Name = "Classical Baby Corn"

                };
            }

           

            return pizza;

        }


    }
}
