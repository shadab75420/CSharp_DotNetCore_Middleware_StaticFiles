var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// HTTPS redirection
app.UseHttpsRedirection();

// Security headers (CSP)
app.Use(async (context, next) =>
{
    context.Response.Headers.Append("Content-Security-Policy",
        "default-src 'self'; script-src 'self'; style-src 'self'");
    
    await next();
});

// Logging middleware
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
    await next();
    Console.WriteLine($"Response Status: {context.Response.StatusCode}");
});

// Error handling
app.UseExceptionHandler("/error");

app.Map("/error", (HttpContext context) =>
{
    return Results.Content("Something went wrong!", "text/html");
});

// Static files
app.UseStaticFiles();

app.Run();