using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAddData3.Data;
using TestAddData3.Models;

namespace TestAddData3.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthenticationController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Customer customer)
        {
            var existCustomer = _context.Customer.SingleOrDefault(c => c.Email == customer.Email);
            if (existCustomer != null && existCustomer.Password == customer.Password)
            {
                Request.HttpContext.Session.SetString("loggedUser", existCustomer.Email);
                return Redirect("/Home/About");
            }

            return View(customer);
        }

    }
}