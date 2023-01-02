public class CarDealer
{
    public float money = 0f;

    public List<Car> randomCars = new List<Car>();


    public CarDealer(float money, int carAmount)
    {
        money = 0f;

        Random RNG = new Random();
        
        for (int i = 0; i <= carAmount; i++)
        {
            int brandNum = RNG.Next(0, 9);
            int colorNum = RNG.Next(0, 9);
            float damage = RNG.Next(0, 100);
            float price = RNG.Next(1000, 20000);
            float maxspeed = RNG.Next(80, 300);

            randomCars.Add(new Car(StaticCars.CarBrands[brandNum], StaticCars.CarColors[colorNum], damage, price, maxspeed));
        }   

    }


    public void ShowCars()
    {
        for (int i = 1; i < randomCars.Count; i++)
        {
            Console.WriteLine("Nr. " + i);
            randomCars[i].Data();
        }

    }

    public bool carExists(int carNumber) {
        if (carNumber > randomCars.Count || carNumber < 0)
            return false;
        
        return true;
    }

    public Car getCar(int carNumber) {
        return randomCars[carNumber];
    }

};



