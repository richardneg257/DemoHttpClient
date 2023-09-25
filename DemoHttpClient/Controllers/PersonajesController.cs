using Microsoft.AspNetCore.Mvc;

namespace DemoHttpClient.Controllers;
[ApiController]
[Route("[controller]")]
public class PersonajesController : ControllerBase
{
	public PersonajesController()
	{

	}

	[HttpGet]
	public async Task<ActionResult> ListarPersonajes()
	{
		return Ok();
	}
}
