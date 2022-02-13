using System;

namespace ClassLibraryBookFinder
{
    public class BookFinder:IBookFinder
    {
        private IBookFinder bookfinder;

        public BookFinder(IBookFinder bookfinder)
        {
            this.bookfinder = bookfinder;
        }
        public string showrequired()
        {
            return this.bookfinder.findBooks(2021);
        }
        public string findBooks(int year)
        {
            string books_of_year = "List of books sold in " + year;
            return books_of_year;

        }
    }
}
