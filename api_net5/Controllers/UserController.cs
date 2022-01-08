using api_net5.Core.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_net5.Controllers
{
    [Route("/api/v1")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("/users/create")]
        public async Task<IActionResult> Create()
        {
            try
            {

            }
            catch (DomainException ex)
            {
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro");
            }
        }
    }
}
