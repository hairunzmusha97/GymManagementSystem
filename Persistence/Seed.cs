using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Members.Any()) return;
            
            var Members = new List<Member>
            {
                new Member
                {
                    FirstName = "Shehan",
                    LastName  = "Fernando",
                    DateofBirth = DateTime.UtcNow.AddYears(-27),
                    DateofJoin = DateTime.UtcNow.AddMonths(-2),
                    Description = "",
                    Category = "individual",
                    Duration = "3 Month",
                    Address = "Dehiwala",
                    Telephone="0710987902",
                    Age = 27,
                    Email="shehan.f@gmail.com",
                    Disability=false,
                    EmergencyContact="0778967827",
                    Height="171",
                    Weight="65",
                    Neck="",
                    NIC="973950464v",
                    Gender="Male"
                },
                new Member
                {
                    FirstName = "Janith",
                    LastName  = "Peiris",
                    DateofBirth = DateTime.UtcNow.AddYears(-27),
                    DateofJoin = DateTime.UtcNow.AddMonths(-3),
                    Description = "",
                    Category = "joint",
                    Duration = "6 Month",
                    Address = "Wellawatta",
                    Telephone="0775467234",
                    Age = 27,
                    Email="janithpeiris97@gmail.com",
                    Disability=false,
                    EmergencyContact="0708931809",
                    Height="168",
                    Weight="60",
                    Neck="",
                    NIC="975647389v",
                    Gender="Male"
                },
                new Member
                {
                    FirstName = "Bagya",
                    LastName  = "Perera",
                    DateofBirth = DateTime.UtcNow.AddYears(-26),
                    DateofJoin = DateTime.UtcNow.AddMonths(-1),
                    Description = "",
                    Category = "individual",
                    Duration = "1 Month",
                    Address = "Mount Lavinia",
                    Telephone="0775467234",
                    Age = 26,
                    Email="bagyaofficial98@gmail.com",
                    Disability=false,
                    EmergencyContact="0708931809",
                    Height="160",
                    Weight="60",
                    Neck="",
                    NIC="986732890v",
                    Gender="Female"
                },
                new Member
                {
                    FirstName = "Roger",
                    LastName  = "Ranganathan",
                    DateofBirth = DateTime.UtcNow.AddYears(-40),
                    DateofJoin = DateTime.UtcNow.AddMonths(-1),
                    Description = "",
                    Category = "family",
                    Duration = "3 Month",
                    Address = "Bambalapitiya",
                    Telephone="0775467234",
                    Age = 26,
                    Email="rogerrnathan@gmail.com",
                    Disability=false,
                    EmergencyContact="0708931809",
                    Height="175",
                    Weight="70",
                    Neck="",
                    NIC="842347189v",
                    Gender="Male"
                },
                new Member
                {
                    FirstName = "Maria",
                    LastName  = "Kruskova",
                    DateofBirth = DateTime.UtcNow.AddYears(-20),
                    DateofJoin = DateTime.UtcNow.AddMonths(-1),
                    Description = "",
                    Category = "young adult",
                    Duration = "3 Month",
                    Address = "Rathmalana",
                    Telephone="0775467234",
                    Age = 26,
                    Email="kruskovamaria_russia04@gmail.com",
                    Disability=false,
                    EmergencyContact="0708931809",
                    Height="158",
                    Weight="55",
                    Neck="",
                    NIC="20042318903v",
                    Gender="Female"
                }
            };

            await context.Members.AddRangeAsync(Members);
            await context.SaveChangesAsync();
        }
    }
}