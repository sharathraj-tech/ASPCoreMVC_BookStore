var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.Use(async (context, next) => {
//    await context.Response.WriteAsync("Hi Hello First");
//    await next(context);
//});

//app.Use(async (context,next) => {
//    await context.Response.WriteAsync("Hi Hello Second");
//    await next(context);
//});


app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.Map("/sharath", async context =>
    {
        await context.Response.WriteAsync("Hello Sharath");
    });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.MapGet("/", () => "Hello World!");


app.Run();
