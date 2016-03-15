using App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Con
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ForumContext();
            //context.Database.Log = s => Console.WriteLine(s);
            var users = context.Users.Include("Attendances").ToList();

            //var junk = (from u in context.Users.ToList()
            //            join a in context.Attendances.ToList() on u.UserId equals a.UserId
            //            select new UserVM(u,a)).ToList();

            var junk = context.Database.SqlQuery<UserVM>("select u.FirstName, u.LastName, a.ForumId from dbo.Users u inner join dbo.Attendance a on u.userid=a.userid");

            foreach (var j in junk)
            {
                Console.WriteLine(j.FirstName);
            }

            Console.ReadKey();
        }
    }
}
