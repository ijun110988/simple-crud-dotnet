var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Tambahkan routing untuk controller
app.UseEndpoints(endpoints =>
{
    // Default route ke Product/Index
    endpoints.MapControllerRoute(
        name: "product",
        pattern: "{controller=Product}/{action=Index}/{id?}");

    // Route untuk Home/Index jika tidak ada yang cocok dengan Product
    endpoints.MapControllerRoute(
        name: "home",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    // Dukung routing berbasis atribut jika ada
    endpoints.MapControllers();
});

app.Run();
