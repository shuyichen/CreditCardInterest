using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCreditCardInterest
{
    public class Wallet
    {
        enum creditCardType
        {            
            Visa,
            MasterCard,
            Discover
        };
        private double totalInterest = 0.0;

        public Wallet(List<string> creditcards)
        {
            calcTotalInterest(creditcards);
        }

        public double getTotalInterest()
        {
            return totalInterest;
        }

        private void calcTotalInterest(List<string> creditcards)
        {
            foreach (var card in creditcards)
            {
                totalInterest += cardTypeInterestAmount(card);
                Console.WriteLine("card " + card);
            }
        }

        double cardTypeInterestAmount(string card)
        {            
            creditCardType cardType = (creditCardType)Enum.Parse(typeof(creditCardType), card);

            switch (cardType)
            {
                case creditCardType.Visa:
                    Visa visaCard = new Visa();
                    return visaCard.GetInterest();

                case creditCardType.MasterCard:
                    MasterCard mcCard = new MasterCard();
                    return mcCard.GetInterest();

                case creditCardType.Discover:
                    Discover discover = new Discover();
                    return discover.GetInterest();
            }
            return 0.0;
        }

    }

}
