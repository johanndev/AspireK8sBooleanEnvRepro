using Scalar.Aspire;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddKubernetesEnvironment("k8s");

var api = builder.AddProject<Projects.Repro_ApiService>("api");

var scalar = builder.AddScalarApiReference();
scalar.WithApiReference(api, options =>
{
    options
        .AddDocument("openapi", "OpenAPI")
        .WithOpenApiRoutePattern("/{documentName}.json");
});

builder.Build().Run();
