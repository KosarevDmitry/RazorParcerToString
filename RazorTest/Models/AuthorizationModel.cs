using Microsoft.AspNetCore.Mvc.RazorPages;
namespace RazorTest.Models
{
    public class AuthorizationModel : IMailModel
    {
        public string username { get; set; }
        public string passw { get; set; }
        public string addesLink { get; set; }
        
        public AuthorizationModel(string u = "Петров", string p= "12345678789", string a = "http://www.rushydro.ru")
       
        {
            username = u;
            passw = p;
            addesLink = a;

    }
    }


    interface IMailModel
    {
        string username { get; set; }
        string passw { get; set; }
        string addesLink { get; set; }
    }


    


}