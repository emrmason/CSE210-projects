using System;

class Program
{
    static void Main(string[] args)
    {
    List<string> menuOpts = new List<string>
    {
        "1. Add a new customer",
        "2. Create a new order",
        "3. Print packing label",
        "4. Print shipping label",
        "5. Print customer receipt",
        "6. Quit"
    };

        List<Order> orders = new List<Order>();
        bool start = true;
        Console.WriteLine("Welcome to the product ordering program.\nWhat would you like to do?");
        while(start == true)
        {
            for(int x = 0; x < menuOpts.Count; x++)
            {
                Console.WriteLine(menuOpts[x]);
            }
            int choice = Int32.Parse(Console.ReadLine());

            if(choice == 1)
            {
                Customer customer = new Customer();
                customer.createCustomer();
                start = true;
            }
            else if(choice == 2)
            {
                Order order = new Order();
                order.newOrder();
                orders.Add(order);
                start = true;
            }
            else if(choice == 3)
            {
                for(int x = 0; x < orders.Count; x++)
                {
                    
                }

            }
            else if(choice == 4)
            {
                

            }
            else if(choice == 5)
            {

            }
            else if(choice == 6)
            {
                Console.WriteLine("Thank you for using our program, goodbye.");
                start = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid selection, please try again.");
                start = true;
            }
        }





    }
}