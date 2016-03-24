using App.Core.Security;
using App.Data;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class UserService
    {
        IRepository _repository;
        public UserService()
        {
            _repository = new Repository();
        }

        // overload allowing you to specify the repository in case you
        // want to pass a mock repo, etc.
        public UserService(IRepository repository)
        {
            _repository = repository;
        }

        public List<User> GetUsers()
        {
            return _repository.GetUsers().ToList();
        }

        public User GetUserById(int id)
        {
            return _repository.GetUsers().Where(m => m.UserId == id).FirstOrDefault();
        }

        public User GetUserByUsername(string userName)
        {
            return _repository.GetUsers().FirstOrDefault(m => m.UserName == userName);
        }

        public User CreateUser(User user)
        {
            if (string.IsNullOrEmpty(user.UserName))
            {
                throw new Exception("Username cannot be null");
            }

            var existingUser = _repository.GetUsers().Where(m => m.UserName == user.UserName).FirstOrDefault();
            if (existingUser != null)
            {
                throw new Exception("Username already in use");
            }

            // encrypt their password.
            user.Password = Crypto.EncryptPassword(user.Password);

            // The database will assign a userid, we will
            // get the newUser with userid back and return it.
            var newUser = _repository.AddRecord(user) as User;
            return newUser;   
        }

        public User UpdateUser(User user)
        {
            var existingUser = _repository.GetUsers().FirstOrDefault(m => m.UserId == user.UserId);
            // only the following fields can be modified through this method.
            existingUser.BirthDate = user.BirthDate;
            existingUser.Email = user.Email;
            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;
            existingUser.ModifiedDate = DateTime.Now;

            var updated = _repository.UpdateRecord(existingUser) as User;
            return updated;
        }

        public bool ChangePassword(int userId, string oldPassword, string newPassword)
        {
            var user = this.GetUserById(userId);
            if (Crypto.ComparePassword(oldPassword, user.Password));
            {
                user.Password = Crypto.EncryptPassword(newPassword);
            }
            var updated =_repository.UpdateRecord(user);
            return true;
        }

        public bool DeleteUser(string userName)
        {
            var existingUser = _repository.GetUsers().Where(m => m.UserName == userName).FirstOrDefault();
            if (existingUser != null)
            {
                var result = _repository.DeleteRecord(existingUser);
                return result;
            }
            return false;
        }

        public bool Authenticate(string userName, string password)
        {
            var user = this.GetUserByUsername(userName);
            if (user != null && Crypto.ComparePassword(password, user.Password))
            {
                return true;
            }
            return false;
        }

        public bool Authenticate(Credentials creds)
        {
            return Authenticate(creds.Username, creds.Password);
        }

    }
}
