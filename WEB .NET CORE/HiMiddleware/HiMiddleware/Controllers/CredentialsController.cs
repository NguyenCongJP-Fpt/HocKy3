using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HiMiddleware.Models;

namespace HiMiddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CredentialsController : ControllerBase
    {
        private readonly HiMiddlewareContext _context;

        public CredentialsController(HiMiddlewareContext context)
        {
            _context = context;
        }

        [HttpGet("demo")]
        public IActionResult Demo()
        {
            return new JsonResult("Hello");
        }

        // POST: api/Credentials       
        [HttpPost("/authentication")]
        public IActionResult Authentication([FromBody] Customer customer)
        {
            var existCustomer = _context.Customer.SingleOrDefault(c => c.Email == customer.Email);
            if (existCustomer != null)
            {
                customer.Salt = existCustomer.Salt;
                customer.EncryptPassword();
                if (customer.Password == existCustomer.Password)
                {
                    Credential credential = new Credential(existCustomer.Id);
                    _context.Credential.Add(credential);
                    _context.SaveChangesAsync();
                    return new JsonResult(credential);
                }
            }
            // nếu người dùng đăng nhập thành công thì tạo session mới cho người dùng. 
            // Chính là thông tin tài khoản vừa đăng nhập.
            Response.StatusCode = (int)HttpStatusCode.Forbidden;
            return new JsonResult(customer);
        }
       
    }
}