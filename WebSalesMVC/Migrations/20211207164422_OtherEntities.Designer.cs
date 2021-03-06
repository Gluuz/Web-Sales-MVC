// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebSalesMVC.Data;

namespace WebSalesMVC.Migrations
{
    [DbContext(typeof(WebSalesMVCContext))]
    [Migration("20211207164422_OtherEntities")]
    partial class OtherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebSalesMVC.Models.DepartmentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DepartmentModel");
                });

            modelBuilder.Entity("WebSalesMVC.Models.SalesRecordModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("SellerId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("WebSalesMVC.Models.SellerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int?>("DeparmentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DeparmentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("WebSalesMVC.Models.SalesRecordModel", b =>
                {
                    b.HasOne("WebSalesMVC.Models.SellerModel", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("WebSalesMVC.Models.SellerModel", b =>
                {
                    b.HasOne("WebSalesMVC.Models.DepartmentModel", "Deparment")
                        .WithMany("Sellers")
                        .HasForeignKey("DeparmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
