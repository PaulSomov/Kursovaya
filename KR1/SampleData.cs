using System.Linq;
using System.Numerics;
using KR1.Models;

namespace KR1
{
    public static class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Applications.Any())
            {
                context.Applications.AddRange(
                    new Application
                    {
                        ID = 1,
                        FirstName = "John",
                        LastName = "Doe",
                        DateOfBirth = new DateTime(1990, 5, 10),
                        Gender = "Male",
                        Address = "123 Main Street",
                        PhoneNumber = "555-1234",
                        Email = "john.doe@example.com",
                        ApplicationDate = DateTime.Now,
                        Status = "New"
                    },
                    new Application
                    {
                        ID = 2,
                        FirstName = "Jane",
                        LastName = "Smith",
                        DateOfBirth = new DateTime(1985, 10, 15),
                        Gender = "Female",
                        Address = "456 Elm Street",
                        PhoneNumber = "555-5678",
                        Email = "jane.smith@example.com",
                        ApplicationDate = DateTime.Now,
                        Status = "Approved"
                    },
                    new Application
                    {
                        ID = 3,
                        FirstName = "Mike",
                        LastName = "Johnson",
                        DateOfBirth = new DateTime(1992, 8, 20),
                        Gender = "Male",
                        Address = "789 Oak Street",
                        PhoneNumber = "555-9012",
                        Email = "mike.johnson@example.com",
                        ApplicationDate = DateTime.Now,
                        Status = "Rejected"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}