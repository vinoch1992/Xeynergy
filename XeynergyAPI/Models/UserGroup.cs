using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XeynergyAPI.Models
{
    [Table("UserGroup")]
    public class UserGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserGroupId { get; set; }

        public string GroupName { get; set; }

        public int AccessRuleRefId { get; set; }

        [ForeignKey("AccessRuleRefId")]
        public AccessRule AccessRule { get; set; }
    }
}
