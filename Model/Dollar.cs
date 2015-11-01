using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Klasa reprezentująca dolar amerykański.
    /// </summary>
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {

        }
    }
}
