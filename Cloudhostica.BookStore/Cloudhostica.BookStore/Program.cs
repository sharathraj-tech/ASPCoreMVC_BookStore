using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
#if DEBUG
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
#endif

var app = builder.Build();

//app.Use(async (context, next) => {
//    await context.Response.WriteAsync("Hi Hello First");
//    await next(context);
//});

//app.Use(async (context,next) => {
//    await context.Response.WriteAsync("Hi Hello Second");
//    await next(context);
//});

app.UseStaticFiles();
//app.UseStaticFiles(new StaticFileOptions()
//{
//    FileProvider=new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"MyStaticFiles")),
//    RequestPath="/MyStaticFiles"
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

//app.MapGet("/", () => "Hello World!");


app.Run();
