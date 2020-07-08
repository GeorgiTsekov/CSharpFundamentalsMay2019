
namespace P03ShoppingSpree.People
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Exceptions;
    using P03ShoppingSpree.People.Products;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person()
        {
            this.bag = new List<Product>();
        }

        public Person(string name, decimal money)
            : this()
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMesseges.InvalidInput);
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMesseges.NegativeNumber);
                }

                this.money = value;
            }
        }

        public void BuyProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                throw new InvalidOperationException(String.Format(ExceptionMesseges.CannotAffordAProductException, this.Name, product.Name));
            }
            else
            {
                this.Money -= product.Cost;
                bag.Add(product);

                throw new InvalidOperationException(String.Format(ExceptionMesseges.AffordAProductException, this.Name, product.Name));
            }
        }

        public override string ToString()
        {
            if (this.bag.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }

            return $"{this.Name} - {string.Join(", ", bag)}";
        }
    }
}
