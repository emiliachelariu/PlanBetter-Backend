﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlanBetter.Persistance.Data;

#nullable disable

namespace PlanBetter.Persistance.Data.Migrations
{
    [DbContext(typeof(PlanBetterDbContext))]
    partial class PlanBetterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PlanBetter.Domain.Entities.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AnswerText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 9991,
                            AnswerText = "da",
                            QuestionId = 991,
                            TeacherId = 991
                        },
                        new
                        {
                            Id = 9992,
                            AnswerText = "da?",
                            QuestionId = 992,
                            TeacherId = 992
                        });
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 200,
                            CourseName = "materie1",
                            GroupId = 1301,
                            TeacherId = 91
                        },
                        new
                        {
                            Id = 100,
                            CourseName = "materie2",
                            GroupId = 1302,
                            TeacherId = 92
                        });
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ExamId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseId");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Details");

                    b.Property<int>("GroupId")
                        .HasColumnType("int")
                        .HasColumnName("GroupId");

                    b.Property<string>("RoomNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Room");

                    b.Property<int?>("StudentGroupId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int")
                        .HasColumnName("TeacherId");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2")
                        .HasColumnName("TimeEnd");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2")
                        .HasColumnName("TimeStart");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentGroupId");

                    b.ToTable("Exams");

                    b.HasData(
                        new
                        {
                            Id = 551,
                            CourseId = 100,
                            Date = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6783),
                            Details = "examen grila",
                            GroupId = 1301,
                            RoomNo = "teams meet",
                            TeacherId = 91,
                            TimeEnd = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6787),
                            TimeStart = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6785)
                        },
                        new
                        {
                            Id = 552,
                            CourseId = 200,
                            Date = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6791),
                            Details = "examen scris",
                            GroupId = 1302,
                            RoomNo = "google meet",
                            TeacherId = 92,
                            TimeEnd = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6794),
                            TimeStart = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6792)
                        });
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<bool>("isApproval")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 991,
                            CourseId = 200,
                            QuestionText = "salut?",
                            StudentId = 1,
                            isApproval = false
                        },
                        new
                        {
                            Id = 992,
                            CourseId = 100,
                            QuestionText = "?salut?",
                            StudentId = 2,
                            isApproval = false
                        });
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StudentId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfJoin")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateOfJoin");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2")
                        .HasColumnName("Dob");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Fname");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Lname");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Mobile");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Pass");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfJoin = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6554),
                            Dob = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6513),
                            Email = "email1@facultate.student.com",
                            FName = "student",
                            LName = "unu",
                            Mobile = "1234",
                            Password = "parola123",
                            Status = false
                        },
                        new
                        {
                            Id = 2,
                            DateOfJoin = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6566),
                            Dob = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6564),
                            Email = "email2@facultate.student.com",
                            FName = "student",
                            LName = "doi",
                            Mobile = "07unudoi",
                            Password = "admin123",
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            DateOfJoin = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6570),
                            Dob = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6568),
                            Email = "email3@facultate.student.com",
                            FName = "student",
                            LName = "trei",
                            Mobile = "0777666777",
                            Password = "parola",
                            Status = false
                        });
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.StudentGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StudentGroups");

                    b.HasData(
                        new
                        {
                            Id = 1301,
                            GroupName = "C",
                            StudentId = 1
                        },
                        new
                        {
                            Id = 1302,
                            GroupName = "TI",
                            StudentId = 2
                        });
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfJoin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 91,
                            DateOfJoin = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6606),
                            Dob = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6604),
                            Email = "email1@facultate.profesor.com",
                            FName = "profesor",
                            JobTitle = "laborant",
                            LName = "unu",
                            Mobile = "1234",
                            Password = "parola123",
                            Status = false
                        },
                        new
                        {
                            Id = 92,
                            DateOfJoin = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6702),
                            Dob = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6700),
                            Email = "email2@facultate.profesor.com",
                            FName = "profesor",
                            JobTitle = "doc. ing.",
                            LName = "doi",
                            Mobile = "07unudoi",
                            Password = "admin123",
                            Status = true
                        },
                        new
                        {
                            Id = 93,
                            DateOfJoin = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6706),
                            Dob = new DateTime(2022, 8, 2, 11, 34, 49, 535, DateTimeKind.Local).AddTicks(6705),
                            Email = "email3@facultate.profesor.com",
                            FName = "profesor",
                            JobTitle = "profesor laborant",
                            LName = "trei",
                            Mobile = "0777666777",
                            Password = "parola",
                            Status = false
                        });
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("isAdmin")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "primuladmin@planbetter.com",
                            FName = "Primul",
                            LName = "Admin",
                            Password = "admin",
                            isAdmin = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "primulstudent@planbetter.com",
                            FName = "Primul",
                            LName = "Student",
                            Password = "admin",
                            isAdmin = 2
                        });
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.Answer", b =>
                {
                    b.HasOne("PlanBetter.Domain.Entities.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.Course", b =>
                {
                    b.HasOne("PlanBetter.Domain.Entities.Teacher", null)
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.Exam", b =>
                {
                    b.HasOne("PlanBetter.Domain.Entities.Course", null)
                        .WithMany("Exams")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlanBetter.Domain.Entities.StudentGroup", null)
                        .WithMany("Exams")
                        .HasForeignKey("StudentGroupId");
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.Question", b =>
                {
                    b.HasOne("PlanBetter.Domain.Entities.Course", null)
                        .WithMany("Questions")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlanBetter.Domain.Entities.Student", null)
                        .WithMany("Questions")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.Course", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.Student", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.StudentGroup", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("PlanBetter.Domain.Entities.Teacher", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
