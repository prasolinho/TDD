using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Model;

namespace Testy
{
    [TestFixture]
    public class Testy
    {
        [Test]
        public void testDollarMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.AreEqual(Money.Dollar(10), five.Times(2));
            Assert.AreEqual(Money.Dollar(15), five.Times(3));
        }

        [Test]
        public void testEquality()
        {
            Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.IsFalse(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [Test]
        public void testCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency());
            Assert.AreEqual("CHF", Money.Franc(1).Currency());
        }

        [Test]
        public void testSimpleAddition()
        {
            Money sum = Money.Dollar(5).Plus(Money.Dollar(6));
            Assert.AreEqual(Money.Dollar(11), sum);
        }

        [Test]
        public void testDifferentCurrenciesAddiotion()
        {
            Money sum = Money.Dollar(5).Plus(Money.Franc(10));
            Assert.AreEqual(Money.Dollar(10), sum); 
        }
    }
}
