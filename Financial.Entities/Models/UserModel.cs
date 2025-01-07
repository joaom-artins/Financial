using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Financial.Domain.Models;

public class UserModel : IdentityUser<Guid>
{
    [MaxLength(50)]
    public string FullName { get; set; } = string.Empty;
    [Precision(10,2)]
    public decimal Salary { get; set; }
    public string Occupation { get; set; } = string.Empty;
}

