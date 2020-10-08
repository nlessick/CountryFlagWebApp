﻿// <auto-generated />
using CountryFlagWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CountryFlagWebApp.Migrations
{
    [DbContext(typeof(CountryContext))]
    partial class CountryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CountryFlagWebApp.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = "indoor",
                            Name = "Indoor"
                        },
                        new
                        {
                            CategoryID = "outdoor",
                            Name = "Outdoor"
                        });
                });

            modelBuilder.Entity("CountryFlagWebApp.Models.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LogoImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("GameID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = "aus",
                            CategoryID = "outdoor",
                            GameID = "paralympics",
                            LogoImage = "Austria.png",
                            Name = "Austria"
                        },
                        new
                        {
                            CountryID = "braz",
                            CategoryID = "outdoor",
                            GameID = "summer",
                            LogoImage = "Brazil.png",
                            Name = "Brazil"
                        },
                        new
                        {
                            CountryID = "can",
                            CategoryID = "indoor",
                            GameID = "winter",
                            LogoImage = "Canada.png",
                            Name = "Canada"
                        },
                        new
                        {
                            CountryID = "chi",
                            CategoryID = "indoor",
                            GameID = "summer",
                            LogoImage = "China.png",
                            Name = "China"
                        },
                        new
                        {
                            CountryID = "cyp",
                            CategoryID = "indoor",
                            GameID = "youth",
                            LogoImage = "Cyprus.png",
                            Name = "Cyprus"
                        },
                        new
                        {
                            CountryID = "fin",
                            CategoryID = "outdoor",
                            GameID = "youth",
                            LogoImage = "Finland.png",
                            Name = "Finland"
                        },
                        new
                        {
                            CountryID = "fra",
                            CategoryID = "indoor",
                            GameID = "youth",
                            LogoImage = "France.png",
                            Name = "France"
                        },
                        new
                        {
                            CountryID = "ger",
                            CategoryID = "indoor",
                            GameID = "summer",
                            LogoImage = "Germany.png",
                            Name = "Germany"
                        },
                        new
                        {
                            CountryID = "gb",
                            CategoryID = "indoor",
                            GameID = "winter",
                            LogoImage = "GreatBritain.png",
                            Name = "Great Britain"
                        },
                        new
                        {
                            CountryID = "ita",
                            CategoryID = "outdoor",
                            GameID = "winter",
                            LogoImage = "Italy.png",
                            Name = "Italy"
                        },
                        new
                        {
                            CountryID = "jam",
                            CategoryID = "outdoor",
                            GameID = "winter",
                            LogoImage = "Jamaica.png",
                            Name = "Jamaica"
                        },
                        new
                        {
                            CountryID = "jap",
                            CategoryID = "outdoor",
                            GameID = "winter",
                            LogoImage = "Japan.png",
                            Name = "Japan"
                        },
                        new
                        {
                            CountryID = "mex",
                            CategoryID = "indoor",
                            GameID = "summer",
                            LogoImage = "Mexico.png",
                            Name = "Mexico"
                        },
                        new
                        {
                            CountryID = "net",
                            CategoryID = "outdoor",
                            GameID = "summer",
                            LogoImage = "Netherlands.png",
                            Name = "Netherlands"
                        },
                        new
                        {
                            CountryID = "pak",
                            CategoryID = "outdoor",
                            GameID = "paralympics",
                            LogoImage = "Pakistan.png",
                            Name = "Pakistan"
                        },
                        new
                        {
                            CountryID = "por",
                            CategoryID = "outdoor",
                            GameID = "youth",
                            LogoImage = "Portugal.png",
                            Name = "Portugal"
                        },
                        new
                        {
                            CountryID = "rus",
                            CategoryID = "indoor",
                            GameID = "youth",
                            LogoImage = "Russia.png",
                            Name = "Russia"
                        },
                        new
                        {
                            CountryID = "slo",
                            CategoryID = "outdoor",
                            GameID = "youth",
                            LogoImage = "Slovakia.png",
                            Name = "Slovakia"
                        },
                        new
                        {
                            CountryID = "swe",
                            CategoryID = "indoor",
                            GameID = "winter",
                            LogoImage = "Sweden.png",
                            Name = "Sweden"
                        },
                        new
                        {
                            CountryID = "tha",
                            CategoryID = "indoor",
                            GameID = "paralympics",
                            LogoImage = "Thailand.png",
                            Name = "Thailand"
                        },
                        new
                        {
                            CountryID = "ukr",
                            CategoryID = "indoor",
                            GameID = "paralympics",
                            LogoImage = "Ukraine.png",
                            Name = "Ukraine"
                        },
                        new
                        {
                            CountryID = "uru",
                            CategoryID = "indoor",
                            GameID = "paralympics",
                            LogoImage = "Uruguay.png",
                            Name = "Uruguay"
                        },
                        new
                        {
                            CountryID = "usa",
                            CategoryID = "outdoor",
                            GameID = "summer",
                            LogoImage = "USA.png",
                            Name = "USA"
                        },
                        new
                        {
                            CountryID = "zim",
                            CategoryID = "outdoor",
                            GameID = "paralympics",
                            LogoImage = "Zimbabwe.png",
                            Name = "Zimbabwe"
                        });
                });

            modelBuilder.Entity("CountryFlagWebApp.Models.Game", b =>
                {
                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameID");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameID = "winter",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameID = "summer",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            GameID = "paralympics",
                            Name = "Paralympics"
                        },
                        new
                        {
                            GameID = "youth",
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("CountryFlagWebApp.Models.Country", b =>
                {
                    b.HasOne("CountryFlagWebApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.HasOne("CountryFlagWebApp.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID");
                });
#pragma warning restore 612, 618
        }
    }
}
