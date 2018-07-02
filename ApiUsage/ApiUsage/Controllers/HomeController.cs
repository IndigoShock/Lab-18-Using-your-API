using Microsoft.AspNetCore.Mvc;

namespace ApiUsage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        /*[HttpGet]
        using (var client = new HttpClient())

	{
		// add the appropriate properties on top of the client base address.
		client.BaseAddress = new Uri("https://todoapi.database.windows.net");

    //the .Result is important for us to extract the result of the response from the call
    var response = client.GetAsync("/api/route/id").Result;

		if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
		{
			var stringResult = await response.Content.ReadAsStringAsync();
        }
    } */
}
}
