
class Car
{

    public string brand;
    public string color;
    public float price = 0f;
    public decimal damage = 0;
    public float currentSpeed = 0f;
    public float maxSpeed = 0f;
    public bool Driving = false;

    public Car(string test, string placeholder)
    {
        Random carRNG = new Random();
        decimal damage = carRNG.Next(0, 100);
        float price = carRNG.Next(1000, 20000);
        float maxspeed = carRNG.Next(80, 300);
        brand = test;
        color = placeholder;

    }

    public void EnterCar()
    {
        Driving = true;
    }
}