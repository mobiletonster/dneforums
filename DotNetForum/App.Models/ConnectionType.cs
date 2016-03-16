namespace App.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConnectionType")]
    public partial class ConnectionType
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
