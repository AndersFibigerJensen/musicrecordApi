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
        public List<Record> getRecords()
        {
            return _recordrepository.GetAllRecords();
        }
    }
}
