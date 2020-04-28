using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialApp.API.Data;
using SocialApp.API.Dtos;
using SocialApp.API.Models;

namespace SocialApp.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo  )
       {
           _repo = repo;
       } 


       [HttpPost("Register")]
       public async Task<IActionResult> Register(UserForRegisterDto userForRegsiterDto)
       {
           // Validate the equest 

           // Modify the user prior committing it.
           userForRegsiterDto.Username = userForRegsiterDto.Username.ToLower();

           if (await _repo.UserExists(userForRegsiterDto.Username))
            return BadRequest("Username already exist");

        var userToCreate = new User
        {
            Username = userForRegsiterDto.Username
        } ;

        var createdUser = await _repo.Register(userToCreate,userForRegsiterDto.Password);
        return  StatusCode(201);// CreatedAtRoute()

       }
    }
}