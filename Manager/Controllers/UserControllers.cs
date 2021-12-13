using Manage.Core.Exceptions;
using Manager.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Manager.Controllers
{

[ApiController]
    public class UserControllers : ControllerBase
    {
        [HttpPost]
        [Route("/api/v1/user/create")]
        public async Task<IActionResult> Create([FromBody]CreateUserViewModel createUserViewModel)
        {
            try
            {
                return Ok();
            }

            catch (DomainException ex)
            { 
                return BadRequest(ex.Message);
            }
            catch(Exception)
            {
                return StatusCode(500);
            }
        }

    }
}
