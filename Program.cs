using System;
using ClassLibraryBookFinder;
using DetermineBestSeller;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new ProgramClass();
            var dbs = new BestSeller(x);
            Console.WriteLine("Showing " + dbs.showrequired(2021));

           /* IBestSeller dbs = new BestSeller();
            String best_seller_list = dbs.showBestSellerList(2021);
            Console.WriteLine("Showing <" + best_seller_list+">");*/

        }
    }
}
