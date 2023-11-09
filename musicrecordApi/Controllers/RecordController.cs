using Microsoft.AspNetCore.Mvc;
using musicrecordApi.Models;
using musicrecordApi.Repo;

namespace musicrecordApi.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class RecordController : ControllerBase
    {
        [HttpGet]
        public List<Record>
    }
}
