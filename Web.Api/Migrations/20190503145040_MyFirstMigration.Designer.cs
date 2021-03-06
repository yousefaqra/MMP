﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.Api.Data;

namespace Web.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190503145040_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainModel.Model.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DoctorCode");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("GroupID");

                    b.Property<string>("HospitalName");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ID");

                    b.HasIndex("GroupID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("DomainModel.Model.Group", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity");

                    b.Property<string>("Code");

                    b.HasKey("ID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("DomainModel.Model.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("GDPA");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<int>("GroupID");

                    b.Property<bool>("IsSubscribed");

                    b.Property<string>("Name");

                    b.Property<int>("NumberOfHourse");

                    b.Property<bool>("Toofel");

                    b.HasKey("ID");

                    b.HasIndex("GroupID");

                    b.ToTable("Studentss");
                });

            modelBuilder.Entity("DomainModel.Model.Course", b =>
                {
                    b.HasOne("DomainModel.Model.Group", "Group")
                        .WithMany("Courses")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModel.Model.Student", b =>
                {
                    b.HasOne("DomainModel.Model.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
