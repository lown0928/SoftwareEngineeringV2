using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace SoftwareEngineeringP1.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}