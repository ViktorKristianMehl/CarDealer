
public class Car
{

    public string brand;
    public string color;

    public bool Driving = false;

    public Car(string test, string placeholder, float price, float damage, float maxSpeed)
    {
        brand = test;
        color = placeholder;

    }

    public void EnterCar()
    {
        Driving = true;
    }
}