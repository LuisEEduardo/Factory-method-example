namespace Factory_method.Entities;

public class Ship : ITransport
{
    public string Deliver()
    {
        return "Ship Delivered!";
    }
}