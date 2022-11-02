List<string> CarBrands = new List<string>() {
"Volvo",
"Volkswagen",
"Toyota",
"Ford",
"Mercedes",
"BMW",
"Audi",
"Kia",
"Renault",
"Peugeot"
};
List<string> CarColors = new List<string>() {
"Blue",
"Red",
"Grey",
"Black",
"White",
"Green",
"Orange",
"Purple",
"Yellow",
"Pink",
"Silver"
};

Random brandRNG = new Random();
Random colorRNG = new Random();
int brandNum = brandRNG.Next(0, 9);
int colorNum = colorRNG.Next(0, 9);


Car car1 = new Car(CarBrands[brandNum], CarColors[colorNum]);
Car car2 = new Car(CarBrands[brandNum], CarColors[colorNum]);
Car car3 = new Car(CarBrands[brandNum], CarColors[colorNum]);

Console.WriteLine("your car is a " + car1.brand + " and has the color " + car1.color);

Console.ReadLine();
