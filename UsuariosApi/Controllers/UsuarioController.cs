using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult CadastraUsuario
            (CreateUsuarioDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
