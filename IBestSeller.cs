using System;
using ClassLibraryBookFinder;

namespace DetermineBestSeller
{
    public interface IBestSeller
    {
        //public string sortList(string booklist);
        public string showBestSellerList(int year);
    }
}
