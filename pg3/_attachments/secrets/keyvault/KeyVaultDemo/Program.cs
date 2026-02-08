using Azure.Identity;
using KeyVaultDemo;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
/*
builder.Configuration.AddAzureKeyVault(
    new Uri("https://shipit-keyvault.vault.azure.net/"),
    new DefaultAzureCredential());

builder.Services.Configure<DemoOptions>(
        builder.Configuration.GetSection(
            nameof(DemoOptions) 
        )
    );
*/
var app = builder.Build();

app.MapGet("/", (IConfiguration c) =>
$"LeSecretKey: '{c["LeSecretKey"]}'");

app.Run();
