using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Models;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace App.Data
{
    public interface IRepository
    {
        IQueryable<Attendance> GetAttendances();
        IQueryable<AttendanceType> GetAttendanceTypes();
        IQueryable<Connection> GetConnections();
        IQueryable<ConnectionType> GetConnectionTypes();
        IQueryable<ForumAttendanceVW> GetForumAttendanceVWs();
        IQueryable<Forum> GetForums();
        IQueryable<Talent> GetTalents();
        IQueryable<UserConnectionVW> GetUserConnectionVWs();
        IQueryable<User> GetUsers();
        IQueryable<UserTalent> GetUserTalents();
        IQueryable<UserTalentVW> GetUserTalentVW();

        object AddRecord(object entity);
        object UpdateRecord(object entity);
        bool DeleteRecord(object entity);
    }

    public class Repository : IRepository, IDisposable
    {
        private ForumContext _context;

        public Repository()
        {
            _context = new ForumContext();
        }

        // overload constructor allowing you to pass in your own context
        public Repository(ForumContext context)
        {
            _context = context;
        }

        #region Repository Entity Gets
        public IQueryable<Attendance> GetAttendances()
        {
            return _context.Attendances;
        }

        public IQueryable<AttendanceType> GetAttendanceTypes()
        {
            return _context.AttendanceTypes;
        }
            
        public IQueryable<Connection> GetConnections()
        {
            return _context.Connections;
        }

        public IQueryable<ConnectionType> GetConnectionTypes()
        {
            return _context.ConnectionTypes;
        }

        public IQueryable<Forum> GetForums()
        {
            return _context.Forums;
        }

        public IQueryable<ForumAttendanceVW> GetForumAttendanceVWs()
        {
            return _context.ForumAttendanceVWs;
        }

        public IQueryable<Talent> GetTalents()
        {
            return _context.Talents;
        }

        public IQueryable<User> GetUsers()
        {
            return _context.Users;
        }

        public IQueryable<UserConnectionVW> GetUserConnectionVWs()
        {
            return _context.UserConnectionVWs;
        }

        public IQueryable<UserTalent> GetUserTalents()
        {
            return _context.UserTalents;
        }

        public IQueryable<UserTalentVW> GetUserTalentVW()
        {
            return _context.UserTalentVWs;
        }

        #endregion

        #region Save Methods
        public object AddRecord(object entity)
        {
            var dbEntity = _context.Entry(entity);
            dbEntity.State = EntityState.Added;
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                string errMessage = string.Empty;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validErr in validationErrors.ValidationErrors)
                    {
                        errMessage += string.Format("Property: {0} Error:{1}", validErr.PropertyName, validErr.ErrorMessage);
                    }

                }
                throw new Exception(errMessage);
            }

            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbEntity.State = EntityState.Detached;
            }
            return dbEntity.Entity;
        }

        public object UpdateRecord(object entity)
        {
            var dbEntity = _context.Entry(entity);
            dbEntity.State = EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                string errMessage = string.Empty;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validErr in validationErrors.ValidationErrors)
                    {
                        errMessage += string.Format("Property: {0} Error:{1}", validErr.PropertyName, validErr.ErrorMessage);
                    }

                }
                throw new Exception(errMessage);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbEntity.State = EntityState.Detached;
            }
            return dbEntity.Entity;
        }

        public bool DeleteRecord(object entity)
        {
            var dbEntity = _context.Entry(entity);
            dbEntity.State = EntityState.Deleted;
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                string errMessage = string.Empty;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validErr in validationErrors.ValidationErrors)
                    {
                        errMessage += string.Format("Property: {0} Error:{1}", validErr.PropertyName, validErr.ErrorMessage);
                    }

                }
                throw new Exception(errMessage);
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;
        }
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Repository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
