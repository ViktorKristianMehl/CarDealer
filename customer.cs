public class Customer

{
    public decimal Condition = 0;
    public float Money = 200f;
    public float CarBrand = 0f;
    public float Color = 0f;
    public int carCount = 0;
    public Dictionary<int, Car> ownedCars = new Dictionary<int, Car>();

    public Customer(float startmoney)
    {
        Money = startmoney;
    }

    //vores buy method
    public bool purchaseCar(int carNumber, Car car)
    {
        if (!ownedCars.TryAdd(carNumber, car))
            return false;

        Money = Money - car.Price;
        carCount++;

        return true;
    }

    // vores sell method
    public bool SellCar(int carNumber, Car car)
    {

        if (!ownedCars.Remove(carNumber))
            return false;

        Money = Money + ownedCars[carNumber].Price;
        carCount--;

        return true;
    }

}




