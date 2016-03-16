namespace App.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using App.Models;

    public partial class ForumContext : DbContext
    {
        public ForumContext()
            : base("name=ForumContext")
        {
            this.Database.Log = s =>
            {
                System.Diagnostics.Debug.WriteLine(s);
                Console.WriteLine(s);
            };
        }

        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<AttendanceType> AttendanceTypes { get; set; }
        public virtual DbSet<Connection> Connections { get; set; }
        public virtual DbSet<ConnectionType> ConnectionTypes { get; set; }
        public virtual DbSet<Forum> Forums { get; set; }
        public virtual DbSet<Talent> Talents { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserTalent> UserTalents { get; set; }
        public virtual DbSet<ForumAttendanceVW> ForumAttendanceVWs { get; set; }
        public virtual DbSet<UserConnectionVW> UserConnectionVWs { get; set; }
        public virtual DbSet<UserTalentVW> UserTalentVWs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttendanceType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<AttendanceType>()
                .Property(e => e.TypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Connection>()
                .Property(e => e.Handle)
                .IsUnicode(false);

            modelBuilder.Entity<ConnectionType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<ConnectionType>()
                .Property(e => e.TypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Forum>()
                .Property(e => e.ForumName)
                .IsUnicode(false);

            modelBuilder.Entity<Forum>()
                .Property(e => e.ForumDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Forum>()
                .Property(e => e.ForumPresenters)
                .IsUnicode(false);

            modelBuilder.Entity<Forum>()
                .HasMany(e => e.Attendances)
                .WithRequired(e => e.Forum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Talent>()
                .Property(e => e.TalentName)
                .IsUnicode(false);

            modelBuilder.Entity<Talent>()
                .Property(e => e.TalentDescription)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Attendances)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ForumAttendanceVW>()
                .Property(e => e.ForumName)
                .IsUnicode(false);

            modelBuilder.Entity<ForumAttendanceVW>()
                .Property(e => e.ForumDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ForumAttendanceVW>()
                .Property(e => e.ForumPresenters)
                .IsUnicode(false);

            modelBuilder.Entity<ForumAttendanceVW>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<ForumAttendanceVW>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<ForumAttendanceVW>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<ForumAttendanceVW>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<UserConnectionVW>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserConnectionVW>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<UserConnectionVW>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<UserConnectionVW>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<UserConnectionVW>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<UserConnectionVW>()
                .Property(e => e.TypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<UserConnectionVW>()
                .Property(e => e.Handle)
                .IsUnicode(false);

            modelBuilder.Entity<UserTalentVW>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserTalentVW>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<UserTalentVW>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<UserTalentVW>()
                .Property(e => e.TalentName)
                .IsUnicode(false);

            modelBuilder.Entity<UserTalentVW>()
                .Property(e => e.TalentDescription)
                .IsUnicode(false);
        }
    }
}
