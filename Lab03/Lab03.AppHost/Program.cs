var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Lab03_ApiService>("apiservice");

builder.AddProject<Projects.Lab03_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
