using System.ComponentModel.DataAnnotations.Schema;

namespace XeynergyAPI.Models
{
    [Table("User")]
    public class User : Person
    {
        public int AttachedCustomerId { get; set; }

        public int UserGroupRefId { get; set; }

        [ForeignKey("UserGroupRefId")]
        public UserGroup UserGroup { get; set; }
    }
}
