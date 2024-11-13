using Factory_method.Entities;

Console.WriteLine("Ship");

var fabricyTransport1 = new FabricTransportShip();

Console.WriteLine(fabricyTransport1.GetStatusDelivery());

Console.WriteLine("------------------------------");

Console.WriteLine("Truck");

var fabricyTransport2 = new FabricTransportTruck();

Console.WriteLine(fabricyTransport2.GetStatusDelivery());

