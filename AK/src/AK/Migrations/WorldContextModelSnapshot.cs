using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Ak.Models;

namespace AK.Migrations
{
    [DbContext(typeof(WorldContext))]
    partial class WorldContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ak.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Details");

                    b.Property<DateTime>("EventDate");

                    b.Property<string>("ImageSource");

                    b.Property<string>("Latitude");

                    b.Property<string>("Longitude");

                    b.Property<string>("MusicGender");

                    b.Property<string>("Name");

                    b.Property<string>("Place");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("AK.Models.MusicGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("EventId");

                    b.Property<string>("Name");

                    b.Property<string>("SourceImage");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("AK.Models.MusicGroup", b =>
                {
                    b.HasOne("Ak.Models.Event")
                        .WithMany()
                        .HasForeignKey("EventId");
                });
        }
    }
}
