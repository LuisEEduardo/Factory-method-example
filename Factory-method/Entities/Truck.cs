namespace Factory_method.Entities;

public class Truck : ITransport
{
    public string Deliver()
    {
        return "Truck Delivered!";
    }
}