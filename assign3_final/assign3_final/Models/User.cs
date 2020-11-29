using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Assignment.Models {
public class User {
    [Key,NotNull]
    public string UserName { get; set; }
    public string Role { get; set; }
    [NotNull]
    public string Password { get; set; }
}
}