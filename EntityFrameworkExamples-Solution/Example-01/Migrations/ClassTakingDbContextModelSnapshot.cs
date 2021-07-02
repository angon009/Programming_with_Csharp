﻿// <auto-generated />
using System;
using Example_01;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Example_01.Migrations
{
    [DbContext(typeof(ClassTakingDbContext))]
    partial class ClassTakingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Example_01.Course", b =>
                {
                    b.Property<int>("courseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("courseFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("courseStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("courseId");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("Example_01.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("courseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("courseId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("Example_01.Teacher", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dept")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("rating")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("teachers");
                });

            modelBuilder.Entity("Example_01.Student", b =>
                {
                    b.HasOne("Example_01.Course", null)
                        .WithMany("enrolledStudents")
                        .HasForeignKey("courseId");
                });

            modelBuilder.Entity("Example_01.Course", b =>
                {
                    b.Navigation("enrolledStudents");
                });
#pragma warning restore 612, 618
        }
    }
}
