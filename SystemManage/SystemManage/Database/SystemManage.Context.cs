﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SystemManage.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Defect> Defects { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Language_of_Type> Language_of_Type { get; set; }
        public virtual DbSet<Mail> Mails { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<SIT> SITs { get; set; }
        public virtual DbSet<SITStep> SITSteps { get; set; }
        public virtual DbSet<SubDefect> SubDefects { get; set; }
        public virtual DbSet<SubTask> SubTasks { get; set; }
        public virtual DbSet<Type_of_Contract> Type_of_Contract { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<ProjectMember> ProjectMembers { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<SubTaskSubmisstion> SubTaskSubmisstions { get; set; }
    }
}
