// See https://aka.ms/new-console-template for more information

using LadisEndpointModel;

EndPoint endpoint = new() { Id = 1, State = 1};


Console.WriteLine("Hello, World! {0} e {1}", endpoint.Id, endpoint.State);
