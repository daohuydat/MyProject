namespace MyProjectDBContext.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Advisor
    {
        public long AdvisorID { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        public string LoginName { get; set; }

        [StringLength(255)]
        public string ProfileImage { get; set; }

        public int Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime DOB { get; set; }

        [Required]
        [StringLength(25)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string IDImageFront { get; set; }

        [StringLength(255)]
        public string IDImageBack { get; set; }

        public int TypeOfPayment { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public int DomainID { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        public virtual AdvisorDomain AdvisorDomain { get; set; }
    }
}
