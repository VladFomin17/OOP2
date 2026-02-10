using OOP2.Src.Subject;

namespace OOP2.src;

public static class ResidentRandomGenerator
{
    private static readonly Random rnd = new Random();

    private static readonly string[] names =
    {
        "Иванов", "Петров", "Сидоров", "Смирнов", "Кузнецов",
        "Попов", "Васильев", "Новиков", "Фёдоров", "Морозов"
    };

    public static Resident CreateRandomResident()
    {
        return new Resident(
            rnd.Next(1, 100),
            names[rnd.Next(names.Length)]
        );
    }
}
