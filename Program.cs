carDealer player = new carDealer(0);
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

Console.WriteLine("your car is a " + carDealer.randomCars[0].brand + " and has the color " + randomCars[0].color);
Console.WriteLine("do you want to drive your " + randomCars[0].color + " " + randomCars[0].brand + "?");
string answer = Console.ReadLine();
if (answer == "yes")
{
    randomCars[0].DriveMethod();
}
if (randomCars[0].Driving == true)
{
    Console.WriteLine("you are now driving");
}


Console.ReadLine();
