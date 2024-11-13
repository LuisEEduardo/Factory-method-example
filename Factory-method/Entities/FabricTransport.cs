namespace Factory_method.Entities;

public abstract class FabricTransport
{
    protected abstract ITransport GetTransport();

    public string GetStatusDelivery()
    {
        var transport = GetTransport();
        return $"Status: {transport.Deliver()} ";
    }
}