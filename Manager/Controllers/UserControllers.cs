using Manage.Core.Exceptions;
using Manager.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Manager.services.Interfaces;
using AutoMapper;
using Manager.services.DTO;
using Manager.Utilitis;

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
        public async Task<IActionResult> Create([FromBody]CreateUserViewModel createUserViewModel)
        {
            try
            {
                var userDTO = _mapper.Map<UserDTO>(createUserViewModel);
                var userCreate = await _userService.Create(userDTO);
                return Ok(
                   new ResultViewModel
                   {
                       Message = "Usuário criado com sucesso",
                       Success = true,
                       Data = userCreate
                   });
            }

            catch (DomainException ex)
            {
                return BadRequest(Responses.DomainErrorMessage(ex.Message));
            }
            catch(Exception)
            {
                return StatusCode(500, Responses.ApplicationErrorMessage());
            }
        }

    }
}
