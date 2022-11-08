var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddRazorPages();

var app = builder.Build();
var db = new DbContext();

app.MapGet("/users/{userId}/books/{bookId?}", IResult (string userId, int? bookId) =>
{
    return bookId != null
        ? Results.Ok(db.Books.Find(bookId.Value))
        : Results.Ok(db.Books);
});

app.MapGet("/", () => "Hello world");
app.MapGet("/posts/{**slug}", (string slug) => $"Viewing post {slug}");
app.MapGet("/todos/{id}", (int id) => db.Todos.Find(id));
app.MapGet("/posts/{slug:regex(^[a-z0-9_-]+$)}", (string slug) => $"Post {slug}");

app.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
