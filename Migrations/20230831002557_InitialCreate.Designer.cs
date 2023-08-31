﻿// <auto-generated />
using JokeApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JokeApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230831002557_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("JokeApp.Models.Joke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("JokeAnswer")
                        .HasColumnType("TEXT");

                    b.Property<string>("JokePrompt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Jokes");
                });
#pragma warning restore 612, 618
        }
    }
}