using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcServer;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //var input = new HelloRequest { Name = "DevMo" };
            //var channel = GrpcChannel.ForAddress("https://localhost:5001");
            //var client = new Greeter.GreeterClient(channel);

            //var reply = await client.SayHelloAsync(input);

            //Console.WriteLine(reply.Message);

            //https://www.youtube.com/watch?v=QyxCX2GYHxk
            // 40 min mark
            Console.ReadLine();
        }
    }
}
