
class Dealership
{
    // players
    private static Customer customer = new Customer(1000f);
    private static readonly protected CarDealer dealer = new CarDealer(1000f, 5);

    // variables
    private static int mainMenuOption { get; set; }

    private static char isPurchasing { get; set; }
    private static int chosenCar { get; set; }

    private static void getOwnedCars()
    {
        // this loop doesnt grab from the customers owned cars for some reason
        // it grabs all cars and i have no clue why

        foreach (KeyValuePair<int, Car> i in customer.ownedCars) // this should be grabbing the dict of ownedcars the customer has
        {
            Car chosenCar = i.Value; // this dereferences customers ownedcars into a variable


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
        // like this, do you prefer this? its fine either way
        if (customer.purchaseCar(carNumber, chosenCar))
            Console.WriteLine("Car purchased successfully!");
        else
            Console.WriteLine("Failed to purchase car");

        Main();
    }


    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("You are the customer of the dealership, you can buy & sell cars");
        Console.WriteLine("1. See your cars\n2. Sell a car\n3. Buy a car\n");

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


// this stuff is like gonna be converted to above dw

// mainMenuOption = Convert.ToInt32(Console.ReadLine());

// switch (mainMenuOption) {
//     case 1:
//         Console.Clear();

//         if (customer.carCount > 0) 
//             for (int i = 0; i < customer.carCount; i++) {
//                 Console.WriteLine(customer.ownedCars[i]);
//             }
//         else
//             Console.WriteLine("You do not own any cars, buy one...");

//         Console.WriteLine("Press any key to continue...");
//         Console.ReadKey();
//         goto start;
//     case 2:
//         break;
//     case 3:
//         Console.Clear();
//         dealer.ShowCars();
//         Console.WriteLine("Do you want to purchase a car? (y/n)");


//         isPurchasing = Convert.ToChar(Console.ReadLine());

//         if (isPurchasing == 'y')



//         goto start;
//     default:
//         Console.Clear();
//         Console.WriteLine("Thats not an option.");
//         goto start;
// }

// Console.WriteLine("Hello there. You are owner of a car shop with the objective of selling as many cars as possible");
// Thread.Sleep(500);
// Console.WriteLine("These are the cars you have in your dealership");
// Thread.Sleep(200);
// carDealer player = new carDealer(1000);
// player.ShowCars(5);


// Console.WriteLine("wanna see them again?");
// string answerTwo = Console.ReadLine();
// if (answerTwo == "yes")
// {
//     player.ShowCars(0);
// }



// Console.ReadLine();