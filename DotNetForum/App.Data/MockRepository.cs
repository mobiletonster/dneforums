using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Models;

namespace App.Data
{
    public class MockRepository : IRepository
    {
        public IQueryable<Attendance> GetAttendances()
        {
            throw new NotImplementedException();
        }

        public IQueryable<AttendanceType> GetAttendanceTypes()
        {
            var attendanceTypes = new List<AttendanceType>();
            attendanceTypes.Add(new AttendanceType() { TypeId = 1, TypeName = "In Person" });
            attendanceTypes.Add(new AttendanceType() { TypeId = 2, TypeName = "Webex" });
            attendanceTypes.Add(new AttendanceType() { TypeId = 3, TypeName = "Youtube" });

            return attendanceTypes.AsQueryable();
        }

        public IQueryable<Connection> GetConnections()
        {
            throw new NotImplementedException();
        }

        public IQueryable<ConnectionType> GetConnectionTypes()
        {
            throw new NotImplementedException();
        }

        public IQueryable<ForumAttendanceVW> GetForumAttendanceVWs()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Forum> GetForums()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Talent> GetTalents()
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserConnectionVW> GetUserConnectionVWs()
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserTalent> GetUserTalents()
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserTalentVW> GetUserTalentVW()
        {
            throw new NotImplementedException();
        }

        public object UpdateRecord(object entity)
        {
            throw new NotImplementedException();
        }
        public object AddRecord(object entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRecord(object entity)
        {
            throw new NotImplementedException();
        }
    }
}
