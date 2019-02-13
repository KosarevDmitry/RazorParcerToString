тестовый проект API netCore  
smtp не прикручивал. Результат смотрел  в debug html preview
* добавить Csiki.RazortoStringRender.dll
* добавить в **startup.cs**

public void ConfigureServices(IServiceCollection services){  
      services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();  
       services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();  
       services.AddSingleton<IRazorPageToStringRenderer, RazorPageToStringRenderer>();       
 
 //для замены HEX кодировки (по умолчанию) в Unicode   
 //https://docs.microsoft.com/en-us/aspnet/core/security/cross-site-scripting?view=aspnetcore-2.2  
     services.AddSingleton<HtmlEncoder>(
   HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.BasicLatin,
                                               UnicodeRanges.Cyrillic
  }));
 
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

