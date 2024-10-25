using Fast.Application.Features.Avatars.Commands.Create;
using Fast.Infrastructure;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(x =>
{
    x.RegisterServicesFromAssemblyContaining(typeof(Program));
});

builder.Services.AddInfrastructure();

var app = builder.Build();

app.MapGet("/avatar", (ISender sender) =>
{
    Console.WriteLine("get");
});

app.MapPost("/avatar", (ISender sender) =>
{
    sender.Send(new CreateAvatarCommand
    {
        Name = "name"
    });
});

app.Run();
