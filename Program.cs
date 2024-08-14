using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;


{
    // use dictionary
    Dictionary<string, decimal> storePrices = new Dictionary<string, decimal>();

    //store items
    storePrices.Add("soda", 1.00m);
    storePrices.Add("chips", 1.50m);
    storePrices.Add("lettuce", 2.50m);
    storePrices.Add("steak", 15.50m);
    storePrices.Add("milk", 5.50m);
    storePrices.Add("soup", .75m);
    storePrices.Add("rice", 1.50m);
    storePrices.Add("bread", 2.00m);
    storePrices.Add("pizza", 4.00m);

    // shopping list
    List<string> shoppingList = new List<string>();

    bool continueShopping = true;

    while (continueShopping)
    {

        Console.WriteLine("Menu:");
        foreach (KeyValuePair<string, decimal> kvp in storePrices)
        {
            Console.WriteLine($"{kvp.Key} : ${kvp.Value}");
        }
        Console.Write("Enter an item name to add to your order: ");
        string itemName = Console.ReadLine();

        if (storePrices.ContainsKey(itemName))
        {
            shoppingList.Add(itemName);
            Console.WriteLine($"Added {itemName} to your order at ${storePrices[itemName]}");
        }
        else
        {
            Console.WriteLine("We don't have that item, please try again.");
        }

        Console.WriteLine("Do you want to continue shopping? y/n");
        string response = Console.ReadLine();
        continueShopping = response == "y";
        


        
            decimal total = 0;


            Console.WriteLine($"Your cart is:");
            foreach (string itemNames in shoppingList)
            {
            
            Console.WriteLine($"{itemNames}   ${storePrices[itemNames]}");
            decimal price = storePrices[itemNames];
            total += price;


        }
            Console.WriteLine("Total Cost " + total);
           

        if (shoppingList.Count > 0)
        {
            decimal mostExpensiveprice = decimal.MinValue;
            decimal leastExpensiveprice = decimal.MaxValue;
            string mostExpensiveitem = "";
            string leastExpensiveitem = "";

            foreach (string itemNames in shoppingList)
            {
                decimal price = storePrices[itemNames];
                if (price > mostExpensiveprice)
                {
                    mostExpensiveprice = price;
                    mostExpensiveitem = itemNames;
                }
                if (price < leastExpensiveprice)
                {
                    leastExpensiveprice = price;
                    leastExpensiveitem = itemNames;
                }
            }
            Console.WriteLine($"Most Expensive Item: {mostExpensiveitem} is ${mostExpensiveprice}");
            Console.WriteLine($"Least Expensive Item: {leastExpensiveitem} is ${leastExpensiveprice}");



        }

    }

}



