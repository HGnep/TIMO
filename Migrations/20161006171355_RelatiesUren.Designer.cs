using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TIMO.data;

namespace C.Migrations
{
    [DbContext(typeof(TimoDbContext))]
    [Migration("20161006171355_RelatiesUren")]
    partial class RelatiesUren
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("TIMO.Entities.Relatie", b =>
                {
                    b.Property<int>("RelatieId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achternaam")
                        .IsRequired();

                    b.Property<DateTime>("Geboortedatum");

                    b.Property<int>("Huisnummer");

                    b.Property<string>("Klas");

                    b.Property<string>("Postcode")
                        .IsRequired();

                    b.Property<string>("Straat")
                        .IsRequired();

                    b.Property<string>("Toevoeging");

                    b.Property<string>("Tussenvoegsel");

                    b.Property<string>("Voornaam");

                    b.Property<string>("Woonplaats")
                        .IsRequired();

                    b.HasKey("RelatieId");

                    b.ToTable("Relaties");
                });

            modelBuilder.Entity("TIMO.Entities.Uur", b =>
                {
                    b.Property<int>("UurId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Begintijd");

                    b.Property<DateTime>("Eindtijd");

                    b.Property<int>("RelatieId");

                    b.HasKey("UurId");

                    b.HasIndex("RelatieId");

                    b.ToTable("Uren");
                });

            modelBuilder.Entity("TIMO.Entities.Uur", b =>
                {
                    b.HasOne("TIMO.Entities.Relatie", "Relatie")
                        .WithMany()
                        .HasForeignKey("RelatieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
