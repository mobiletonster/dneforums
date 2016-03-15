namespace App.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [NotMapped]
        public string FullName { get { return this.FirstName + " " + this.LastName; } }

        public int Age
        {
            get
            {
                if (this.BirthDate.HasValue)
                {
                    DateTime now = DateTime.Today;
                    int age = now.Year - this.BirthDate.Value.Year;
                    if (now < this.BirthDate.Value.AddYears(age)) age--;
                    return age;
                }
                return 0;
            }
        }
    }
}
