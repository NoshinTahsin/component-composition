using System;
using ClassLibraryBookFinder;
using DetermineBestSeller;

namespace MainProject
{
    class ProgramClass : IBestSeller
    {
        public string showBestSellerList(int year)
        {
            return "Best Seller Book List of "+year+"...";
        }
    }
}
