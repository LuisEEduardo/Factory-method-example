namespace Factory_method.Entities;

public class FabricTransportShip : FabricTransport
{
    protected override ITransport GetTransport()
    {
        return new Ship();
    }
}