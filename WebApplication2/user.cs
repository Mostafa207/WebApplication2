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
        [RegularExpression(@"^(?=.{7,})(?=(.*\d){1,})(?=(.*\W){1,})")]
        public string? password { get; set; }
    }
}
