
public class Car
{

    public string brand;
    public string color;

    public float Damage;
    public float Price;
    public float MaxSpeed;
    public bool Driving = false;

    public Car(string test, string placeholder, float damage, float price, float maxSpeed)
    {
        brand = test;
        color = placeholder;
        Damage = damage;
        Price = price;
        MaxSpeed = maxSpeed;


    }

    public void EnterCar()
    {
        Driving = true;
    }

    public void Data()
    {
        Console.WriteLine(
"Brand: " + brand +
"\nColor: "
+ color +
"\nDamage: "
+ Damage
+ "% \n"
+ "Price: "
+ Price
+ "$\n"
+ "Max Speed: "
+ MaxSpeed
+ " km/h \n"
+ "------------------");
    }
}