using NUnit.Framework;
using System.Collections;
using M8Project;

namespace M8Tests
{
    public class HarryPotterTest
    {
        private ArrayList bookList;
        private HarryPotterBooksDiscount hpbook;

        [SetUp]
        public void Setup()
        {
            hpbook = new HarryPotterBooksDiscount();
            bookList = new ArrayList();
        }

        [Test]
        public void CountDiscount_8booksHasCopies_returns51point60()
        {
            string one = "first book";
            string two = "Second book";
            string three = "Third book";
            string four = "Fourth book";
            string five = "Fifth book";

            bookList.Add(one);
            bookList.Add(one);

            bookList.Add(two);
            bookList.Add(two);

            bookList.Add(three);
            bookList.Add(three);

            bookList.Add(four);
            bookList.Add(five);

            Assert.AreEqual(51.60, hpbook.CountDiscount(bookList));
        }
    }
}


