using ApplicationCommerciale.Core.Interfaces;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ApplicationCommerciale.Core.Entities;
using System.Security.Claims;


namespace ApplicationCommerciale.Core.Services
{
    public  class TokenServices : ITokenServices
    {
        private readonly IConfiguration configuration;

        private readonly SymmetricSecurityKey securityKey;


        public TokenServices(IConfiguration config)
        {
             configuration = config;
            securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Token:Key"]));
        }

        public string CreateToken(AppUser appUser)
        {
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Email,appUser.Email),
                new Claim(JwtRegisteredClaimNames.GivenName, appUser.DisplayName)
            };
            var creds = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(10),
                Issuer = configuration["Token:Issuer"],
                SigningCredentials = creds

            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }

}

