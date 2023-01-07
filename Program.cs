
class Dealership
{

    private static Customer customer = new Customer(20000f);
    private static CarDealer dealer = new CarDealer(1000f, 5);


    private static int mainMenuOption { get; set; }

    private static char isPurchasing { get; set; }
    private static int chosenCar { get; set; }

    private static void getOwnedCars()
    {


        foreach (KeyValuePair<int, Car> i in customer.ownedCars)
        {
            Car chosenCar = i.Value;


            Console.WriteLine(
                "Brand: " + chosenCar.brand
                +
                "\nColor: " + chosenCar.color
                +
                "\nDamage: " + chosenCar.Damage + "% \n"
                +
                "Price: " + chosenCar.Price + "$\n"
                + "Max Speed: " + chosenCar.MaxSpeed + " km/h \n"
                + "------------------"
            );
        }
    }


    private static void purchaseCar(int carNumber)
    {
        if (!dealer.carExists(carNumber))
        {
            Console.WriteLine("Car doesn't exist, please choose another.");
            Thread.Sleep(800);
            Main();
        }

        Car chosenCar = dealer.getCar(carNumber);

        if (customer.purchaseCar(carNumber, chosenCar))
            Console.WriteLine("Car purchased successfully!");
        else
            Console.WriteLine("Failed to purchase car");

        Main();
    }


    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("You are the customer of a dealership, you can buy & sell cars");
        Console.WriteLine("You have " + customer.Money + " dollars to spend");
        Console.WriteLine("1. See your cars\n2. Sell a car\n3. Buy a car\n");
        if (customer.Money < 0)
        {
            Console.WriteLine("you went into debt, game over..");
            Console.ReadKey();
            Environment.Exit(0);
        }

        mainMenuOption = Convert.ToInt32(Console.ReadLine());

        switch (mainMenuOption)
        {
            case 1:
                Console.Clear();

                if (customer.ownedCars.Count > 0)
                    getOwnedCars();
                else
                    Console.WriteLine("You do not own any cars, buy one...");

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Main();
                break;
            case 2:
                Console.Clear();
                if (customer.ownedCars.Count > 0)
                {
                    getOwnedCars();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You have no cars to sell...");
                    Thread.Sleep(500);
                    Console.WriteLine("Press any key to return to menu");
                    Console.ReadKey();
                    Main();
                }
                Console.WriteLine("which car do you wanna sell? (number)");
                Main();
                break;
            case 3:
                Console.Clear();
                dealer.ShowCars();
                Console.WriteLine("Do you want to purchase a car? (y/n)");


                isPurchasing = Convert.ToChar(Console.ReadLine());

                if (isPurchasing == 'n')
                    Main();
                else if (isPurchasing != 'y')
                    Main();

                Console.WriteLine("Which car do you wish to purchase? (number)");
                chosenCar = Convert.ToInt32(Console.ReadLine());

                purchaseCar(chosenCar);
                Main();

                break;
            default:
                Console.Clear();
                Console.WriteLine("Thats not an option.");
                Thread.Sleep(500);
                Main();
                break;
        }


    }
}
