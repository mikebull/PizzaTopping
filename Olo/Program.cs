using System;
using System.Collections.Generic;
using System.Linq;
using Ninject;
using Olo.Model;
using Olo.Module;
using Olo.Service.Interface;

namespace Olo
{
    /// <summary>
    /// Main application
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Console application runner.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            var toppings = GetToppings();

            for (int i = 0; i < toppings.Count(); i++)
            {
                var topping = toppings[i];
                var rank = i + 1;

                Console.WriteLine("#{0}: {1} ({2})", rank, topping.Topping, topping.Total);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Gets the toppings.
        /// </summary>
        /// <returns>A list of the toppings in descending order</returns>
        private static List<Rank> GetToppings()
        {
            IKernel kernel = new StandardKernel();
            kernel.Load<BusinessLogicModule>();

            var service = kernel.Get<IOrderService>();

            return service.MostPopularToppings(20);
        }
    }
}
