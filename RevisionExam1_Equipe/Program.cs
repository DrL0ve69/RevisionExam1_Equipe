var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

// Route pour l'action Catalogue() du controlleur LivreController
app.MapControllerRoute(
    name: "default",
    defaults: new { controller = "Livre", action = "Catalogue",},
    pattern: "{controller=Livre}")
    .WithStaticAssets();

// Route pour l'action TrouverLivre(id) du controlleur LivreController
app.MapControllerRoute(
    name: "default",
    defaults: new { controller = "Livre", action = "TrouverLivre", },
    pattern: "{controller=Livre}/{id}")
    .WithStaticAssets();

// route pour le panier avec les ids des livres et celui du client
app.MapControllerRoute(
    name: "default",
    defaults: new { controller = "Panier", action = "Panier"},
    pattern: "{controller}/{action}/{idClient}/{idLivre1?}/{idLivre2?}/{idLivre3?}")
    .WithStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}")
    .WithStaticAssets();

app.Run();
