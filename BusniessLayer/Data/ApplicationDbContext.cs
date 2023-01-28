using BusniessLayer.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusniessLayer.Data
{
    public class ApplicationDbContext : IdentityDbContext<Member>
    {
        public DbSet<Project> projects { get; set; }
        public DbSet<ProjectMembers> ProjectMembers { get; set; }

        public DbSet<ProjectManger> ProjectMangers { get; set; }
        public DbSet<Teamleader> Teamleaders { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Sprint> sprints { get; set; }
        public DbSet<Duty> Duties { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<WorkAttachment> WorkAttachments { get; set; }
        public DbSet<State> states { get; set; }
        public DbSet<Ajax> Ajax { get; set; }
        public DbSet<WorkHistory> WorkHistory { get; set; }
        public DbSet<Reject> Rejects { get; set; }
        public DbSet<LastUpdate> LastUpdates { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Member>()
                .HasOne(x => x.Band)
                .WithMany(x => x.Members).HasForeignKey(x => x.BandId);

            builder.Entity<ProjectMembers>()
                .HasOne(x => x.Member)
                .WithMany(x => x.ProjectMembers).HasForeignKey(x => x.MemberId);

            builder.Entity<ProjectMembers>()
                .HasOne(x => x.Project)
                .WithMany(x => x.ProjectMembers).HasForeignKey(x => x.ProjectId);

            builder.Entity<ProjectMembers>().HasKey(x => new { x.ProjectId, x.MemberId });

            builder.Entity<Sprint>()
                .HasOne(x => x.Project)
                .WithMany(x => x.Sprints).HasForeignKey(x => x.ProjectId);
            builder.Entity<Duty>()
                .HasOne(x => x.Sprint)
                .WithMany(x => x.Duties).HasForeignKey(x => x.SprintId);
            builder.Entity<Duty>()
                .HasOne(x => x.TeamMember)
                .WithMany(x => x.Duties).HasForeignKey(x => x.TeamMemberId);

            builder.Entity<Work>()
                .HasOne(x => x.Duty)
                .WithMany(x => x.Works).HasForeignKey(x => x.DutyId);

            builder.Entity<WorkAttachment>()
                .HasOne(x => x.Works)
                .WithMany(x => x.WorkAttachments).HasForeignKey(x => x.WorkId);
            builder.Entity<Duty>()
                .HasOne(x => x.State)
                .WithMany(x => x.duties).HasForeignKey(x => x.StateId);

            builder.Entity<Work>()
                .HasOne(x => x.State)
                .WithMany(x => x.Works).HasForeignKey(x => x.StateId);

            builder.Entity<Sprint>()
         .HasOne(x => x.State)
         .WithMany(x => x.sprints).HasForeignKey(x => x.StateId);
            builder.Entity<WorkHistory>()
                .HasOne(x => x.State)
                .WithMany(x => x.WorkHistories).HasForeignKey(x => x.StateId);
            builder.Entity<WorkHistory>()
                .HasOne(x => x.Work)
                .WithMany(x => x.WorkHistories).HasForeignKey(x => x.WorkId);
            builder.Entity<Reject>()
                .HasOne(x => x.Work)
                .WithMany(x => x.Rejects).HasForeignKey(x => x.WorkId);
            builder.Entity<Project>()
                .HasOne(x => x.State)
                .WithMany(x => x.Projects).HasForeignKey(x => x.StateId);
            builder.Entity<Reject>()
                .HasOne(x => x.WorkHistory)
                .WithMany(x => x.Rejects)
                .HasForeignKey(x => x.WorkHistoryId);
            builder.Entity<WorkHistory>()
                .HasOne(x => x.WorkAttachments)
                .WithMany(x => x.WorkHistories)
                .HasForeignKey(x => x.WorkAttachmentId);
            builder.Entity<LastUpdate>()
                .HasOne(x => x.State)
                .WithMany(x => x.LastUpdates).HasForeignKey(x => x.StateId);
            builder.Entity<Comment>()
                .HasOne(x => x.project)
                .WithMany(x => x.Comments).HasForeignKey(x => x.ProjectId);
            builder.Entity<Comment>()
                .HasOne(x => x.Member)
                .WithMany(x => x.Comments).HasForeignKey(x => x.MemberId);
        }
    }
}