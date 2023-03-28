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
        "6. List customers",
        "7. Quit"
    };

        List<Customer> customers = new List<Customer>();

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
                customer.displayCustomers();
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
                foreach(Order order in orders)
                {
                    string line = order.ToString();
                    string[] index = line.Split(' ');
                    string custID = index[0];
                    string orderNum = index[1];
                    string product = index[2];
                    string packLabel = $"{orderNum}";
                    string part = $"{product}";
                    Console.WriteLine(packLabel, part);
                }
                
                start = true;

            }
            else if(choice == 4)
            {
                Customer customer = new Customer();
                Console.WriteLine("What is the customer number? ");
                int custID = Int32.Parse(Console.ReadLine());
                customer.shipLabel(custID);
                //Console.WriteLine();
                start = true;

            }
            else if(choice == 5)
            {
                foreach(Order order in orders)
                {
                    Console.WriteLine($"{order._custID}, {order._product}");
                }
            }
            else if(choice == 6)
            {
                Customer customer1 = new Customer();
                foreach(Customer customer in customers)
                customer.displayCustomers();

            }
            else if(choice == 7)
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