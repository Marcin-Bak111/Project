// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Przelicznik.Database.Context;

namespace Przelicznik.Database.Migrations
{
    [DbContext(typeof(ConverterDbContext))]
    partial class ConverterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Przelicznik.Database.Context.Entities.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Symbol")
                        .HasColumnType("TEXT");

                    b.Property<int>("UnitTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UnitTypeId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Przelicznik.Database.Context.Entities.UnitConverter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("ConvertValue")
                        .HasColumnType("REAL");

                    b.Property<int>("SourceUnit")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SourceUnitId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetUnit")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetUnitId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("UnitConverters");
                });

            modelBuilder.Entity("Przelicznik.Database.Context.Entities.UnitType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UnitTypes");
                });

            modelBuilder.Entity("Przelicznik.Database.Context.Entities.Unit", b =>
                {
                    b.HasOne("Przelicznik.Database.Context.Entities.UnitType", "UnitType123")
                        .WithMany()
                        .HasForeignKey("UnitTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnitType123");
                });
#pragma warning restore 612, 618
        }
    }
}
