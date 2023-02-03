using MagicVillaApi.Datos;
using MagicVillaApi.Dto;
using MagicVillaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVillaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDto>> GetVilla()
        {
            return Ok(VillaSrore.ListTheVilla);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<VillaDto> GetByIdVilla(int id)
        {
            //IMplementando validaciones 
            if (id == 0) 
            {
                return BadRequest();
            }
            var result = VillaSrore.ListTheVilla.FirstOrDefault(v => v.Id == id);
            if (result == null) 
            { 
                return NotFound();
            }
            return Ok(result );

            //Sin validaciones que da una sola linea de codigo
            //return Ok(VillaSrore.ListTheVilla.FirstOrDefault(v => v.Id == id));
        }
    }
}
