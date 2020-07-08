using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book
    {
        public string Title { get; private set; }
        public int Year { get; private set; }
        public List<string> Autors { get; private set; }

        public Book(string title, int year, params string[] autors)
        {
            this.Title = title;
            this.Year = year;
            this.Autors = autors.ToList();
        }
    }
}
