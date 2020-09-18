using FactoryMethod.FactoryPizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bake Pizza");
            var pizza = new CheezFactory();
            pizza.Order("Cheese");
            Console.WriteLine();

            var pizza2 = new CornFactory();
            pizza.Order("Corn");
            Console.WriteLine();
            Console.Read();
        }
    }
}
