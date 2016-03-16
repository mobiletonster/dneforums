namespace App.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Forums")]
    public partial class Forum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Forum()
        {
            Attendances = new HashSet<Attendance>();
        }

        public int ForumId { get; set; }

        [StringLength(100)]
        public string ForumName { get; set; }

        [StringLength(250)]
        public string ForumDescription { get; set; }

        [StringLength(250)]
        public string ForumPresenters { get; set; }

        public DateTime? ForumDate { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
