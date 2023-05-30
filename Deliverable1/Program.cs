int sodaStock = 100;
int sodaRestock = 40;
int chipStock = 40;
int chipRestock = 20;
int candyStock = 60;
int candyRestock = 40;

Console.WriteLine("Welcome to the restocking tool.");
Console.WriteLine($"How many Sodas have been sold today? {sodaStock} are in stock.");

int sodaSold = int.Parse(Console.ReadLine());

if (sodaSold <= sodaStock) 
{
    sodaStock -= sodaSold;
    Console.WriteLine($"There are {sodaStock} Sodas left.");
}
else 
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}

Console.WriteLine($"How many Chips have been sold today? {chipStock} are in stock.");

int chipSold = int.Parse(Console.ReadLine());

if (chipSold <= chipStock)
{
    chipStock -= chipSold;
    Console.WriteLine($"There are {chipStock} Chips left.");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}

Console.WriteLine($"How many Candies have been sold today? {candyStock} are in stock.");

int candySold = int.Parse(Console.ReadLine());

if (candySold <= candyStock)
{
    candyStock -= candySold;
    Console.WriteLine($"There are {candyStock} Candies left.");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}

Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked:");

if (sodaStock <= sodaRestock || chipStock <= chipRestock || candyStock <= candyRestock)
{
    if (sodaStock <= sodaRestock)
    {
        Console.WriteLine("Soda needs to be restocked.");
    }

    if (chipStock <= chipRestock)
    {
        Console.WriteLine("Chips need to be restocked.");
    }

    if (candyStock <= candyRestock)
    {
        Console.WriteLine("Candy needs to be restocked.");
    }
}
else
{
    Console.WriteLine("Nothing needs to be restocked.");
}

Console.WriteLine("Goodbye!");