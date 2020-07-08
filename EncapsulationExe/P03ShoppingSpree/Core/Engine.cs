
namespace P03ShoppingSpree.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using P03ShoppingSpree.People;
    using P03ShoppingSpree.People.Products;

    public class Engine
    {
        private List<Person> persons = new List<Person>();
        private List<Product> products = new List<Product>();

        public Engine()
        {
            this.persons = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            try
            {
                ReadPersonsInput();
                ReadProductsInput();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] personAndProduct = command
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string personName = personAndProduct[0];
                    string productName = personAndProduct[1];

                    Person person = this.persons.FirstOrDefault(p => p.Name == personName);
                    Product product = this.products.FirstOrDefault(p => p.Name == productName);

                    if (person != null && product != null)
                    {
                        person.BuyProduct(product);
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, this.persons));
        }

        private void ReadProductsInput()
        {
            string[] productsByNameAndCost = Console.ReadLine()
                                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var productNameAndCost in productsByNameAndCost)
            {
                string[] nameAndCost = productNameAndCost
                    .Split("=");

                string productName = nameAndCost[0];
                decimal productCost = decimal.Parse(nameAndCost[1]);

                Product product = new Product(productName, productCost);

                this.products.Add(product);
            }
        }

        private void ReadPersonsInput()
        {
            string[] peopleByNamesAndMoney = Console.ReadLine()
                                .Split(";",StringSplitOptions.RemoveEmptyEntries);

            foreach (var personNameAndAge in peopleByNamesAndMoney)
            {
                string[] nameAndMoney = personNameAndAge
                    .Split("=");

                string personName = nameAndMoney[0];
                decimal personMoney = decimal.Parse(nameAndMoney[1]);

                Person person = new Person(personName, personMoney);

                this.persons.Add(person);
            }
        }
    }
}
