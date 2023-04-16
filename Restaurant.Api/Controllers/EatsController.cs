using Microsoft.AspNetCore.Mvc;
using Restaurant.Service.DTOs.Eats;
using Restaurant.Service.Interfaces;

namespace Restaurant.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EatsController : ControllerBase
    {
        private readonly IEatService eatService;

        public EatsController(IEatService eatService)
        {
            this.eatService = eatService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEats()
        {
            var eats = await eatService.GetAllSericeAsync();
            return Ok(eats);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEat(long id)
        {
            var eat = await eatService.GetServiceAsync(id);
            if (eat == null)
            {
                return NotFound();
            }
            return Ok(eat);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEat(EatCreationDto eatDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var eat = await eatService.AddServiceAsync(eatDto);
            return CreatedAtAction(nameof(GetEat), new { id = eat.Id }, eat);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEat(long id, EatUpdateDto eatDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var eat = await eatService.UpdateServiceAsync(id, eatDto);
            if (eat == null)
            {
                return NotFound();
            }
            return Ok(eat);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEat(long id)
        {
            var success = await eatService.DeleteServiceAsync(id);
            if (!success)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
