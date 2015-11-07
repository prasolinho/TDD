using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Money
    {
        private Dictionary<string, decimal> exchangeRates = new Dictionary<string, decimal>(2);

        protected int amount;
        protected string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;

            exchangeRates.Add("USD-CHF", 2);
            exchangeRates.Add("CHF-USD", 0.5M);
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public string Currency()
        {
            return currency;
        }

        public Money Plus(Money addend)
        {
            return new Money(amount + ConvertCurrency(addend.amount, addend.currency, currency) , currency);
        }

        private int ConvertCurrency(int amount, string orginalCurrency, string targerCurrency)
        {
            if (orginalCurrency == targerCurrency)
                return amount;

            return Convert.ToInt32(amount * exchangeRates[string.Format("{0}-{1}", orginalCurrency, targerCurrency)]);
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && Currency().Equals(money.Currency());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", amount, currency);
        }


    }
}
