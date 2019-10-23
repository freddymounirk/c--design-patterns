using System;
namespace design_patterns
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void IncreasePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"The price of {Name} increased by {amount}$");
        }

        public void DecreasePrice(int amount)
        {
            Price -= amount;
            Console.WriteLine($"The price of {Name} decreased by {amount}$");
        }

        public override string ToString() => $"Current price of {Name} is {Price}$";
    }
}