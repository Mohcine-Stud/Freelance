﻿// <auto-generated />
using System;
using Freelance.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Freelance.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Freelance.Domain.Models.Candidat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Disponibilite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobilite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tele")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Condidats");
                });

            modelBuilder.Entity("Freelance.Domain.Models.Competence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Competences");
                });

            modelBuilder.Entity("Freelance.Domain.Models.CompetenceOffre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdCompetence")
                        .HasColumnType("int");

                    b.Property<int?>("IdCompetenceNavigationId")
                        .HasColumnType("int");

                    b.Property<int?>("IdOffre")
                        .HasColumnType("int");

                    b.Property<int?>("IdOffreNavigationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCompetenceNavigationId");

                    b.HasIndex("IdOffreNavigationId");

                    b.ToTable("CompetenceOffres");
                });

            modelBuilder.Entity("Freelance.Domain.Models.ComptenceDmExpertise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdCompetence")
                        .HasColumnType("int");

                    b.Property<int?>("IdCompetenceNavigationId")
                        .HasColumnType("int");

                    b.Property<int?>("IdDmexpertise")
                        .HasColumnType("int");

                    b.Property<int?>("IdDmexpertiseNavigationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCompetenceNavigationId");

                    b.HasIndex("IdDmexpertiseNavigationId");

                    b.ToTable("ComptenceDmExpertises");
                });

            modelBuilder.Entity("Freelance.Domain.Models.CondidatComp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdComp")
                        .HasColumnType("int");

                    b.Property<int?>("IdCompNavigationId")
                        .HasColumnType("int");

                    b.Property<int?>("IdCond")
                        .HasColumnType("int");

                    b.Property<int?>("IdCondNavigationId")
                        .HasColumnType("int");

                    b.Property<string>("Niveau")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCompNavigationId");

                    b.HasIndex("IdCondNavigationId");

                    b.ToTable("CondidatComps");
                });

            modelBuilder.Entity("Freelance.Domain.Models.ConsultaionProfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateConsultation")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdCondidat")
                        .HasColumnType("int");

                    b.Property<int?>("IdCondidatNavigationId")
                        .HasColumnType("int");

                    b.Property<int?>("IdEntreprise")
                        .HasColumnType("int");

                    b.Property<int?>("IdEntrepriseNavigationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCondidatNavigationId");

                    b.HasIndex("IdEntrepriseNavigationId");

                    b.ToTable("ConsultaionProfils");
                });

            modelBuilder.Entity("Freelance.Domain.Models.DomaineExpertise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DomaineExpertises");
                });

            modelBuilder.Entity("Freelance.Domain.Models.Entreprise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RaisonSociale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Entreprises");
                });

            modelBuilder.Entity("Freelance.Domain.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateDebut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateFin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCondidat")
                        .HasColumnType("int");

                    b.Property<int?>("IdCondidatNavigationId")
                        .HasColumnType("int");

                    b.Property<string>("Local")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCondidatNavigationId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("Freelance.Domain.Models.Formation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateDebut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateFin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ecole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCondidat")
                        .HasColumnType("int");

                    b.Property<int?>("IdCondidatNavigationId")
                        .HasColumnType("int");

                    b.Property<string>("Niveau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCondidatNavigationId");

                    b.ToTable("Formations");
                });

            modelBuilder.Entity("Freelance.Domain.Models.Messagerie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateMsg")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DestinataireId")
                        .HasColumnType("int");

                    b.Property<int?>("ExpediteurId")
                        .HasColumnType("int");

                    b.Property<int?>("ExpediteurNavigationId")
                        .HasColumnType("int");

                    b.Property<string>("Msg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExpediteurId");

                    b.HasIndex("ExpediteurNavigationId");

                    b.ToTable("Messageries");
                });

            modelBuilder.Entity("Freelance.Domain.Models.Offre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatePub")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descrpition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Offres");
                });

            modelBuilder.Entity("Freelance.Domain.Models.Projet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCondidat")
                        .HasColumnType("int");

                    b.Property<int?>("IdCondidatNavigationId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCondidatNavigationId");

                    b.ToTable("Projets");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "0ebde786-0267-495c-be29-1a83fb53c0ce",
                            ConcurrencyStamp = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "38bf5bfd-14da-4410-a869-0dc5cb950336",
                            ConcurrencyStamp = "2",
                            Name = "Candidat",
                            NormalizedName = "CANDIDAT"
                        },
                        new
                        {
                            Id = "4210fed1-5d94-4378-917f-bf8414a7c7fe",
                            ConcurrencyStamp = "3",
                            Name = "Entreprise",
                            NormalizedName = "ENTREPRISE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Freelance.Domain.Models.CompetenceOffre", b =>
                {
                    b.HasOne("Freelance.Domain.Models.Competence", "IdCompetenceNavigation")
                        .WithMany("CompetenceOffres")
                        .HasForeignKey("IdCompetenceNavigationId");

                    b.HasOne("Freelance.Domain.Models.Offre", "IdOffreNavigation")
                        .WithMany("CompetenceOffres")
                        .HasForeignKey("IdOffreNavigationId");

                    b.Navigation("IdCompetenceNavigation");

                    b.Navigation("IdOffreNavigation");
                });

            modelBuilder.Entity("Freelance.Domain.Models.ComptenceDmExpertise", b =>
                {
                    b.HasOne("Freelance.Domain.Models.Competence", "IdCompetenceNavigation")
                        .WithMany("ComptenceDmExpertises")
                        .HasForeignKey("IdCompetenceNavigationId");

                    b.HasOne("Freelance.Domain.Models.DomaineExpertise", "IdDmexpertiseNavigation")
                        .WithMany("ComptenceDmExpertises")
                        .HasForeignKey("IdDmexpertiseNavigationId");

                    b.Navigation("IdCompetenceNavigation");

                    b.Navigation("IdDmexpertiseNavigation");
                });

            modelBuilder.Entity("Freelance.Domain.Models.CondidatComp", b =>
                {
                    b.HasOne("Freelance.Domain.Models.Competence", "IdCompNavigation")
                        .WithMany("CondidatComps")
                        .HasForeignKey("IdCompNavigationId");

                    b.HasOne("Freelance.Domain.Models.Candidat", "IdCondNavigation")
                        .WithMany("CondidatComps")
                        .HasForeignKey("IdCondNavigationId");

                    b.Navigation("IdCompNavigation");

                    b.Navigation("IdCondNavigation");
                });

            modelBuilder.Entity("Freelance.Domain.Models.ConsultaionProfil", b =>
                {
                    b.HasOne("Freelance.Domain.Models.Candidat", "IdCondidatNavigation")
                        .WithMany("ConsultaionProfils")
                        .HasForeignKey("IdCondidatNavigationId");

                    b.HasOne("Freelance.Domain.Models.Entreprise", "IdEntrepriseNavigation")
                        .WithMany("ConsultaionProfils")
                        .HasForeignKey("IdEntrepriseNavigationId");

                    b.Navigation("IdCondidatNavigation");

                    b.Navigation("IdEntrepriseNavigation");
                });

            modelBuilder.Entity("Freelance.Domain.Models.Experience", b =>
                {
                    b.HasOne("Freelance.Domain.Models.Candidat", "IdCondidatNavigation")
                        .WithMany("Experiences")
                        .HasForeignKey("IdCondidatNavigationId");

                    b.Navigation("IdCondidatNavigation");
                });

            modelBuilder.Entity("Freelance.Domain.Models.Formation", b =>
                {
                    b.HasOne("Freelance.Domain.Models.Candidat", "IdCondidatNavigation")
                        .WithMany("Formations")
                        .HasForeignKey("IdCondidatNavigationId");

                    b.Navigation("IdCondidatNavigation");
                });

            modelBuilder.Entity("Freelance.Domain.Models.Messagerie", b =>
                {
                    b.HasOne("Freelance.Domain.Models.Candidat", "Expediteur")
                        .WithMany("Messageries")
                        .HasForeignKey("ExpediteurId");

                    b.HasOne("Freelance.Domain.Models.Entreprise", "ExpediteurNavigation")
                        .WithMany("Messageries")
                        .HasForeignKey("ExpediteurNavigationId");

                    b.Navigation("Expediteur");

                    b.Navigation("ExpediteurNavigation");
                });

            modelBuilder.Entity("Freelance.Domain.Models.Projet", b =>
                {
                    b.HasOne("Freelance.Domain.Models.Candidat", "IdCondidatNavigation")
                        .WithMany("Projets")
                        .HasForeignKey("IdCondidatNavigationId");

                    b.Navigation("IdCondidatNavigation");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Freelance.Domain.Models.Candidat", b =>
                {
                    b.Navigation("CondidatComps");

                    b.Navigation("ConsultaionProfils");

                    b.Navigation("Experiences");

                    b.Navigation("Formations");

                    b.Navigation("Messageries");

                    b.Navigation("Projets");
                });

            modelBuilder.Entity("Freelance.Domain.Models.Competence", b =>
                {
                    b.Navigation("CompetenceOffres");

                    b.Navigation("ComptenceDmExpertises");

                    b.Navigation("CondidatComps");
                });

            modelBuilder.Entity("Freelance.Domain.Models.DomaineExpertise", b =>
                {
                    b.Navigation("ComptenceDmExpertises");
                });

            modelBuilder.Entity("Freelance.Domain.Models.Entreprise", b =>
                {
                    b.Navigation("ConsultaionProfils");

                    b.Navigation("Messageries");
                });

            modelBuilder.Entity("Freelance.Domain.Models.Offre", b =>
                {
                    b.Navigation("CompetenceOffres");
                });
#pragma warning restore 612, 618
        }
    }
}
