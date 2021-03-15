using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam_PIIT.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public AccountStatus Status { get; set; }

        public enum AccountStatus
        {
            ACTIVE, DEACTIVE, DELETE
        }
    }
}