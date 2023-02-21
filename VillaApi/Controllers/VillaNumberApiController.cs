using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        // Post VillaNumbers
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
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

        // Get Single VillaNumer
        [HttpGet("{villaNo}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaNumberDTO> GetOneVillaNumber(int villaNo)
        {
            if (villaNo == 0)
            {
                return BadRequest();
            }
            var villa = _context.VillaNumbers.FirstOrDefault(u => u.VillaNo == villaNo);
            if (villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
        }

        // Delete VillaNumber
        [HttpDelete("{villaNo}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult DeleteVillaNumber(int villaNo)
        {
            if (villaNo == 0)
            {
                return BadRequest();
            }
            var villaNumber = _context.VillaNumbers.FirstOrDefault(u => u.VillaNo == villaNo);
            if (villaNumber == null)
            {
                return NotFound();
            }
            _context.VillaNumbers.Remove(villaNumber);
            _context.SaveChanges();
            return NoContent();
        }

        // Update VillaNumber Using PUT
        [HttpPut("{villaNo}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdateVillaNumber(int villaNo, [FromBody] VillaNumberUpdateDTO villaNumberUpdateDTO)
        {
            if (villaNumberUpdateDTO == null || villaNumberUpdateDTO.VillaNo != villaNo)
            {
                return BadRequest();
            }
            var villa = _context.VillaNumbers.AsNoTracking().FirstOrDefault(u => u.VillaNo == villaNo);
            if (villa == null)
            {
                return NotFound();
            }

            VillaNumber villaNumber = new()
            {
                VillaNo = villaNumberUpdateDTO.VillaNo,
                SpecialDetails = villaNumberUpdateDTO.SpecialDetails,
                UpdatedDate = DateTime.Now
            };
            _context.VillaNumbers.Update(villaNumber);
            _context.SaveChanges();
            return NoContent();
        }


    }
}
