﻿using System;
using System.Linq;
using System.Text;

namespace Book_Shop.Models
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        private string name;
        private char firstSymbol;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Author
        {
            get => this.author;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Author not valid!");
                }

                if (value.Any(v => !(char.IsWhiteSpace(v) || char.IsLetter(v))))
                {
                    throw new ArgumentException("Author not valid!");
                }

                string[] names = value.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (names.Length > 1)
                {
                    this.name = names[1];
                    this.firstSymbol = this.name[0];
                }

                if (char.IsDigit(this.firstSymbol))
                {
                    throw new ArgumentException("Author not valid!");
                }

                this.author = value;
            }
        }

        public string Title
        {
            get => this.title;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value[0] == ' ' || value.Length < 3 )
                {
                    throw new ArgumentException("Title not valid!");
                }

                this.title = value;
            }
        }

        public virtual decimal Price
        {
            get => this.price;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Title: {this.Title}");
            sb.AppendLine($"Author: {this.Author}");
            sb.AppendLine($"Price: {this.Price:f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
