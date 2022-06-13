using Microsoft.AspNetCore.Mvc;
using IMC.Domain;
using IMC.Application.Paints.Queries.GetPaintList;

namespace IMC.WebUI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaintController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<Paint>>> GetAll()
        {
            var query = new GetPaintListQuery();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
    }
}
