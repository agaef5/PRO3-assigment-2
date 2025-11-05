using Grpc.Net.Client;
using SlaughterHouse.Api;

namespace SlaughterHouse.Gateways;

public class SlaughterHouseGateway : IAsyncDisposable 
{ 
    public GrpcChannel Channel { get; }
    public SlaughterHouseService.SlaughterHouseServiceClient Client { get; }
    
    public SlaughterHouseGateway(string address = "http://localhost:9090")
    {
        Channel = GrpcChannel.ForAddress(address);
        Client  = new SlaughterHouseService.SlaughterHouseServiceClient(Channel);
    }

    public ValueTask DisposeAsync()
    {
        Channel.Dispose();
        return ValueTask.CompletedTask;
    }
}