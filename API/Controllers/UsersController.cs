using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using API.DTOs;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        //private readonly DataContext _context;
        private readonly IUserRepository _userReposiroty;
        private readonly IMapper _mapper;
        public UsersController(IUserRepository userReposiroty, IMapper mapper)
        {
            _mapper = mapper;
            _userReposiroty = userReposiroty;
            //_context = context;
        }

        // api/users
        [HttpGet]
        //[AllowAnonymous]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            //return await _context.Users.ToListAsync();
            var users = await _userReposiroty.GetMembersAsync();

            return Ok(users);
        }

        // api/users/3
        //[Authorize]
        // [HttpGet("{id}")]
        // public async Task<ActionResult<AppUser>> GetUser(int id)
        // {
        //     return await _context.Users.FindAsync(id);
        // }

        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        {
            return await _userReposiroty.GetMemberAsync(username);           
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUser(MemberUpdateDto memberUpdateDto)
        {
            var username = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = await _userReposiroty.GetUserByUsernameAsync(username);
            _mapper.Map(memberUpdateDto, user);

            _userReposiroty.Update(user);

            if (await _userReposiroty.SaveAllAsync()) return NoContent();

            return BadRequest("Failed to update user");
        }
    }
}