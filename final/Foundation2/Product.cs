using System;

class Product
{
    private int _prodID;
    private string _prodName;
    private float _price;
    private int _quantity;

    public Product()
    {

    }

    public Product(int ID, string prod, float cost, int quant)
    {
        ID = _prodID;
        prod = _prodName;
        cost = _price;
        quant = _quantity;

    }

    public float totalCost(int quantity, float price)
    {
        float total = quantity * price;
        return total;
    }
}