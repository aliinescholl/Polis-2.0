using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs.MetaDto;
using Model.Services.Interfaces;

namespace TheHouse.Controllers
{
    [Route("api/autor")]
    [ApiController]
    public class AutorController : Controller
    {
        private readonly IMetaService _service;
        private readonly IMapper _mapper;

        public AutorController(IMetaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<AutorDto>>> GetMetas() 
        {
            try
            {
                List<Model.Entities.Autor> metas = await _service.GetAllMeta();

                if (metas == null)
                {
                    ActionResult actionNull = Ok("Nenhuma meta encontrada!");
                    return actionNull;
                }

                ActionResult action = Ok(_mapper.Map<List<AutorDto>>(metas));

                return action;
            } 
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Model.Entities.Autor>> GetMetaById(int id)
        {
            try
            {
                var meta = await _service.GetMetaById(id);

                if (meta == null)
                {
                    return NotFound();
                }
                return Ok(_mapper.Map<AutorDto>(meta));

            } catch(Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
        }

        [HttpPost]
        public async Task<ActionResult<AutorDto>> AddMeta(CreateAutorDto createMetaDto)
        {
            try
            {
                var meta = _mapper.Map<Model.Entities.Autor>(createMetaDto);

                await _service.AddMeta(meta);

                await _service.SaveChangesAsync();

                var response = _mapper.Map<AutorDto>(meta);

                return CreatedAtAction(nameof(GetMetaById), new { id = response.Id }, response);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Erro interno do servidor! \n" + "Erro: " + e);
            }
        }
    }
}
