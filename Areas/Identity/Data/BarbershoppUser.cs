using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Barbershopp.Entities.Helpers;
using Microsoft.AspNetCore.Identity;

namespace Barbershopp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the BarbershoppUser class
public class BarbershoppUser : IdentityUser
{
    public int? Id { get; set; }
    public string? UserName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public UserRole userRole { get; set; }
}

