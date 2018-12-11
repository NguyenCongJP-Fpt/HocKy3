using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using HiMiddleware.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HiMiddleware.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly HiMiddlewareContext _context;

        public AuthenticationController(HiMiddlewareContext context)
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
            if (existCustomer != null)
            {                
                customer.Salt = existCustomer.Salt;
                customer.EncryptPassword();
                if (customer.Password == existCustomer.Password)
                {
                    Request.HttpContext.Session.SetString("loggedUser", existCustomer.Email);
                    return Redirect("/Home/About");
                }
            }
            // nếu người dùng đăng nhập thành công thì tạo session mới cho người dùng. 
            // Chính là thông tin tài khoản vừa đăng nhập.
            return View(customer);
        }

        [HttpPost]
        public IActionResult LoginAPI(Customer customer)
        {
            var existCustomer = _context.Customer.SingleOrDefault(c => c.Email == customer.Email);
            if (existCustomer != null)
            {
                customer.Salt = existCustomer.Salt;
                customer.EncryptPassword();
                if (customer.Password == existCustomer.Password)
                {
                    Credential credential = new Credential(existCustomer.Id);                    
                    return Json(credential);
                }
            }
            // nếu người dùng đăng nhập thành công thì tạo session mới cho người dùng. 
            // Chính là thông tin tài khoản vừa đăng nhập.
            Response.StatusCode = (int) HttpStatusCode.Forbidden;
            return Json(customer);
        }
    }
}