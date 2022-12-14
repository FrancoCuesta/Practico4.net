// <auto-generated />
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Practico4Context))]
    [Migration("20220906224626_direciones")]
    partial class direciones
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataAccessLayer.Models.direcciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("calle")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("id_Persona")
                        .HasColumnType("int");

                    b.Property<long>("numero")
                        .HasColumnType("bigint");

                    b.Property<string>("observasiones")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("personasId_Persona")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("personasId_Persona");

                    b.ToTable("direcciones");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Personas", b =>
                {
                    b.Property<int>("Id_Persona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Persona"), 1L, 1);

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id_Persona");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("DataAccessLayer.Models.direcciones", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Personas", "personas")
                        .WithMany("Direcciones")
                        .HasForeignKey("personasId_Persona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("personas");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Personas", b =>
                {
                    b.Navigation("Direcciones");
                });
#pragma warning restore 612, 618
        }
    }
}
