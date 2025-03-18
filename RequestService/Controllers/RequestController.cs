using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestService.Policies;

namespace RequestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        public RequestController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<ActionResult> MakeRequest()
        {
            //var client = new HttpClient();
            var client = _clientFactory.CreateClient("Test");
            var response = await client.GetAsync("https://localhost:5001/api/response/25");
            
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("--> ResponseService returned a Success");
                return Ok();
            }
            else
            {
                Console.WriteLine("--> ResponseService returned a FAILURE");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}