using OOP2.Src.Subject;

namespace OOP2.src;

public static class HousingDepartmentRandomGenerator
{
    private static readonly Random rnd = new Random();

    private static readonly string[] districts =
    {
        "Центральный",
        "Северный",
        "Южный",
        "Западный",
        "Восточный",
        "Ленинский",
        "Октябрьский",
        "Советский",
        "Промышленный",
        "Железнодорожный"
    };

    public static string GetRandomDistrict()
    {
        return districts[rnd.Next(districts.Length)];
    }

    public static int GetRandomResidentCount()
    {
        return rnd.Next(10, 300);
    }

    public static Resident[] GetRandomResidents(int count)
    {
        Resident[] residents = new Resident[count];
        for (int i = 0; i < count; i++)
        {
            residents[i] = ResidentRandomGenerator.CreateRandomResident();
        }
        return residents;
    }

    public static int GetRandomPaidResidentsCount(int totalResidents)
    {
        return rnd.Next(0, totalResidents + 1);
    }

    public static double GetRandomTariff()
    {
        return Math.Round(rnd.NextDouble() * 100 + 50, 2);
    }

    public static decimal GetRandomBalance()
    {
        return Math.Round((decimal)(rnd.NextDouble() * 1_000_000), 2);
    }

    public static int GetRandomEmployeeCount()
    {
        return rnd.Next(5, 80);
    }

    public static HousingDepartment CreateRandomHousingDepartment(int housingDepartmentNumber)
    {
        int residentCount = GetRandomResidentCount();
        Resident[] residents = GetRandomResidents(residentCount);
        int paidResidents = GetRandomPaidResidentsCount(residentCount);

        return new HousingDepartment(
            GetRandomDistrict(),
            housingDepartmentNumber,
            residents,
            paidResidents,
            GetRandomTariff(),
            GetRandomBalance(),
            GetRandomEmployeeCount()
        );
    }
}