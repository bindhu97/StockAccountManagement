using StockAccountManagement;
using System;

namespace JSON_Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stock Inventory Management");
            StockInventory management = new StockInventory();
            string stockFilePath = @"C:\Users\91973\source\repos\StockAccountManagement\StockAccountManagement\Stock.json";
            string customerFilePath = @"C:\Users\91973\source\repos\StockAccountManagement\StockAccountManagement\Customer.json";
            management.ReadStockJsonFile(stockFilePath);
            management.ReadCustomerJsonFile(customerFilePath);
            management.BuyStock("Amazon");
            management.SellStock("Amazon");
            management.WriteToStockJsonFile(stockFilePath);
            management.WriteToCustomerJsonFile(customerFilePath);
        }
    }
}