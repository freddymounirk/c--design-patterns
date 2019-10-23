using System;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            RunCommandDesignPatternDemo();
        }

        private static void RunCommandDesignPatternDemo()
        {
            ModifyPrice modifyPrice = new ModifyPrice();
            Product product = new Product("IPhone", 900);

            ExcecuteCommand(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 700));
            ExcecuteCommand(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 200));
            ExcecuteCommand(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 300));
            ExcecuteCommand(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 200));
        }

        private static void ExcecuteCommand(Product _product, ModifyPrice _modifyPrice, ICommand productCommand)
        {
            _modifyPrice.SetCommand(productCommand);
            _modifyPrice.Invoke();
            Console.WriteLine(_product.ToString());
        }
    }
}
