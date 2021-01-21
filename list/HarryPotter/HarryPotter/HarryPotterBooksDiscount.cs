using System;
using System.Collections;

namespace HarryPotterBook
{
    public class HarryPotterBooksDiscount
    {
        private readonly double price = 8;

        public double CountDiscount(ArrayList books)
        {
            double total = 0;
            while (books.Count > 0)
            {
                ArrayList list = new ArrayList();
                for (int i = 0; i < books.Count; i++)
                {

                    if (list.Contains(books[i]) == false)
                    {
                        list.Add(books[i]);
                        books.RemoveAt(i);
                        i = 0;
                    }
                    if (books.Count == 1)
                    {
                        if (list.Contains(books[i]) == false)
                        {
                            list.Add(books[i]);
                            books.RemoveAt(i);
                        }
                    }

                }
                //deleteCopies(ref books, ref list);
                double totalWithoutDiscount = price * Convert.ToDouble(list.Count);
                total += totalWithoutDiscount - ((totalWithoutDiscount * GetDiscount(list))/100);

            }
            return total;
        }

        private void deleteCopies(ref ArrayList books, ref ArrayList list)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (list.Contains(books[i]))
                {
                    books.RemoveAt(i);
                }
            }
        }

        private double GetDiscount(ArrayList list)
        {
            switch (list.Count)
            {
                case 2: return 5;
                case 3: return 10;
                case 4: return 20;
                case 5: return 25;
                default: return 0;
            }
        }

    }
}
