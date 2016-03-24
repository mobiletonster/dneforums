using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.ViewModels
{
    public class UserVM
    {
        public UserVM()
        {

        }

        public UserVM(User u)
        {
            this.BirthDate = u.BirthDate;
            this.CreatedDate = u.CreatedDate;
            this.Email = u.Email;
            this.FirstName = u.FirstName;
            this.LastName = u.LastName;
            this.ModifiedDate = u.ModifiedDate;
            this.UserId = u.UserId;
            this.UserName = u.UserName;
        }
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
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

        public DateTime? BirthDate { get; set; }

        public string Email { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
