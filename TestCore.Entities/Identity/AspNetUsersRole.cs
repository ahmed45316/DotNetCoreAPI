namespace TestCore.Entities.Identity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class AspNetUsersRole
    {
        [Key]
        [StringLength(450)]
        public string Id { get; set; }

        [Required]
        [StringLength(450)]
        public string RoleId { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        public bool IsDeleted { get; set; } = false;
        public bool IsBlock { get; set; } = false;
        [ForeignKey("RoleId")]
        public virtual AspNetRole AspNetRole { get; set; }
        [ForeignKey("UserId")]
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
