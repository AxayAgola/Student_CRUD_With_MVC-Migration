using System.ComponentModel.DataAnnotations;

namespace MVC_Application_Migration.Models
{
    public class Studentregister
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Studentname { get; set; }
        [Required]
        public string Studentbranch { get; set; }
        [Required]
        public int Studentroll { get; set; }
    }
}