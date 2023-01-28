﻿// <auto-generated />
using System;
using BusniessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusniessLayer.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220915172038_AddingComeentTable")]
    partial class AddingComeentTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusniessLayer.Entity.Ajax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ajax");
                });

            modelBuilder.Entity("BusniessLayer.Entity.Band", b =>
                {
                    b.Property<int>("BandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BandTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BandId");

                    b.ToTable("Band");
                });

            modelBuilder.Entity("BusniessLayer.Entity.Comment", b =>
                {
                    b.Property<int>("Commentid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Commentid");

                    b.HasIndex("ProjectId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("BusniessLayer.Entity.Duty", b =>
                {
                    b.Property<int>("DutyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DutyDescrption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DutyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SprintId")
                        .HasColumnType("int");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("TeamMemberId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DutyId");

                    b.HasIndex("SprintId");

                    b.HasIndex("StateId");

                    b.HasIndex("TeamMemberId");

                    b.ToTable("Duties");
                });

            modelBuilder.Entity("BusniessLayer.Entity.LastUpdate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FieldName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("LastUpdates");
                });

            modelBuilder.Entity("BusniessLayer.Entity.Member", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("BandId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FitstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("BandId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Member");
                });

            modelBuilder.Entity("BusniessLayer.Entity.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectDescrption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId");

                    b.HasIndex("StateId");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("BusniessLayer.Entity.ProjectMembers", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("MemberId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProjectId", "MemberId");

                    b.HasIndex("MemberId");

                    b.ToTable("ProjectMembers");
                });

            modelBuilder.Entity("BusniessLayer.Entity.Reject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RejectedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RejectedNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkHistoryId")
                        .HasColumnType("int");

                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkHistoryId");

                    b.HasIndex("WorkId");

                    b.ToTable("Rejects");
                });

            modelBuilder.Entity("BusniessLayer.Entity.Sprint", b =>
                {
                    b.Property<int>("SprintId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("SprintName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("sprintDescrption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SprintId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("StateId");

                    b.ToTable("sprints");
                });

            modelBuilder.Entity("BusniessLayer.Entity.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateId");

                    b.ToTable("states");
                });

            modelBuilder.Entity("BusniessLayer.Entity.Work", b =>
                {
                    b.Property<int>("WorkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DutyId")
                        .HasColumnType("int");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("WorkDescrption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkId");

                    b.HasIndex("DutyId");

                    b.HasIndex("StateId");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("BusniessLayer.Entity.WorkAttachment", b =>
                {
                    b.Property<int>("WorkAttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("File")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("WorkAttachmentId");

                    b.HasIndex("WorkId");

                    b.ToTable("WorkAttachments");
                });

            modelBuilder.Entity("BusniessLayer.Entity.WorkHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkAttachmentId")
                        .HasColumnType("int");

                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.HasIndex("WorkAttachmentId");

                    b.HasIndex("WorkId");

                    b.ToTable("WorkHistory");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BusniessLayer.Entity.ProjectManger", b =>
                {
                    b.HasBaseType("BusniessLayer.Entity.Member");

                    b.HasDiscriminator().HasValue("ProjectManger");
                });

            modelBuilder.Entity("BusniessLayer.Entity.TeamMember", b =>
                {
                    b.HasBaseType("BusniessLayer.Entity.Member");

                    b.HasDiscriminator().HasValue("TeamMember");
                });

            modelBuilder.Entity("BusniessLayer.Entity.Teamleader", b =>
                {
                    b.HasBaseType("BusniessLayer.Entity.Member");

                    b.HasDiscriminator().HasValue("Teamleader");
                });

            modelBuilder.Entity("BusniessLayer.Entity.Comment", b =>
                {
                    b.HasOne("BusniessLayer.Entity.Project", "project")
                        .WithMany("Comments")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("BusniessLayer.Entity.Duty", b =>
                {
                    b.HasOne("BusniessLayer.Entity.Sprint", "Sprint")
                        .WithMany("Duties")
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusniessLayer.Entity.State", "State")
                        .WithMany("duties")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusniessLayer.Entity.TeamMember", "TeamMember")
                        .WithMany("Duties")
                        .HasForeignKey("TeamMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusniessLayer.Entity.LastUpdate", b =>
                {
                    b.HasOne("BusniessLayer.Entity.State", "State")
                        .WithMany("LastUpdates")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusniessLayer.Entity.Member", b =>
                {
                    b.HasOne("BusniessLayer.Entity.Band", "Band")
                        .WithMany("Members")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusniessLayer.Entity.Project", b =>
                {
                    b.HasOne("BusniessLayer.Entity.State", "State")
                        .WithMany("Projects")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusniessLayer.Entity.ProjectMembers", b =>
                {
                    b.HasOne("BusniessLayer.Entity.Member", "Member")
                        .WithMany("ProjectMembers")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusniessLayer.Entity.Project", "Project")
                        .WithMany("ProjectMembers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusniessLayer.Entity.Reject", b =>
                {
                    b.HasOne("BusniessLayer.Entity.WorkHistory", "WorkHistory")
                        .WithMany("Rejects")
                        .HasForeignKey("WorkHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusniessLayer.Entity.Work", "Work")
                        .WithMany("Rejects")
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusniessLayer.Entity.Sprint", b =>
                {
                    b.HasOne("BusniessLayer.Entity.Project", "Project")
                        .WithMany("Sprints")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusniessLayer.Entity.State", "State")
                        .WithMany("sprints")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusniessLayer.Entity.Work", b =>
                {
                    b.HasOne("BusniessLayer.Entity.Duty", "Duty")
                        .WithMany("Works")
                        .HasForeignKey("DutyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusniessLayer.Entity.State", "State")
                        .WithMany("Works")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusniessLayer.Entity.WorkAttachment", b =>
                {
                    b.HasOne("BusniessLayer.Entity.Work", "Works")
                        .WithMany("WorkAttachments")
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusniessLayer.Entity.WorkHistory", b =>
                {
                    b.HasOne("BusniessLayer.Entity.State", "State")
                        .WithMany("WorkHistories")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusniessLayer.Entity.WorkAttachment", "WorkAttachments")
                        .WithMany("WorkHistories")
                        .HasForeignKey("WorkAttachmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusniessLayer.Entity.Work", "Work")
                        .WithMany("WorkHistories")
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BusniessLayer.Entity.Member", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BusniessLayer.Entity.Member", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusniessLayer.Entity.Member", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BusniessLayer.Entity.Member", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
