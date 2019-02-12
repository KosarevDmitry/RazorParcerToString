* добавить Csiki.RazortoStringRender.dll
* добавить в **startup.cs**

public void ConfigureServices(IServiceCollection services){  
      services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();  
       services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();  
       services.AddSingleton<IRazorPageToStringRenderer, RazorPageToStringRenderer>();       
     }  
   
* расширение view  shtml/html  не  имеет значение.
* первая директива @Page обязательна
* вызывает ошибку парсинга страницы литералы начинающиеся с @ -   директивы css (например @charset)  
* создать/добавить конструктор контроллера  с  аргументом  - интерфейс библиотеки
* конструктор допускается только один
* пример вызова обработчика:  
async Task<string> Test() {  
    string body = await renderer.RenderToStringAsync("/Views/Email/Authorization.html", new AuthorizationModel());  
    return body;  
}
