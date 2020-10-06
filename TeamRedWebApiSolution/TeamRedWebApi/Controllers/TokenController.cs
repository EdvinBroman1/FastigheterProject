using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TeamRedProject.Models;
using TeamRedProject.Services;
using TeamRedzFastigheter.Shared;

namespace TeamRedWebApi.Controllers
{
    [Route("token")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IRealEstateRepo _realEstateRepo;

        public TokenController(IRealEstateRepo realEstateRepo)
        {
            this._realEstateRepo = realEstateRepo;
        }

        [HttpPost]
        public IActionResult Authenticate([FromBody] UserCredentials userinformation)
        {
            var token = _realEstateRepo.AuthenticateUser(userinformation.Username, userinformation.Password);           
            if (token == null) return Unauthorized();

            return Ok(new
            {
                access_token = new JwtSecurityTokenHandler().WriteToken(token),
                token_type = token.Header.Typ,
                userName = userinformation.Username,
                expiration = token.ValidTo,
                issued = token.ValidFrom
            });
        }
    }
}
