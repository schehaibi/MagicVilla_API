using AutoMapper;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTO;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")] //route or name used to call an controller
    [ApiController] // define this class as an controller
    public class VillaAPIController : ControllerBase //controllerBase used when we are using our contoller only as an api but when we use MVC we change it to Controller
    {
        protected APIResponse _response
        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;

        public VillaAPIController(IVillaRepository dbVilla, IMapper mapper)
        {
            _dbVilla = dbVilla;
            _mapper = mapper;
            this._response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)] //those are the possible response type
        public async Task<ActionResult<IEnumerable<VillaDTO>>> GetVillas()
        {
            IEnumerable<Villa> villaList = await _dbVilla.GetAllAsync();
            return Ok(_mapper.Map<List<VillaDTO>>(villaList));
        }

        [HttpGet("{id:int}", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]  // we can change the StatusCodes.Status404NotFound by [ProducesResponseType(404)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<VillaDTO>> GetVilla(int id)
        // ActionResult to define the response type or code example 400 is by BadRequest
        {
            if (id == 0) {  
                return BadRequest();
            }
           // return the first variable that had the same id match with the id of parameter
            var villa = await _dbVilla.GetAsync(u => u.Id == id);
            if (villa == null) return NotFound();
            return Ok(_mapper.Map<VillaDTO>(villa));
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<VillaDTO>> CreateVilla([FromBody] VillaCreateDTO createDTO)
        {
            //if we will not use [ApiController] annotation and we want to create custom validation we can use ModelState
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //check if the name already exist and send a custom error
            if (await _dbVilla.GetAsync(u => u.Name.ToLower() == createDTO.Name.ToLower()) != null) 
            {
                ModelState.AddModelError("CustomError", "Villa Already Exists!");
                return BadRequest(ModelState);
            }
            if (createDTO == null) return BadRequest();
            Villa model = _mapper.Map<Villa>(createDTO);

            await _dbVilla.CreateAsync(model);
            return CreatedAtRoute("GetVilla", new { id = model.Id }, model);
        }

        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        public async Task<IActionResult> DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa =await _dbVilla.GetAsync(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }

            await _dbVilla.RemoveAsync(villa);
            return NoContent();
        }


        [HttpPut("{id:int}", Name = "UpdateVilla")]
        public async Task<IActionResult> UpdateVilla(int id, [FromBody] VillaUpdateDTO updateDTO)
        {
            if (updateDTO == null || id != updateDTO.Id)
            {
                return BadRequest();
            }
            Villa model = _mapper.Map<Villa>(updateDTO);

            await _dbVilla.UpdateAsync(model);
            return NoContent();
        }



        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
        {
            if (patchDTO == null || id == 0)
            {
                return BadRequest();
            }
            var villa =await _dbVilla.GetAsync(u => u.Id == id,tracked:false);

            VillaUpdateDTO villaDTO = _mapper.Map<VillaUpdateDTO>(villa); 

            if (villa == null) return BadRequest();

            patchDTO.ApplyTo(villaDTO, ModelState);
            Villa model = _mapper.Map<Villa>(villaDTO);
            await _dbVilla.UpdateAsync(model);
           
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }
    }
}
