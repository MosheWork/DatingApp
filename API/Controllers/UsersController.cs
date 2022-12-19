using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] ///GET /api/users


    // ControllerBase let u use action
    public class UsersController : ControllerBase
    {

        //_ user for private fields



        private readonly DataContext _context;

        //ctor short cut to make constructor
        //constructor is same as the class just to give him parameters when its created
        public UsersController(DataContext context)
        {
            _context = context;
        }

        //get all users
        [HttpGet]

        //ActionResult let u return also something like notFound
        //async also need to wrap in task <>
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        //get user by id
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);

        }

    }
}