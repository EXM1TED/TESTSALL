﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Полигон_Для_Шрд.Classes;

#nullable disable

namespace Полигон_Для_Шрд.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240421143754_intilize3")]
    partial class intilize3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.17");

            modelBuilder.Entity("Полигон_Для_Шрд.Classes.ResultOfTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Id");

                    b.Property<int>("Result")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Result");

                    b.Property<int>("TasksCount")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Count_of_tasks");

                    b.Property<string>("TestName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Name_of_test");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("User_Id");

                    b.HasKey("Id");

                    b.ToTable("Results", (string)null);
                });

            modelBuilder.Entity("Полигон_Для_Шрд.Classes.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Id");

                    b.Property<int>("Class")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Class");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Login");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Password");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
