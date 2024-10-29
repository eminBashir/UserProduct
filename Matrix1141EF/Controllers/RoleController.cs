using AutoMapper;
using Matrix1141EF.Data.Entity;
using Matrix1141EF.Model.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Matrix1141EF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {

        private readonly RoleManager<Role> _roleManager;
        private readonly IMapper _mapper;

        public RoleController(RoleManager<Role> roleManager, IMapper mapper)
        {
            _roleManager = roleManager;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleCreateDTO roleCreateDTO)
        {
            if (string.IsNullOrEmpty(roleCreateDTO.Name))
            {
                return BadRequest("Rol adi bos ola bilmez!");
            }
            var roleExist = await _roleManager.RoleExistsAsync(roleCreateDTO.Name);

            if (!roleExist)
            {
                var role = _mapper.Map<Role>(roleCreateDTO);
                var roleResult = await _roleManager.CreateAsync(role);

                if (roleResult.Succeeded)
                {
                    return Ok("Rol yaradildi");
                }


            }
            return BadRequest("Bu rol artiq movcuddur!");
        }
    }
}

