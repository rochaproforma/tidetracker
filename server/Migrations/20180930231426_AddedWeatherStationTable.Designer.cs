﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using server;

namespace server.Migrations
{
    [DbContext(typeof(TideTrackerContext))]
    [Migration("20180930231426_AddedWeatherStationTable")]
    partial class AddedWeatherStationTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TideTracker.WeatherStation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Lat");

                    b.Property<int>("Long");

                    b.Property<string>("Nickname");

                    b.Property<int>("StationId");

                    b.HasKey("Id");

                    b.ToTable("WeatherStations");
                });
#pragma warning restore 612, 618
        }
    }
}
