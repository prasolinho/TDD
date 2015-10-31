using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Money
    {
        protected int amount;
        protected string currency;

        public abstract Money Times(int multiplier);
        public abstract string Currency();

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && GetType().Equals(obj.GetType());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
