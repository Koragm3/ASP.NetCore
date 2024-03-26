var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();





var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();

app.Run();
