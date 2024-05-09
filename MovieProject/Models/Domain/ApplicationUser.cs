using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MovieProject.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int Id { get; set; }

        public string Name{ get; set; }
    }
}
