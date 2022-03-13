using System.Linq;
using XeynergyAPI.Contexts;
using XeynergyAPI.Models;

public static class PersonSeed
{
    public static void Seed(this PersonContext dbContext)
    {
        if (!dbContext.Admins.Any())
        {
            dbContext.Admins.Add(new Admin
            {
                FirstName = "Vinoch",
                LastName = "Selvarathinam",
                EmailAddress = "vinoch@gmail.com",
                Privilege = "FullAccess",
            });

            dbContext.Admins.Add(new Admin
            {
                FirstName = "David",
                LastName = "John",
                EmailAddress = "david@gmail.com",
                Privilege = "ReadOnly",
            });

            dbContext.SaveChanges();
        }

        if (!dbContext.Users.Any())
        {
            dbContext.Users.Add(new User
            {
                FirstName = "Jana",
                LastName = "Venice",
                EmailAddress = "jena@gmail.com",
                AttachedCustomerId = 100,
                UserGroupRefId = 1,
            });

            dbContext.Users.Add(new User
            {
                FirstName = "Bravo",
                LastName = "Kevin",
                EmailAddress = "bravo@gmail.com",
                AttachedCustomerId = 101,
                UserGroupRefId = 2,
            });

            dbContext.SaveChanges();
        }
    }
}