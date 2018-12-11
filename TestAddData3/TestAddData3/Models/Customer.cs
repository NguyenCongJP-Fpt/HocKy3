using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAddData3.Models
{
    public class Customer
    {
        public Customer()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdateddAt = DateTime.Now;
            this.Status = CustomerStatus.Activated;
        }

        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateddAt { get; set; }
        public CustomerStatus Status { get; set; }
    }

    public enum CustomerStatus
    {
        Activated = 1,
        DeActivated =0
    }
}
