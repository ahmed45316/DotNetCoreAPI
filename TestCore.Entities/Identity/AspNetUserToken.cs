namespace TestCore.Entities.Identity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class AspNetUserToken
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(450)]
        public string UserId { get; set; }

        [Column(Order = 1)]
        [StringLength(450)]
        public string LoginProvider { get; set; }

        [Column(Order = 2)]
        [StringLength(450)]
        public string Name { get; set; }

        public string Value { get; set; }
        [ForeignKey("UserId")]
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
