using App.Data;
using App.Models;
using App.Services;
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
            TestMockRepo();

            TestRealRepo();

            LoadAttendances();

            GetUsers();

            DeleteUser();

            GetUsers();

            CreateUser();

            GetUsers();

            Authenticate();

            ChangePassword();

            Authenticate();

            GetUsers();

            Console.ReadKey();
        }

        private static void GetUsers()
        {
            BlankLine();
            Console.WriteLine("Fetching users...");
            var userService = new UserService();
            var users = userService.GetUsers();
            foreach(var u in users)
            {
                Console.WriteLine(u.UserId + " " + u.FullName + " " + u.Password);
            }

        }
        private static void CreateUser()
        {
            BlankLine();
            Console.WriteLine("Creating new user...");
            var userService = new UserService();
            var user = new User();
            user.FirstName = "Bob";
            user.LastName = "Tabor";
            user.Password = "password1";
            user.UserName = "bob.tabor";
            user.BirthDate = DateTime.Parse("1971-03-15");
            user.CreatedDate = DateTime.Now;
            user.ModifiedDate = user.CreatedDate;

            userService.CreateUser(user);
        }
        private static void DeleteUser()
        {
            BlankLine();
            Console.WriteLine("Deleting bob tabor...");
            var userService = new UserService();
            userService.DeleteUser("bob.tabor");

        }
        private static void Authenticate()
        {
            BlankLine();
            Console.WriteLine("Authenticate Bob");
            var userService = new UserService();
            var result = userService.Authenticate("bob.tabor", "gReet1ngs!");
            Console.WriteLine("user authentication result: " + result);
        }
        private static void ChangePassword()
        {
            BlankLine();
            Console.WriteLine("Changing bob tabor's password...");
            var userService = new UserService();
            var user = userService.GetUserByUsername("bob.tabor");
            var result = userService.ChangePassword(user.UserId, "password1", "gReet1ngs!");
        }
        private static void BlankLine()
        {
            Console.WriteLine();
        }
        private static void TestMockRepo()
        {
            BlankLine();
            Console.WriteLine("Fetching data from mock repo...");
            var repository = new MockRepository();
            FetchAttendanceTypes(repository);
        }
        private static void TestRealRepo()
        {
            BlankLine();
            Console.WriteLine("Fetching data from real repo...");
            var repository = new Repository();
            FetchAttendanceTypes(repository);
        }
        private static void FetchAttendanceTypes(IRepository repository)
        {
            var att = repository.GetAttendanceTypes().ToList();
            foreach (var at in att)
            {
                Console.WriteLine(at.TypeName);
            }
        }
        private static void LoadAttendances()
        {
            BlankLine();
            Console.WriteLine("Load Attendances..");
            var context = new ForumContext();
            //context.Database.Log = s => Console.WriteLine(s);

            //var junk = (from u in context.Users.ToList()
            //            join a in context.Attendances.ToList() on u.UserId equals a.UserId
            //            select new UserVM(u, a)).ToList();

            var junk = context.Database.SqlQuery<UserVM>("select u.FirstName, u.LastName, a.ForumId from dbo.Users u inner join dbo.Attendance a on u.userid=a.userid");

            foreach (var j in junk)
            {
                Console.WriteLine(j.FirstName);
            }
        }
    }
}
