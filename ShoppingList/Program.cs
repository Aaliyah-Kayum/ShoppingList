using System.Collections;

Console.WriteLine("Welcome to Guenther's Market!");
Console.WriteLine("Item              Price");
Console.WriteLine("=======================");


Dictionary<string, double> Shop = new Dictionary<string, double>()
{
    ["apple"] = 0.99,
    ["banana"] = 0.59,
    ["cauliflower"] = 1.59,
    ["dragonfruit"] = 2.19,
    ["elderberry"] = 1.79,
    ["figs"] = 2.09,
    ["grapefruit"] = 1.99,
    ["honeydew"] = 3.49
};
foreach (KeyValuePair<string, double> kvp in Shop)
{
    Console.WriteLine($"apple           {0.99}");
    Console.WriteLine($"banana          {0.59}");
    Console.WriteLine($"cauliflower     {1.59}");
    Console.WriteLine($"dragonfruit     {2.19}");
    Console.WriteLine($"elderberry      {1.79}");
    Console.WriteLine($"figs            {2.09}");
    Console.WriteLine($"grapefruit      {1.99}");
    Console.WriteLine($"honeydew        {3.49}");
}
do
{
    Console.WriteLine("What item would you like to order?");
    string order = Console.ReadLine();

    if (Shop.ContainsKey(order))
    {
        Console.WriteLine($"Adding {order} to cart");
    }
    else
    {
        Console.WriteLine("Sorry, we don't have those. Please try again.");
    }

    Console.WriteLine("Would you like to order anything else (y/n)?");
    string choice = Console.ReadLine();
    if (choice == "y")
    {
        continue;
    }
    if (choice == "n")
    {
        Console.WriteLine("Thanks for your order!");
        Console.WriteLine($"Here's what you got: {order}");
        break;
    }
}
while (true);