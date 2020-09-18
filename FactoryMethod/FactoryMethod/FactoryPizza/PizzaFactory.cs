using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Pizza;
namespace FactoryMethod.FactoryPizza
{
    abstract class PizzaFactory
    {
        public Pizzas Order(String type)
        {
        var pizza = Create(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.PName();
        pizza.Cut();
        pizza.Box();
        return pizza;
        }
        protected abstract Pizzas Create(string type);


    }
}
