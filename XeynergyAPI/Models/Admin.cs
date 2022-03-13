using System.ComponentModel.DataAnnotations.Schema;

namespace XeynergyAPI.Models
{
    [Table("Admin")]
    public class Admin: Person
    {
        public string Privilege { get; set; }
    }
}
