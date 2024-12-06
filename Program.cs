var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseHttpsRedirection();

// wwwroot = staticfiles
app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages();


app.Run();
