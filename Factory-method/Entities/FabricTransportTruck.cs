namespace Factory_method.Entities;

public class FabricTransportTruck : FabricTransport
{
    protected override ITransport GetTransport()
    {
        return new Truck();
    }
}