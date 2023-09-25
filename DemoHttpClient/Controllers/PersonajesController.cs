using DemoHttpClient.Dtos;
using DemoHttpClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoHttpClient.Controllers;
[ApiController]
[Route("[controller]")]
public class PersonajesController : ControllerBase
{
	private readonly IComicService _comicService;

	public PersonajesController(IComicService comicService)
	{
		_comicService = comicService;
	}

	[HttpGet]
	public async Task<ActionResult<List<PersonajeDto>>> ListarPersonajes()
	{
		return Ok();
	}

	[HttpGet("{id:int}")]
	public async Task<ActionResult<PersonajeDto>> ObtenerPersonaje([FromRoute] int id)
	{
		var personaje = await _comicService.ObtenerPersonaje(id);
		return personaje;
	}
}
