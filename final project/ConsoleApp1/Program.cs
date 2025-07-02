using System;
public class InventoryManager
{
    static List<string> productsList = new List<string>();
    static List<float> productsPrice = new List<float>();
    static List<int> productsStock = new List<int>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine(@"Inventory Manager
            1. Add Product.
            2. Update Stock.
            3. View Products.
            4. Remove Product.
            5. Exit.
            What would you like to do? (choose 1-5)");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    UpdateStock();
                    break;
                case "3":
                    ViewProducts();
                    break;
                case "4":
                    RemoveProducts();
                    break;
                case "5":
                    Console.WriteLine("Thank you for using this software.");
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    static void EmptyProduct()
    {
        Console.WriteLine("No products available to process.");
    }

    static void InvalidProductNum()
    {
        Console.WriteLine("Invalid product number.");
    }

    static void AddProduct()
    {
        Console.Write("Enter product name: ");
        string product = Console.ReadLine();
        productsList.Add(product);
        Console.Write("Enter product price: ");
        float price = float.Parse(Console.ReadLine());
        productsPrice.Add(price);
        Console.Write("Enter product stock: ");
        int stock = int.Parse(Console.ReadLine());
        productsStock.Add(stock);
        Console.Write("Product: {product}, added successfully.");
    }

    static void UpdateStock()
    {
        Console.WriteLine("Update Stock");
        if (productsList.Count == 0)
        {
            EmptyProduct();
            return;
        }

        Console.Write("Enter the product number: ");
        if (int.TryParse(Console.ReadLine(), out int productNumber) && productNumber > 0 && productNumber <= productsList.Count)
        {
            Console.WriteLine("Enter the new stock for " + productsList[productNumber - 1]);
            int newStock = int.Parse(Console.ReadLine());
            productsStock[productNumber - 1] = newStock;
            Console.WriteLine($"Stock for '{productsList[productNumber - 1]}' has been updated.");
        }
        else
        {
            InvalidProductNum();
        }
    }

    static void ViewProducts()
    {
        if (productsList.Count == 0)
        {
            EmptyProduct();
            return;
        }

        Console.WriteLine("Current Products:");
        for (int i = 0; i < productsList.Count; i++)  
        {
            Console.WriteLine($"{i + 1}. Product: {productsList[i]} - Price: {productsPrice[i]} - Stock: {productsStock[i]}");
        }
    }

    static void RemoveProducts()
    {
        Console.WriteLine("Remove Products");
        if (productsList.Count == 0)
        {
            EmptyProduct();
            return;
        }

        Console.Write("Enter the product number: ");
        if (int.TryParse(Console.ReadLine(), out int productNumber) && productNumber > 0 && productNumber <= productsList.Count)
        {
            string removed = productsList[productNumber - 1];
            productsList.Remove(removed);
            productsPrice.Remove(productsPrice[productNumber - 1]);
            productsStock.Remove(productsStock[productNumber - 1]);
            Console.WriteLine($"Product '{removed}' has been removed.");
        }
        else
        {
            InvalidProductNum();
        }
    }
}