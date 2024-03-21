using ApplicationCommerciale.API.Errors;
using ApplicationCommerciale.Core.Dtos;
using ApplicationCommerciale.Core.Entities;
using ApplicationCommerciale.Core.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationCommerciale.API.Controllers
{

    [Route ("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly ITokenServices tokenServices;
        private readonly IMapper mapper;


        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenServices tokenServices, IMapper mapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.tokenServices = tokenServices;
            this.mapper = mapper;
        }

        [HttpPost("Login")]

        public async Task<IActionResult> Login(LoginDto loginDto)

        {

            var user = await userManager.FindByEmailAsync(loginDto.Email);
            if (user is null) return Unauthorized(new BaseCommonResponse(401));
              
            var result = await signInManager.CheckPasswordSignInAsync(user, loginDto.Password,false);
            if (result is null || result.Succeeded == false) return Unauthorized(new BaseCommonResponse(401));


            return Ok(new UserDto
            {

                DisplayName = user.DisplayName,
                Email = user.Email,
                Token = tokenServices.CreateToken(user)
            });
                                    
                                
                    
                

    }
}
    }