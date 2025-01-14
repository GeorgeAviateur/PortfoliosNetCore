using ResumeCleanArchitecture.Application;
using ResumeCleanArchitecture.Infrastructure;
using ResumeCleanArchitecture.Infrastructure.Persistence;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();
//write extension methods to add something to server collections in other layers
builder.Services.AddApplication();
var connectionString = builder.Configuration.GetConnectionString("SupabaseConnection");
builder.Services.AddInfrastructure(connectionString);

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ResumeDbContext>();
    try
    {
        // Attempt to open the database connection
        dbContext.Database.CanConnect();
        Console.WriteLine("Database connection successful.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Database connection failed: {ex.Message}");
    }
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();

app.Run();