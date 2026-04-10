// 1. Создание билдера
var builder=WebApplication.CreateBuilder(args);
// 2. Сборка приложения
var app = builder.Build();
//3.Регистрация маршрута 
app.MapGet("/", () => "Добро пожаловать на сервер!");
app.MapGet("/about", () => "Это мой первый ASP.NET Core сервер");
app.MapGet("/time", () => $"Время на сервере: {DateTime.Now}");
app.MapGet("/hello/{name}", (string name) => $"Привет, {name}!");
app.MapGet("/sum/{a}/{b}", (int a, int b) =>
{
    return Results.Ok(new { sum = a + b });
});
//4.Запуск
app.Run();