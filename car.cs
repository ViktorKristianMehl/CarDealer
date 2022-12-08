
public class Car
{

    public string brand;
    public string color;
    public float price = 0f;
    public float damage = 0;
    public float currentSpeed = 0f;
    public float maxSpeed = 0f;
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