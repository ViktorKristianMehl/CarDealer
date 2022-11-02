
Random brandRNG = new Random();
Random colorRNG = new Random();
int brandNum = brandRNG.Next(0, 9);
int colorNum = colorRNG.Next(0, 9);


Car car1 = new Car(StaticCars.CarBrands[brandNum], StaticCars.CarColors[colorNum]);
Car car2 = new Car(StaticCars.CarBrands[brandNum], StaticCars.CarColors[colorNum]);
Car car3 = new Car(StaticCars.CarBrands[brandNum], StaticCars.CarColors[colorNum]);

Console.WriteLine("your car is a " + car1.brand + " and has the color " + car1.color);
Console.WriteLine("do you want to drive your " + car1.color + " " + car1.brand + "?");
string answer = Console.ReadLine();
if (answer == "yes")
{
    car1.DriveMethod();
}
if (car1.Driving == true)
{
    Console.WriteLine("you are now driving");
}


Console.ReadLine();
