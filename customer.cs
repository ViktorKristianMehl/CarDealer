public class Customer

{
    public decimal Condition = 0;
    public float Money = 200f;
    public float CarBrand = 0f;
    public float Color = 0f;

    public Customer(float startmoney)
    {
        Money = startmoney;
    }

    public void BuyMethod(float price, Car vc)
    {

        Money = price;
        Money = Money - price;

    }

}



