﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using T11ASP.NetProject.Models;

namespace T11ASP.NetProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210413075604_seeddataandalotothers")]
    partial class seeddataandalotothers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("T11ASP.NetProject.Models.Cart", b =>
                {
                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartId", "CustomerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("T11ASP.NetProject.Models.CartDetails", b =>
                {
                    b.Property<int>("ItemNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ItemNumber");

                    b.HasIndex("ProductId");

                    b.HasIndex("CartId", "CustomerId");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("T11ASP.NetProject.Models.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SessionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustomerId = "zavierlim",
                            Address = "NUS",
                            Name = "zavier",
                            Password = "123"
                        });
                });

            modelBuilder.Entity("T11ASP.NetProject.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("T11ASP.NetProject.Models.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateofPurchase")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("T11ASP.NetProject.Models.ProductComment", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("ProductId", "CustomerId", "OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderId");

                    b.ToTable("ProductComment");
                });

            modelBuilder.Entity("T11ASP.NetProject.Models.ProductList", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("ProductList");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "Adobe Photoshop is a raster graphics and digital art editor developed  for Windows and macOS. The software has become the industry standard not only in raster graphics editing, but in digital art as a whole. Photoshop can edit and compose raster images in multiple layers and supports masks, alpha compositing and several color models including RGB, CMYK, CIELAB, spot color, and duotone. In addition to raster graphics, Photoshop with plug-ins supports editing or rendering text and vector graphics as well as 3D graphics and video. ",
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Adobe_Photoshop_CC_icon.svg/1200px-Adobe_Photoshop_CC_icon.svg.png",
                            ProductName = "Adobe Photoshop",
                            Rating = 2.5,
                            ShortDescription = "Adobe Photoshop is a raster graphics and digital art editor developed for Windows and macOS",
                            UnitPrice = 150.0
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "Adobe Illustrator is a vector graphics editor and design program. Adobe Illustrator is the industry standard design app that lets you capture your creative vision with shapes, color, effects, and typography. Work across desktop and mobile devices and quickly create beautiful designs that can go anywhere—print, web and apps, video and animations, and more.",
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/Adobe_Illustrator_CC_icon.svg/1280px-Adobe_Illustrator_CC_icon.svg.png",
                            ProductName = "Adobe Illustrator",
                            Rating = 3.0,
                            ShortDescription = "Adobe Illustrator is a vector graphics editor and design program",
                            UnitPrice = 180.0
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "Adobe Lightroom is a creative image organization and image manipulation software developed by Adobe Inc. as part of the Creative Cloud subscription family. Its primary uses include importing/saving, viewing, organizing, tagging, editing, and sharing large numbers of digital images. Lightroom's editing functions include white balance, tone, presence, tone curve, HSL, color grading, detail, lens corrections, and calibration manipulation, as well as transformation, spot removal, red eye correction, graduated filters, radial filters, and adjustment brushing.",
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Adobe_InDesign_CC_icon.svg/1280px-Adobe_InDesign_CC_icon.svg.png",
                            ProductName = "Adobe Lightroom",
                            Rating = 1.5,
                            ShortDescription = "Adobe Lightroom is a creative image organization and image manipulation software developed by Adobe Inc. as part of the Creative Cloud subscription family. ",
                            UnitPrice = 240.0
                        },
                        new
                        {
                            ProductId = 4,
                            Description = "Adobe InDesign is a desktop publishing and typesetting software application produced by Adobe Inc.. It can be used to create works such as posters, flyers, brochures, magazines, newspapers, presentations, books and e-books. InDesign can also publish content suitable for tablet devices in conjunction with Adobe Digital Publishing Suite. Graphic designers and production artists are the principal users, creating and laying out periodical publications, posters, and print media. It also supports export to EPUB and SWF formats to create e-books and digital publications, including digital magazines, and content suitable for consumption on tablet computers. In addition, InDesign supports XML, style sheets, and other coding markup, making it suitable for exporting tagged text content for use in other digital and online formats.",
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Adobe_InDesign_CC_icon.svg/1280px-Adobe_InDesign_CC_icon.svg.png",
                            ProductName = "Adobe InDesign",
                            Rating = 2.0,
                            ShortDescription = "Adobe InDesign is a desktop publishing and typesetting software application produced by Adobe Inc.",
                            UnitPrice = 88.0
                        },
                        new
                        {
                            ProductId = 5,
                            Description = "Adobe XD is a vector-based user experience design tool for web apps and mobile apps, developed and published by Adobe Inc. It is available for macOS and Windows, although there are versions for iOS and Android to help preview the result of work directly on mobile devices. Adobe XD supports website wireframing and creating click-through prototypes.",
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c2/Adobe_XD_CC_icon.svg/1280px-Adobe_XD_CC_icon.svg.png",
                            ProductName = "Adobe XD",
                            Rating = 3.0,
                            ShortDescription = "Adobe XD is a vector-based user experience design tool for web apps and mobile apps, developed and published by Adobe Inc",
                            UnitPrice = 125.0
                        },
                        new
                        {
                            ProductId = 6,
                            Description = "Adobe Premiere Pro is a timeline-based video editing software application developed by Adobe Inc. and published as part of the Adobe Creative Cloud licensing program. First launched in 2003, Adobe Premiere Pro is a successor of Adobe Premiere (first launched in 1991). It is geared towards professional video editing, while its sibling, Adobe Premiere Elements, targets the consumer market.",
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Adobe_InDesign_CC_icon.svg/1280px-Adobe_InDesign_CC_icon.svg.png",
                            ProductName = "Adobe Premier Pro",
                            Rating = 1.5,
                            ShortDescription = "Adobe Premiere Pro is a timeline-based video editing software application developed by Adobe Inc. and published as part of the Adobe Creative Cloud licensing program. ",
                            UnitPrice = 240.0
                        });
                });

            modelBuilder.Entity("T11ASP.NetProject.Models.Cart", b =>
                {
                    b.HasOne("T11ASP.NetProject.Models.Customer", "Customer")
                        .WithMany("Cart")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("T11ASP.NetProject.Models.CartDetails", b =>
                {
                    b.HasOne("T11ASP.NetProject.Models.ProductList", "ProductList")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("T11ASP.NetProject.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId", "CustomerId");

                    b.Navigation("Cart");

                    b.Navigation("ProductList");
                });

            modelBuilder.Entity("T11ASP.NetProject.Models.OrderDetails", b =>
                {
                    b.HasOne("T11ASP.NetProject.Models.Orders", "Orders")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("T11ASP.NetProject.Models.ProductList", "ProductList")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("ProductList");
                });

            modelBuilder.Entity("T11ASP.NetProject.Models.Orders", b =>
                {
                    b.HasOne("T11ASP.NetProject.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("T11ASP.NetProject.Models.ProductComment", b =>
                {
                    b.HasOne("T11ASP.NetProject.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("T11ASP.NetProject.Models.Orders", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("T11ASP.NetProject.Models.ProductList", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("T11ASP.NetProject.Models.Customer", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("T11ASP.NetProject.Models.Orders", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("T11ASP.NetProject.Models.ProductList", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
