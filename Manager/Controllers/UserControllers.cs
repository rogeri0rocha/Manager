using Manage.Core.Exceptions;
using Manager.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Manager.services.Interfaces;
using AutoMapper;
using Manager.services.DTO;

namespace Manager.Controllers
{

    [ApiController]
    public class UserControllers : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserControllers(IMapper mapper, IUserService userservice) {
            _mapper = mapper;
            _userService = userservice;
        }

      
    
        [HttpPost]
        [Route("/api/v1/user/create")]
        public async Task<IActionResult> create([FromBody]CreateUserViewModel createUserViewModel)
        {
            try
            {
                var userDTO = _mapper.Map<UserDTO>(createUserViewModel);
                var userCreate = await _userService.Create(userDTO);
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
