﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RESTFull.Infrastructure;

#nullable disable

namespace RESTFull.Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221204145800_SQLMigration1")]
    partial class SQLMigration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RESTFull.Domain.Achievement", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Achievements")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Personid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Personid");

                    b.ToTable("Achievements");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Achievement");
                });

            modelBuilder.Entity("RESTFull.Domain.Person", b =>
                {
                    b.Property<int>("Personid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Passport")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("patronymic")
                        .HasColumnType("longtext");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Personid");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("RESTFull.Domain.CreativeActivities", b =>
                {
                    b.HasBaseType("RESTFull.Domain.Achievement");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("CreativeActivities");
                });

            modelBuilder.Entity("RESTFull.Domain.IntellectualContests", b =>
                {
                    b.HasBaseType("RESTFull.Domain.Achievement");

                    b.Property<string>("Form")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("IntellectualContests");
                });

            modelBuilder.Entity("RESTFull.Domain.Olympiads", b =>
                {
                    b.HasBaseType("RESTFull.Domain.Achievement");

                    b.Property<string>("Form")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Olympiads_Form");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Olympiads");
                });

            modelBuilder.Entity("RESTFull.Domain.ScienceActivities", b =>
                {
                    b.HasBaseType("RESTFull.Domain.Achievement");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ScienceActivities_Type");

                    b.HasDiscriminator().HasValue("ScienceActivities");
                });

            modelBuilder.Entity("RESTFull.Domain.SocioCultural", b =>
                {
                    b.HasBaseType("RESTFull.Domain.Achievement");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("SocioCultural_Type");

                    b.HasDiscriminator().HasValue("SocioCultural");
                });

            modelBuilder.Entity("RESTFull.Domain.Sport", b =>
                {
                    b.HasBaseType("RESTFull.Domain.Achievement");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Sport_Type");

                    b.HasDiscriminator().HasValue("Sport");
                });

            modelBuilder.Entity("RESTFull.Domain.Achievement", b =>
                {
                    b.HasOne("RESTFull.Domain.Person", "Person")
                        .WithMany("Achievement")
                        .HasForeignKey("Personid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("RESTFull.Domain.Person", b =>
                {
                    b.Navigation("Achievement");
                });
#pragma warning restore 612, 618
        }
    }
}