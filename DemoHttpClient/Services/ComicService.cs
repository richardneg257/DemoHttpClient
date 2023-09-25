using DemoHttpClient.Dtos;
using DemoHttpClient.Modelos;

namespace DemoHttpClient.Services;

public class ComicService : IComicService
{
	private readonly HttpClient _httpClientComic;

	public ComicService(IHttpClientFactory httpClientFactory)
    {
        _httpClientComic = httpClientFactory.CreateClient("comic");
	}

    public async Task<List<PersonajeDto>> ListarPersonajes()
	{
		throw new NotImplementedException();
	}

	public async Task<PersonajeDto> ObtenerPersonaje(int id)
	{
		var personaje = await _httpClientComic.GetFromJsonAsync<Personaje>($"character/{id}");

		var personajeDto = new PersonajeDto()
		{
			Id = personaje.Id,
			Nombre = personaje.Name,
			Estado = personaje.Status,
			Especie = personaje.Species
		};

		return personajeDto!;
	}
}
