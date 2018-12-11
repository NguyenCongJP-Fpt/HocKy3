using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TestAddData3.Controllers
{
    [Authorize(Roles = "Admin, Customer")]
    public class IdentityRoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public IdentityRoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var result = _roleManager.CreateAsync(new IdentityRole("Admin")).Result;
            if (result.Succeeded)
            {
                
            }

            return Json(_roleManager.Roles.ToList());
        }

    }
}