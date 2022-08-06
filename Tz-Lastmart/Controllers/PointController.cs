using Microsoft.AspNetCore.Mvc;
using Tz_Lastmart.Models;

namespace Tz_Lastmart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointController : ControllerBase
    {
        private ApplicationContext _db;
        private ILogger<PointController> _logger;

        public PointController(ApplicationContext db, ILogger<PointController> logger)
        {
            _db = db;
            _logger = logger;
        }

        [Route("View")]
        [HttpGet]
        public async Task<IActionResult> ViewPoint()
        {
            try
            {
                _logger.LogInformation("Запрос получен");
                return Ok(_db.Point);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [Route("Delete")]
        [HttpDelete]
        public async Task<IActionResult> DeletePoint(int id)
        {
            try
            {
                _logger.LogInformation("Запрос получен");
                var search = _db.Point.FirstOrDefault(p => p.Id == id);

                if (search != null)
                {
                    var point = _db.Point.Remove(search);
                    _logger.LogInformation("Запрос обработан");
                    _db.SaveChanges();
                    return Ok();
                }
                return BadRequest("Point не найден");
                
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
