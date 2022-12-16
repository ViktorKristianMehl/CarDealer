public class carDealer
{
    public float money = 0f;

    public List<Car> Cars;


    public carDealer(float money)
    {

        money = 0f;

        Cars = new List<Car>();
        Cars.Add()


    }

    public void ShowCars(int i)
    {
        Random RNG = new Random();
        int x = randomCars.Count;
        for (i = i + x; x < i; x = randomCars.Count)
        {

            int brandNum = RNG.Next(0, 9);
            int colorNum = RNG.Next(0, 9);
            float damage = RNG.Next(0, 100);
            float price = RNG.Next(1000, 20000);
            float maxspeed = RNG.Next(80, 300);


            randomCars.Add(new Car(StaticCars.CarBrands[brandNum], StaticCars.CarColors[colorNum], damage, price, maxspeed));



        }

        for (x = 0; x < randomCars.Count; x++)
        {
            Console.WriteLine("Nr. " + (x + 1));
            randomCars[x].Data();
        }

    }

};



