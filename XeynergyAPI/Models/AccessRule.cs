using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XeynergyAPI.Models
{
    [Table("AccessRule")]
    public class AccessRule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccessRuleId { get; set; }

        public string RuleName { get; set; }

        public bool Permission { get; set; }
    }
}
