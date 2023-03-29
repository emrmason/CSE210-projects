using System;

class Product
{
    List<Product> products = new List<Product>();
    // {
    //     "1| Outdoor Tent |100",
    //     "2| 50 foot tarpaulin |50",
    //     "3| Dehydrated meals(10) |30",
    //     "4| Hiking boots |45",
    //     "5| Waterproof rain jacket |50",
    //     "6| Backpack |35",
    //     "7| Camping Stove |40",
    //     "8| Fire starting kit |10"
    // };

    public int _prodID;
    public string _prodName;
    public double _price;
    public int _quantity;

    public Product()
    {

    }

    public Product(int ID, string prod, double cost)
    {
        ID = _prodID;
        prod = _prodName;
        cost = _price;
        int quant = _quantity;

    }

    public double totalCost(int quantity, float price)
    {
        double total = quantity * price;
        Console.WriteLine($"Total Cost: ${total}");
        return total;
    }
    
    
    // public string addProducts()
    // { 
    //     Console.WriteLine("Which product would you like to add? ");
    //     foreach(string product in products)
    //     {
    //         string[] item = product.Split('|');
    //         _prodID = Convert.ToInt32(item[0]);
    //         _prodName = item[1];
    //         _price = Convert.ToDouble(item[2]);
    //         Console.WriteLine($"{_prodID}. {_prodName}, ${_price}");
    //     }
    //     int adding = Int32.Parse(Console.ReadLine());
    //         if(adding == _prodID)
    //         {
    //             Console.WriteLine($"How many would you like to add to your order?");
    //             int quantity = Int32.Parse(Console.ReadLine());
    //             quantity = _quantity;
    //             Console.WriteLine($"{quantity} {_prodName} has been added to your order.");
    //         }
    //     string summary = $"{_quantity} {_prodName}";
    //     return summary;
    // }
}