using System.ComponentModel.DataAnnotations;

namespace WebApplication2
{
    public class user
    {
        [Key]
        public int id { get; set; }
        [StringLength(100,MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string name { get; set; }
        [EmailAddress]
        public string email { get; set; }
        
        public string? password { get; set; }
    }
}
