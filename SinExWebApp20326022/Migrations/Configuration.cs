namespace SinExWebApp20326022.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SinExWebApp20326022.Models.SinExDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SinExWebApp20326022.Models.SinExDatabaseContext context)
        {
            // Add package type data.
            context.PackageTypes.AddOrUpdate(
                p => p.PackageTypeID,
                new PackageType { PackageTypeID = 1, Type = "Envelope", Description = "for correspondence and documents only with no commercial value" },
                new PackageType { PackageTypeID = 2, Type = "Pak", Description = "for flat, non-breakable articles including heavy documents" },
                new PackageType { PackageTypeID = 3, Type = "Tube", Description = "for larger documents, such as blueprints, which should be rolled rather than folded" },
                new PackageType { PackageTypeID = 4, Type = "Box", Description = "for bulky items, such as electronic parts and textile samples" },
                new PackageType { PackageTypeID = 5, Type = "Customer", Description = "for packaging provided by customer" }
                );

            // Add Currency data
            context.Currencies.AddOrUpdate(
                p => p.CurrencyCode,
                new Currency { CurrencyCode = "CNY", ExchangeRate = 1.00m},
                new Currency { CurrencyCode = "HKD", ExchangeRate = 1.13m },
                new Currency { CurrencyCode = "MOP", ExchangeRate = 1.16m },
                new Currency { CurrencyCode = "TWD", ExchangeRate = 4.56m }
                );

            // Add Destination data
            context.Destinations.AddOrUpdate(
           p => p.DestinationID,
           new Destination { DestinationID = 1, City = "Beijing", ProvinceCode = "BJ", CurrencyCode = "CNY" },
           new Destination { DestinationID = 2, City = "Changchun", ProvinceCode = "JL", CurrencyCode = "CNY" },
           new Destination { DestinationID = 3, City = "Changsha", ProvinceCode = "HN", CurrencyCode = "CNY" },
           new Destination { DestinationID = 4, City = "Chengdu", ProvinceCode = "SC", CurrencyCode = "CNY" },
           new Destination { DestinationID = 5, City = "Chongqing", ProvinceCode = "CQ", CurrencyCode = "CNY" },
           new Destination { DestinationID = 6, City = "Fuzhou", ProvinceCode = "JX", CurrencyCode = "CNY" },
           new Destination { DestinationID = 7, City = "Golmud", ProvinceCode = "QH", CurrencyCode = "CNY" },
           new Destination { DestinationID = 8, City = "Guangzhou", ProvinceCode = "GD", CurrencyCode = "CNY" },
           new Destination { DestinationID = 9, City = "Guiyang", ProvinceCode = "GZ", CurrencyCode = "CNY" },
           new Destination { DestinationID = 10, City = "Haikou", ProvinceCode = "HI", CurrencyCode = "CNY" },
           new Destination { DestinationID = 11, City = "Hailar", ProvinceCode = "NM", CurrencyCode = "CNY" },
           new Destination { DestinationID = 12, City = "Hangzhou", ProvinceCode = "ZJ", CurrencyCode = "CNY" },
           new Destination { DestinationID = 13, City = "Harbin", ProvinceCode = "HL", CurrencyCode = "CNY" },
           new Destination { DestinationID = 14, City = "Hefei", ProvinceCode = "AH", CurrencyCode = "CNY" },
           new Destination { DestinationID = 15, City = "Hohhot", ProvinceCode = "NM", CurrencyCode = "CNY" },
           new Destination { DestinationID = 16, City = "Hong Kong", ProvinceCode = "HK", CurrencyCode = "HKD" },
           new Destination { DestinationID = 17, City = "Hulun Buir", ProvinceCode = "NM", CurrencyCode = "CNY" },
           new Destination { DestinationID = 18, City = "Jinan", ProvinceCode = "SD", CurrencyCode = "CNY" },
           new Destination { DestinationID = 19, City = "Kashi", ProvinceCode = "XJ", CurrencyCode = "CNY" },
           new Destination { DestinationID = 20, City = "Kunming", ProvinceCode = "YN", CurrencyCode = "CNY" },
           new Destination { DestinationID = 21, City = "Lanzhou", ProvinceCode = "GS", CurrencyCode = "CNY" },
           new Destination { DestinationID = 22, City = "Lhasa", ProvinceCode = "XZ", CurrencyCode = "CNY" },
           new Destination { DestinationID = 23, City = "Macau", ProvinceCode = "MC", CurrencyCode = "CNY" },
           new Destination { DestinationID = 24, City = "Nanchang", ProvinceCode = "JX", CurrencyCode = "CNY" },
           new Destination { DestinationID = 25, City = "Nanjing", ProvinceCode = "JS", CurrencyCode = "CNY" },
           new Destination { DestinationID = 26, City = "Nanning", ProvinceCode = "JX", CurrencyCode = "CNY" },
           new Destination { DestinationID = 27, City = "Qiqihar", ProvinceCode = "HL", CurrencyCode = "CNY" },
           new Destination { DestinationID = 28, City = "Shanghai", ProvinceCode = "SH", CurrencyCode = "CNY" }
           );

            // Add service type data.
            context.ServiceTypes.AddOrUpdate(
                p => p.ServiceTypeID,
                new ServiceType { ServiceTypeID = 1, Type = "Same Day", CutoffTime = "10:00 a.m.", DeliveryTime = "Same day" },
                new ServiceType { ServiceTypeID = 2, Type = "Next Day 10:30", CutoffTime = "3:00 p.m.", DeliveryTime = "Next day 10:30 a.m." },
                new ServiceType { ServiceTypeID = 3, Type = "Next Day 12:00", CutoffTime = "6:00 p.m.", DeliveryTime = "Next day 12:00 p.m." },
                new ServiceType { ServiceTypeID = 4, Type = "Next Day 15:00", CutoffTime = "9:00 p.m.", DeliveryTime = "Next day 15:00 p.m." },
                new ServiceType { ServiceTypeID = 5, Type = "2nd Day", CutoffTime = "", DeliveryTime = "5:00 p.m. second business day" },
                new ServiceType { ServiceTypeID = 6, Type = "Ground", CutoffTime = "", DeliveryTime = "1 to 5 business days" }
                );

            // Add service and package type fees.
            context.ServicePackageFees.AddOrUpdate(
                p => p.ServicePackageFeeID,
                // Same Day
                new ServicePackageFee { ServicePackageFeeID = 1, Fee = 160, MinimumFee = 160, ServiceTypeID = 1, PackageTypeID = 1 }, // Envelope
                new ServicePackageFee { ServicePackageFeeID = 2, Fee = 100, MinimumFee = 160, ServiceTypeID = 1, PackageTypeID = 2 }, // Pak
                new ServicePackageFee { ServicePackageFeeID = 3, Fee = 100, MinimumFee = 160, ServiceTypeID = 1, PackageTypeID = 3 }, // Tube
                new ServicePackageFee { ServicePackageFeeID = 4, Fee = 110, MinimumFee = 160, ServiceTypeID = 1, PackageTypeID = 4 }, // Box
                new ServicePackageFee { ServicePackageFeeID = 5, Fee = 110, MinimumFee = 160, ServiceTypeID = 1, PackageTypeID = 5 }, // Customer
                                                                                                                                      // Next Day 10:30
                new ServicePackageFee { ServicePackageFeeID = 6, Fee = 140, MinimumFee = 140, ServiceTypeID = 2, PackageTypeID = 1 }, // Envelope
                new ServicePackageFee { ServicePackageFeeID = 7, Fee = 90, MinimumFee = 140, ServiceTypeID = 2, PackageTypeID = 2 }, // Pak
                new ServicePackageFee { ServicePackageFeeID = 8, Fee = 90, MinimumFee = 140, ServiceTypeID = 2, PackageTypeID = 3 }, // Tube
                new ServicePackageFee { ServicePackageFeeID = 9, Fee = 99, MinimumFee = 100, ServiceTypeID = 2, PackageTypeID = 4 }, // Box
                new ServicePackageFee { ServicePackageFeeID = 10, Fee = 99, MinimumFee = 140, ServiceTypeID = 2, PackageTypeID = 5 }, // Customer
                                                                                                                                      // Next Day 12:00
                new ServicePackageFee { ServicePackageFeeID = 11, Fee = 130, MinimumFee = 130, ServiceTypeID = 3, PackageTypeID = 1 }, // Envelope
                new ServicePackageFee { ServicePackageFeeID = 12, Fee = 80, MinimumFee = 130, ServiceTypeID = 3, PackageTypeID = 2 }, // Pak
                new ServicePackageFee { ServicePackageFeeID = 13, Fee = 80, MinimumFee = 130, ServiceTypeID = 3, PackageTypeID = 3 }, // Tube
                new ServicePackageFee { ServicePackageFeeID = 14, Fee = 88, MinimumFee = 130, ServiceTypeID = 3, PackageTypeID = 4 }, // Box
                new ServicePackageFee { ServicePackageFeeID = 15, Fee = 88, MinimumFee = 130, ServiceTypeID = 3, PackageTypeID = 5 }, // Customer
                                                                                                                                      // Next Day 15:00
                new ServicePackageFee { ServicePackageFeeID = 16, Fee = 120, MinimumFee = 120, ServiceTypeID = 4, PackageTypeID = 1 }, // Envelope
                new ServicePackageFee { ServicePackageFeeID = 17, Fee = 70, MinimumFee = 120, ServiceTypeID = 4, PackageTypeID = 2 }, // Pak
                new ServicePackageFee { ServicePackageFeeID = 18, Fee = 70, MinimumFee = 120, ServiceTypeID = 4, PackageTypeID = 3 }, // Tube
                new ServicePackageFee { ServicePackageFeeID = 19, Fee = 77, MinimumFee = 120, ServiceTypeID = 4, PackageTypeID = 4 }, // Box
                new ServicePackageFee { ServicePackageFeeID = 20, Fee = 77, MinimumFee = 120, ServiceTypeID = 4, PackageTypeID = 5 }, // Customer
                                                                                                                                      // 2nd Day
                new ServicePackageFee { ServicePackageFeeID = 21, Fee = 50, MinimumFee = 50, ServiceTypeID = 5, PackageTypeID = 1 }, // Envelope
                new ServicePackageFee { ServicePackageFeeID = 22, Fee = 50, MinimumFee = 50, ServiceTypeID = 5, PackageTypeID = 2 }, // Pak
                new ServicePackageFee { ServicePackageFeeID = 23, Fee = 50, MinimumFee = 50, ServiceTypeID = 5, PackageTypeID = 3 }, // Tube
                new ServicePackageFee { ServicePackageFeeID = 24, Fee = 55, MinimumFee = 55, ServiceTypeID = 5, PackageTypeID = 4 }, // Box
                new ServicePackageFee { ServicePackageFeeID = 25, Fee = 55, MinimumFee = 55, ServiceTypeID = 5, PackageTypeID = 5 }, // Customer
                                                                                                                                     // Ground
                new ServicePackageFee { ServicePackageFeeID = 26, Fee = 25, MinimumFee = 25, ServiceTypeID = 6, PackageTypeID = 1 },// Envelope
                new ServicePackageFee { ServicePackageFeeID = 27, Fee = 25, MinimumFee = 25, ServiceTypeID = 6, PackageTypeID = 2 }, // Pak
                new ServicePackageFee { ServicePackageFeeID = 28, Fee = 25, MinimumFee = 25, ServiceTypeID = 6, PackageTypeID = 3 }, // Tube
                new ServicePackageFee { ServicePackageFeeID = 29, Fee = 30, MinimumFee = 30, ServiceTypeID = 6, PackageTypeID = 4 }, // Box
                new ServicePackageFee { ServicePackageFeeID = 30, Fee = 30, MinimumFee = 30, ServiceTypeID = 6, PackageTypeID = 5 }  // Customer
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
