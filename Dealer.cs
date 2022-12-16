public class carDealer
{
    public List<Car> randomCars = new List<Car>();
    public float money = 0f;


    public carDealer(float money)
    {

        money = 0f;


    }

    public void ShowCars()
    {
        Random RNG = new Random();
        int i = 0;
        int e = 1;
        while (i < 10)
        {

            int brandNum = RNG.Next(0, 9);
            int colorNum = RNG.Next(0, 9);
            float damage = RNG.Next(0, 100);
            float price = RNG.Next(1000, 20000);
            float maxspeed = RNG.Next(80, 300);


            randomCars.Add(new Car(StaticCars.CarBrands[brandNum], StaticCars.CarColors[colorNum], damage, price, maxspeed));


            Console.WriteLine(
            "Nr. " + e +
            "\nBrand: " + StaticCars.CarBrands[brandNum] +
            "\nColor: "
            + StaticCars.CarColors[colorNum] +
            "\nDamage: "
            + damage
            + "% \n"
            + "Price: "
            + price
            + "$\n"
            + "Max Speed: "
            + maxspeed
            + " km/h \n"
            + "------------------");

            i++;
            e++;

        }

    }

};


