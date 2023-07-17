using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/users", () =>
{
    // TODO: Return list of users
    return Results.Ok(new[] { "User1", "User2" });
});

app.MapGet("/users/{id}", (int id) =>
{
    // TODO: Return user by ID
    return Results.Ok($"User {id}");
});

app.MapPost("/users", (User user) =>
{
    // TODO: Create user
    return Results.Created($"/users/{user.Id}", user);
});

app.Run();
public class User {
    public int Id { get; set; }
    public int FirstName { get; set; }
    public int LastName { get; set; }
}