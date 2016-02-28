using System.Collections.Generic;

namespace Olo.Model
{
    /// <summary>
    /// Class descibing a pizza with toppings
    /// </summary>
    public class Pizza
    {
        /// <summary>
        /// Gets or sets a list of all the available toppings on a pizza
        /// </summary>
        /// <value>
        /// The toppings.
        /// </value>
        public List<string> Toppings { get; set; }
    }
}
