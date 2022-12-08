public class carDealer
{

    float money = 0f;

    public carDealer(float money)
    {
        money = 0f;
    }

    public void showCars()
    {

        Random RNG = new Random();
        List<Car> randomCars = new List<Car>();
        int i = 0;
        while (i < 10)
        {

            int brandNum = RNG.Next(0, 9);
            int colorNum = RNG.Next(0, 9);




            randomCars.Add(new Car(StaticCars.CarBrands[brandNum], StaticCars.CarColors[colorNum]));


            Console.WriteLine(StaticCars.CarBrands[brandNum] + " " + StaticCars.CarColors[colorNum]);

            i++;

        }

    }
    public void AdvancedStats()
    {

    }

}