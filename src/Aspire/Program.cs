var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.MyBusiness_Host>("api")
    .WithArgs("api");

builder.Build().Run();