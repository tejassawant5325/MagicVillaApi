using Microsoft.AspNetCore.Mvc;
using VillaApi.Data;
using VillaApi.Models;
using VillaApi.Models.DTO.VillaDTOs;
using VillaApi.Models.DTO.VillaNumberDTO;

namespace VillaApi.Controllers
{
    [Route("api/VillaNumberApi")]
    [ApiController]
    public class VillaNumberApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VillaNumberApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get Villa Numbers
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaNumberDTO>> GetVillaNumbers()
        {
            var villaNumbers = _context.VillaNumbers.ToList();
            return Ok(villaNumbers);
        }

        [HttpPost]
        public ActionResult<VillaNumberDTO> CreateVillaNumbers([FromBody] VillaNumberCreateDTO villaNumberCreateDTO)
        {
            if (villaNumberCreateDTO == null)
            {
                return BadRequest();
            }
            var res = _context.VillaNumbers.FirstOrDefault(u => u.VillaNo == villaNumberCreateDTO.VillaNo);
            if (res != null)
            {
                ModelState.AddModelError("CustomError", "Villa Number Already Exist");
                return BadRequest(ModelState);
            }
            VillaNumber villaNumber = new()
            {
                CreatedDate = DateTime.Now,
                VillaNo = villaNumberCreateDTO.VillaNo,
                SpecialDetails = villaNumberCreateDTO.SpecialDetails,
            };
            _context.Add(villaNumber);
            _context.SaveChanges();
            return Ok(villaNumber);

        }

    }
}
