using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCreditCardInterest
{
    public class Person
    {
        private double totalInterestPerPerson;

        List<Wallet> walletList = new List<Wallet>();

        
        public void addWallet(Wallet p_Wallet)
        {
            walletList.Add(p_Wallet);
        }

        public double getTotalInterestPerPerson()
        {
            foreach (var wal in walletList)
            {
                Console.WriteLine("total interest per wallet: " + wal.getTotalInterest());
                totalInterestPerPerson += wal.getTotalInterest();
            }
            Console.WriteLine("total interest per person: " + totalInterestPerPerson);
            return totalInterestPerPerson;            
        }

    }
}
