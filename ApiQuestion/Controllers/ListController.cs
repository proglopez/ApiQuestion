using ApiQuestion.Domain.Interfaces;
using ApiQuestion.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiQuestion.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {

        private readonly IListDomain listDomain;
        private readonly IConfiguration configuration;

        public ListController(IListDomain _listDomain,
                                 IConfiguration configuration)
        {
            this.listDomain = _listDomain;
            this.configuration = configuration;
        }

        /// <summary>
        /// Get listado
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetListElements()
        {
                IEnumerable<ListaModel> listElement = 
                    await listDomain.GetListElements();
                return Ok(listElement.ToList());
        }
    }
}
