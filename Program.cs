var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/{name}", (string name) => $"Hello {name}");


app.MapPost("/", (User us) =>
{
    return Results.Ok(user);
});

app.Run();

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}