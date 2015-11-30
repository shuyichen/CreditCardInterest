using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCreditCardInterest
{
    public abstract class CreditCard
    {
        public abstract double GetBalance();
        public abstract double GetInterestRate();
        public abstract double GetInterest();
    }

    public class Visa : CreditCard
    {
        public override double GetBalance()
        {
            return 100;
        }

        public override double GetInterestRate()
        {
            return 0.1;
        }

        public override double GetInterest()
        {
            return GetBalance() * GetInterestRate();
        }
    }

    public class MasterCard : CreditCard
    {
        public override double GetBalance()
        {
            return 100;
        }

        public override double GetInterestRate()
        {
            return 0.05;
        }

        public override double GetInterest()
        {
            return GetBalance() * GetInterestRate();
        }
    }

    public class Discover : CreditCard
    {
        public override double GetBalance()
        {
            return 100;
        }

        public override double GetInterestRate()
        {
            return 0.01;
        }

        public override double GetInterest()
        {
            return GetBalance() * GetInterestRate();
        }
    }
}
