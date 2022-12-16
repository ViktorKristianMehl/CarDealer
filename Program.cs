
Console.WriteLine("Hello there. You are owner of a car shop with the objective of selling as many cars as possible");
Thread.Sleep(500);
Console.WriteLine("These are the cars you have in your dealership");
Thread.Sleep(200);
carDealer player = new carDealer(1000);
player.ShowCars();


Console.WriteLine("wanna see them again?");
string answerTwo = Console.ReadLine();

if (answerTwo == "yes")
{
    player.ShowAgain();
}

Console.ReadLine();
