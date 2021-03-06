﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Models;

namespace Travel.Migrations
{
    [DbContext(typeof(TravelContext))]
    partial class TravelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Travel.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("Rating");

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Author = "Author1",
                            City = "Istanbul",
                            Country = "Turkey",
                            Description = "Istanbul is one of the truly great romantic cities; home to a layering of civilization on civilization, of empire built on empire",
                            Rating = 5
                        },
                        new
                        {
                            ReviewId = 2,
                            Author = "Author1",
                            City = "Paris",
                            Country = "France",
                            Description = "Paris is regarded as one of the most dynamic cities in Europe, and for good reason: the city assaults the senses; demanding to be seen, heard, touched, tasted and smelled.",
                            Rating = 4
                        },
                        new
                        {
                            ReviewId = 3,
                            Author = "Author1",
                            City = "Rome",
                            Country = "Italy",
                            Description = "An in depth vacation to one of the most enduring cities in Europe! Rome is the heart of Italy; once the center of the world`s greatest empire, the Eternal City has some of the finest art and architecture to survive from the last 2,000 years.",
                            Rating = 5
                        },
                        new
                        {
                            ReviewId = 4,
                            Author = "Author4",
                            City = "Istanbul",
                            Country = "Turkey",
                            Description = "From the holy sites of Sultanahmet and the 19th-century European elegance of Beyoğlu to the high fashion of Nişantaşı, the vibrant café society of Kadıköy and the football-loving streets of Beşiktaş, it’s easy to see why travelers say that Istanbul isn’t just one city, but many cities within one.",
                            Rating = 5
                        });
                });

            modelBuilder.Entity("Travel.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Token");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
