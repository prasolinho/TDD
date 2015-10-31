using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Klasa reprezentująca Frank Szwajcarski
    /// </summary>
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency)
        {
            
        }

        public override Money Times(int multiplier)
        {
            //return new Money(amount * multiplier, currency);
            return Money.Franc(amount * multiplier);
        }

        public override string Currency()
        {
            return "CHF";
        }
    }
}
