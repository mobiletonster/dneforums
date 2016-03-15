using App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Con
{
    public class UserVM
    {
        public UserVM()
        {

        }
        public UserVM(User u, Attendance a)
        {
            this.FirstName = u.FirstName;
            this.LastName = u.LastName;
            this.ForumId = a.ForumId;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int?  ForumId { get; set; }
    }
}
