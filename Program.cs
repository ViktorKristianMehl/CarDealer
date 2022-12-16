carDealer player = new carDealer(0);
player.showCars();
Console.WriteLine("Hello there. You are owner of a car shop with the objective of selling as many cars as possible");
Thread.Sleep(500);
Console.WriteLine("Do you wish to see the cars you have?");
string answer = Console.ReadLine();

if (answer == "yes")
{
    player.showCars();
}
else
{
    Environment.Exit(0);

}

Console.WriteLine("do yo want to see advanced information about the cars?");
string advancedAnswer = Console.ReadLine();
if (advancedAnswer == "yes")
{
    player.showList();
}

    Console.ReadLine();

   {
    Customer Jesper = new Customer(123f);
    Jesper.BuyMethod(1000f, player.randomCars[0]);

  
   }

