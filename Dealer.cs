class carDealer
{

    int money = 0;

    public carDealer(int money)
    {
        money = 0;
    }

    public void showCars()
    {

        Random brandRNG = new Random();
        Random colorRNG = new Random();
        List<Car> randomCars = new List<Car>();
        int i = 0;
        while (i < 10)
        {

            int brandNum = brandRNG.Next(0, 9);
            int colorNum = colorRNG.Next(0, 9);




            randomCars.Add(new Car(StaticCars.CarBrands[brandNum], StaticCars.CarColors[colorNum]));


            Console.WriteLine(StaticCars.CarBrands[brandNum] + " " + StaticCars.CarColors[colorNum]);

            i++;

        }

    }

}