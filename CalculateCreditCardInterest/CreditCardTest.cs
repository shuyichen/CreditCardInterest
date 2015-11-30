using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace CalculateCreditCardInterest
{
    [TestFixture]
    public class CreditCardTest
    {
        [Test]
        public void TestCase1()
        {
            // test case 1 data setup
            // wallet credit cards
            List<string> creditCardList = new List<string>();
            creditCardList.Add("Visa");
            creditCardList.Add("MasterCard");
            creditCardList.Add("Discover");

            // test case 1 person

            Person personA = new Person();
            Wallet walletA = new Wallet(creditCardList);
            personA.addWallet(walletA);            

            Assert.AreEqual(16, personA.getTotalInterestPerPerson());
        }

        [Test]
        public void TestCase2()
        {
            // test case 2 data setup
            // wallet 1 credit cards
            List<string> creditCardList1 = new List<string>();
            creditCardList1.Add("Visa");
            creditCardList1.Add("Discover");

            // wallet 2 credit cards
            List<string> creditCardList2 = new List<string>();
            creditCardList2.Add("MasterCard");

            Person personB = new Person();
            Wallet wallet1 = new Wallet(creditCardList1);
            personB.addWallet(wallet1);
            
            Assert.AreEqual(11, wallet1.getTotalInterest());

            Wallet wallet2 = new Wallet(creditCardList2);
            personB.addWallet(wallet2);

            Assert.AreEqual(5, wallet2.getTotalInterest());

            Assert.AreEqual(16, personB.getTotalInterestPerPerson());
        }

        [Test]
        public void TestCase3()
        {
            // test case 3 data setup
            // wallet 3 credit cards
            List<string> creditCardList3 = new List<string>();
            creditCardList3.Add("MasterCard");
            creditCardList3.Add("Visa");

            // wallet 4 credit cards
            List<string> creditCardList4 = new List<string>();
            creditCardList4.Add("Visa");
            creditCardList4.Add("MasterCard");

            Person personC = new Person();
            Wallet wallet3 = new Wallet(creditCardList3);
            personC.addWallet(wallet3);            

            Assert.AreEqual(15, personC.getTotalInterestPerPerson());

            Person personD = new Person();
            Wallet wallet4 = new Wallet(creditCardList4);
            personD.addWallet(wallet4);            

            Assert.AreEqual(15, personD.getTotalInterestPerPerson());
        }

    }
}
