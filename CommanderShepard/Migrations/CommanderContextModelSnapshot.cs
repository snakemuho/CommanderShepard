﻿// <auto-generated />
using CommanderShepard.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CommanderShepard.Migrations
{
    [DbContext(typeof(CommanderContext))]
    partial class CommanderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CommanderShepard.Models.Command", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("HowTo")
                        .IsRequired()
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Line")
                        .IsRequired()
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Commands");
                });
#pragma warning restore 612, 618
        }
    }
}
