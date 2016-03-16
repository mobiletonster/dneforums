namespace App.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ForumAttendanceVW")]
    public partial class ForumAttendanceVW
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ForumId { get; set; }

        [StringLength(100)]
        public string ForumName { get; set; }

        [StringLength(250)]
        public string ForumDescription { get; set; }

        [StringLength(250)]
        public string ForumPresenters { get; set; }

        public DateTime? ForumDate { get; set; }

        public int? AttendanceTypeId { get; set; }

        [StringLength(100)]
        public string TypeName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }
    }
}
