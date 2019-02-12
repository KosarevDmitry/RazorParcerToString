using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorTest.Models;
using Csiki.RazortoStringRender;

namespace RazorTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IRazorPageToStringRenderer renderer;

        // GET api/values
       public ValuesController(IRazorPageToStringRenderer renderer) //автоматически разрешение получает
        {
            this.renderer = renderer;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
          Task<string> body = Test();
          string b = body.Result;
          return body.Result;
        }
        
        async Task<string> Test()
        {
            string body = await renderer.RenderToStringAsync("/Views/Email/Authorization.html", new AuthorizationModel());
            return body;
        }

    }
}
