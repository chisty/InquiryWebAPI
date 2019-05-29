using System;
using System.Collections.Generic;
using System.Text;
using InquiryWebAPI.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace InquiryWebAPI.Tests
{
    public class FakeDbContextFactory
    {
        private const string SuccessStatus = "Success";
        private const string FailedStatus = "Failed";
        private const string CanceledStatus = "Canceled";
        public AppDbContext GetInMemoryDbCotext()
        {
            var option = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("Test_CustomerInquiry_Database").Options;

            var dbContext = new AppDbContext(option);

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            Seed(dbContext);

            return dbContext;
        }


        private static void Seed(AppDbContext dbContext)
        {
            var customers = new List<Customers>()
            {
                new Customers
                {
                    CustomerId = 1,
                    Name = "Tony Stark",
                    Email = "tony@gmail.com",
                    Mobile = 123456798                                            
                },
                new Customers
                {
                    CustomerId = 2,
                    Name = "Ahmed Chisty",
                    Email = "chisty@gmail.com",
                    Mobile = 123456798
                }
            };

            var transactions = new List<Transactions>()
            {
                new Transactions()
                {
                    Id = 1,
                    CustomerId = 1,
                    Amount = 150.50M,
                    CurrencyCode = "USD",
                    Date = new DateTime(2018, 12, 31, 14, 30, 0),
                    Status = SuccessStatus
                },
                new Transactions()
                {
                    Id = 2,
                    CustomerId = 1,
                    Amount = 350M,
                    CurrencyCode = "BDT",
                    Date = new DateTime(2019, 03, 31, 10, 30, 0),
                    Status = SuccessStatus
                },
                new Transactions()
                {
                    Id = 3,
                    CustomerId = 1,
                    Amount = 200.25M,
                    CurrencyCode = "USD",
                    Date = new DateTime(2019, 01, 15, 20, 10, 0),
                    Status = FailedStatus
                },
                new Transactions()
                {
                    Id = 4,
                    CustomerId = 2,
                    Amount = 550.50M,
                    CurrencyCode = "BDT",
                    Date = new DateTime(2016, 12, 31, 14, 30, 0),
                    Status = CanceledStatus
                },
                new Transactions()
                {
                    Id = 5,
                    CustomerId = 2,
                    Amount = 860M,
                    CurrencyCode = "JPY",
                    Date = new DateTime(2017, 06, 15, 18, 30, 0),
                    Status = SuccessStatus
                },
                new Transactions()
                {
                    Id = 6,
                    CustomerId = 2,
                    Amount = 12005M,
                    CurrencyCode = "BDT",
                    Date = new DateTime(2019, 01, 15, 20, 10, 0),
                    Status = FailedStatus
                },
                new Transactions()
                {
                    Id = 7,
                    CustomerId = 2,
                    Amount = 125M,
                    CurrencyCode = "THB",
                    Date = new DateTime(2018, 06, 15, 18, 30, 0),
                    Status = SuccessStatus
                },
                new Transactions()
                {
                    Id = 8,
                    CustomerId = 2,
                    Amount = 215M,
                    CurrencyCode = "SGD",
                    Date = new DateTime(2019, 01, 01, 20, 10, 0),
                    Status = CanceledStatus
                }
            };

            dbContext.Customers.AddRange(customers);
            dbContext.Transactions.AddRange(transactions);

            dbContext.SaveChanges();
        }
    }
}
