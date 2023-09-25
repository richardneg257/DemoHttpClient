using DemoHttpClient.Dtos;

namespace DemoHttpClient.Services;

public interface IComicService
{
	Task<List<PersonajeDto>> ListarPersonajes();
	Task<PersonajeDto> ObtenerPersonaje(int id);
}
