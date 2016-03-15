namespace App.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Talent
    {
        public int TalentId { get; set; }

        [StringLength(100)]
        public string TalentName { get; set; }

        [StringLength(250)]
        public string TalentDescription { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
