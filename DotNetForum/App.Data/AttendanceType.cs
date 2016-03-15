namespace App.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttendanceType")]
    public partial class AttendanceType
    {
        [Key]
        public int TypeId { get; set; }

        [StringLength(100)]
        public string TypeName { get; set; }

        [StringLength(250)]
        public string TypeDescription { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
