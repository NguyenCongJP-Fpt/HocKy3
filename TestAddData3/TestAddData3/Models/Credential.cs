using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MlkPwgen;

namespace TestAddData3.Models
{
    public class Credential
    {
        public Credential()
        {

        }

        public CongCredential(long OwnerId)
        {
            this.AccessToken = PasswordGenerator.Generate(length: 40, allowed: Sets.Alphanumerics);
            this.RefreshToken = PasswordGenerator.Generate(length: 40, allowed: Sets.Alphanumerics);
            this.OwnerId = OwnerId;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;

        }

        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string Scope { get; set; }
        public string Status { get; set; }
    }
}
