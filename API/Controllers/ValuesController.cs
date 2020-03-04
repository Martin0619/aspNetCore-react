using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contract;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public ValuesController(IRepositoryManager repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Value>>> GetTask()
        {
            var valueEntities = await _repository.Value.GetAll();
            return Ok(valueEntities);
        }
    }
}