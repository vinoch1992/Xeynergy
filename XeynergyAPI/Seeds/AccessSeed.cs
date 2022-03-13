using System.Linq;
using XeynergyAPI.Contexts;
using XeynergyAPI.Models;

public static class AccessSeed
{
    public static void Seed(this AccessContext dbContext)
    {
        if (!dbContext.AccessRules.Any())
        {
            dbContext.AccessRules.Add(new AccessRule
            {
                RuleName = "ReadOnly",
                Permission = false,
            });

            dbContext.AccessRules.Add(new AccessRule
            {
                RuleName = "ReadAndWrite",
                Permission = true,
            });

            dbContext.AccessRules.Add(new AccessRule
            {
                RuleName = "FullAccess",
                Permission = true,
            });

            dbContext.SaveChanges();
        }

        if (!dbContext.UserGroups.Any())
        {
            dbContext.UserGroups.Add(new UserGroup
            {
                GroupName = "Student",
                AccessRuleRefId = 1,
            });

            dbContext.UserGroups.Add(new UserGroup
            {
                GroupName = "Teacher",
                AccessRuleRefId = 2,
            });

            dbContext.UserGroups.Add(new UserGroup
            {
                GroupName = "Staff",
                AccessRuleRefId = 3,
            });

            dbContext.SaveChanges();
        }
    }
}