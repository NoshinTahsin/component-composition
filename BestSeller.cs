using System;
using ClassLibraryBookFinder;

namespace DetermineBestSeller
{
    public class BestSeller
    {

        private IBestSeller bs;
        private IBookFinder b_finder;
        public BestSeller(IBestSeller bs)
        {
            this.bs = bs;
        }
        public string showrequired(int year)
        {
            return this.bs.showBestSellerList(year);
        }
        public string showBestSellerList(int year)
        {
            BookFinder bookfinder = new BookFinder(b_finder);

            string booklist = bookfinder.findBooks(year);

            Console.WriteLine("Fetching data...");
            Console.WriteLine("Returned " + booklist + "\n");

            Console.WriteLine("Sorting data...Preparing top 20 best seller list...");
            String top_20_bestsellers = "List of top 20 best sellers.";
            Console.WriteLine("Returned " + top_20_bestsellers + "\n");
            return top_20_bestsellers;

        }
    }
}
