﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using headhunters_candidates_database.Data;

#nullable disable

namespace headhunters_candidates_database.Data.Migrations
{
    [DbContext(typeof(HeadhuntersCandidatesDbContext))]
    [Migration("20221020110852_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CandidateCompany", b =>
                {
                    b.Property<int>("CandidatesId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyAppliedToId")
                        .HasColumnType("int");

                    b.HasKey("CandidatesId", "CompanyAppliedToId");

                    b.HasIndex("CompanyAppliedToId");

                    b.ToTable("CandidateCompany");
                });

            modelBuilder.Entity("CandidatePosition", b =>
                {
                    b.Property<int>("CandidatesId")
                        .HasColumnType("int");

                    b.Property<int>("PositionAppliedToId")
                        .HasColumnType("int");

                    b.HasKey("CandidatesId", "PositionAppliedToId");

                    b.HasIndex("PositionAppliedToId");

                    b.ToTable("CandidatePosition");
                });

            modelBuilder.Entity("CompanyPosition", b =>
                {
                    b.Property<int>("CompaniesId")
                        .HasColumnType("int");

                    b.Property<int>("OpenPositionsId")
                        .HasColumnType("int");

                    b.HasKey("CompaniesId", "OpenPositionsId");

                    b.HasIndex("OpenPositionsId");

                    b.ToTable("CompanyPosition");
                });

            modelBuilder.Entity("headhunters_candidates_database.Core.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("headhunters_candidates_database.Core.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("headhunters_candidates_database.Core.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OpenPositions");
                });

            modelBuilder.Entity("headhunters_candidates_database.Core.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("CandidateCompany", b =>
                {
                    b.HasOne("headhunters_candidates_database.Core.Models.Candidate", null)
                        .WithMany()
                        .HasForeignKey("CandidatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("headhunters_candidates_database.Core.Models.Company", null)
                        .WithMany()
                        .HasForeignKey("CompanyAppliedToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandidatePosition", b =>
                {
                    b.HasOne("headhunters_candidates_database.Core.Models.Candidate", null)
                        .WithMany()
                        .HasForeignKey("CandidatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("headhunters_candidates_database.Core.Models.Position", null)
                        .WithMany()
                        .HasForeignKey("PositionAppliedToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyPosition", b =>
                {
                    b.HasOne("headhunters_candidates_database.Core.Models.Company", null)
                        .WithMany()
                        .HasForeignKey("CompaniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("headhunters_candidates_database.Core.Models.Position", null)
                        .WithMany()
                        .HasForeignKey("OpenPositionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("headhunters_candidates_database.Core.Models.Skill", b =>
                {
                    b.HasOne("headhunters_candidates_database.Core.Models.Candidate", null)
                        .WithMany("Skillset")
                        .HasForeignKey("CandidateId");
                });

            modelBuilder.Entity("headhunters_candidates_database.Core.Models.Candidate", b =>
                {
                    b.Navigation("Skillset");
                });
#pragma warning restore 612, 618
        }
    }
}
