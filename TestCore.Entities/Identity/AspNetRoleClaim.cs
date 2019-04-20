namespace TestCore.Entities.Identity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class AspNetRoleClaim
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(450)]
        public string RoleId { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }
        [ForeignKey("RoleId")] 
        public virtual AspNetRole AspNetRole { get; set; }
    }
}
