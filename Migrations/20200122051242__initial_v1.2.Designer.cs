﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SignalR_Vuejs__Demo.Models;

namespace SignalR_Vuejs__Demo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200122051242__initial_v1.2")]
    partial class _initial_v12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SignalR_Vuejs__Demo.Models.PredZapBD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DATE");

                    b.Property<string>("EDIT");

                    b.Property<string>("FIO");

                    b.Property<string>("LEADING");

                    b.Property<string>("TIME");

                    b.Property<string>("WINDOW");

                    b.HasKey("Id");

                    b.ToTable("PredZapBD");
                });

            modelBuilder.Entity("SignalR_Vuejs__Demo.Models.Times", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Times");
                });

            modelBuilder.Entity("SignalR_Vuejs__Demo.Models.windows", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Windows");
                });
#pragma warning restore 612, 618
        }
    }
}
