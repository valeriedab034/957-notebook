using WebsiteBaNhat.Components;
using WebsiteBaNhat.Services;

var builder = WebApplication.CreateBuilder(args);

// Đăng ký Razor Components và Interactive Server.
builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

// Đăng ký lớp cung cấp dữ liệu truyền thống.
builder.Services.AddSingleton<TraditionService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler(
        "/Error",
        createScopeForErrors: true);

    app.UseHsts();
}

app.UseHttpsRedirection();

// Cho phép website đọc CSS và các tệp trong wwwroot.
app.UseStaticFiles();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();