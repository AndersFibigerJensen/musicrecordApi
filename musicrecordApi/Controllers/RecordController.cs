using Microsoft.AspNetCore.Mvc;
using musicrecordApi.Models;
using musicrecordApi.Repo;

namespace musicrecordApi.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class RecordController : ControllerBase
    {
        private RecordRepository _recordrepository=new();

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<List<Record>> getRecords([FromHeader] string? title = null, [FromHeader] string? artist=null)
        {
            List<Record> records = _recordrepository.GetAllRecords(title,artist);
            if (records == null)
                return NoContent();
            return Ok(records);
        }
    }
}
