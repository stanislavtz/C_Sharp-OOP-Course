using Book_Shop.Models;
using System;

namespace Book_Shop.Core
{
    public class Engine
    {
        private string author;
        private string title;
        private decimal price;

        private Book book;
        private GoldenEditionBook goldenEditionBook;

        public void Run()
        {
            try
            {
                this.author = Console.ReadLine();
                this.title = Console.ReadLine();
                bool isPrice = decimal.TryParse(Console.ReadLine(), out this.price);

                if (!isPrice)
                {
                    throw new ArgumentException("Price not valid!");
                }

                this.book = new Book(this.author, this.title, this.price);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            this.goldenEditionBook = new GoldenEditionBook(this.author, this.title, this.price);

            Console.WriteLine(this.book + Environment.NewLine);
            Console.WriteLine(this.goldenEditionBook);
        }
    }
}
