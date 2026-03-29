using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP6.Src.Subject;

namespace OOP6.src;

/// <summary>
/// Класс для измерения производительности различных структур данных.
/// Позволяет сравнивать операции вставки и выборки (последовательной и случайной)
/// для хэш-таблицы и массива.
/// </summary>
public class PerformanceMeter
{
    /// <summary>
    /// Объект для измерения времени выполнения операций.
    /// </summary>
    private static Stopwatch stopwatch = new Stopwatch();

    /// <summary>
    /// Генератор случайных чисел.
    /// </summary>
    private static Random rnd = new Random();

    /// <summary>
    /// Размер тестовой выборки.
    /// </summary>
    private const int size = 100_000;

    /// <summary>
    /// Список для хранения результатов выборки.
    /// </summary>
    public static List<HousingDepartment> HousingDepartmentList { get; private set; }
        = new List<HousingDepartment>();

    /// <summary>
    /// Хэш-таблица для тестирования.
    /// </summary>
    private static HousingDepartmentHashtable hashtable =
        new HousingDepartmentHashtable();

    /// <summary>
    /// Массив для тестирования.
    /// </summary>
    private static HousingDepartment[] housingDepartments =
        new HousingDepartment[size];

    /// <summary>
    /// Измеряет время добавления элементов в хэш-таблицу.
    /// </summary>
    /// <returns>Время выполнения в миллисекундах.</returns>
    public static int InsertInHashtable()
    {
        hashtable = new HousingDepartmentHashtable();

        stopwatch.Reset();
        stopwatch.Start();

        for (int i = 0; i < size; i++)
        {
            hashtable.AddRandomByKey(i);
        }

        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }

    /// <summary>
    /// Измеряет время заполнения массива случайными объектами.
    /// </summary>
    /// <returns>Время выполнения в миллисекундах.</returns>
    public static int InsertInArray()
    {
        stopwatch.Reset();
        stopwatch.Start();

        for (int i = 0; i < size; i++)
        {
            housingDepartments[i] =
                HousingDepartmentRandomGenerator.CreateRandomHousingDepartment(i);
        }

        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }

    /// <summary>
    /// Измеряет время последовательной выборки элементов из хэш-таблицы.
    /// </summary>
    /// <returns>Время выполнения в миллисекундах.</returns>
    public static int HashtableSelectSequential()
    {
        HousingDepartmentList.Clear();
        InsertInHashtable();

        stopwatch.Reset();
        stopwatch.Start();

        foreach (DictionaryEntry entry in hashtable.Table)
        {
            HousingDepartmentList.Add((HousingDepartment)entry.Value);
        }

        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }

    /// <summary>
    /// Измеряет время последовательной выборки элементов из массива.
    /// </summary>
    /// <returns>Время выполнения в миллисекундах.</returns>
    public static int ArraySelectSequential()
    {
        HousingDepartmentList.Clear();

        stopwatch.Reset();
        stopwatch.Start();

        for (int i = 0; i < size; i++)
        {
            HousingDepartmentList.Add(housingDepartments[i]);
        }

        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }

    /// <summary>
    /// Измеряет время случайной выборки элементов из хэш-таблицы.
    /// </summary>
    /// <returns>Время выполнения в миллисекундах.</returns>
    public static int HashtableSelectRandom()
    {
        HousingDepartmentList.Clear();
        InsertInHashtable();

        var values = new List<HousingDepartment>();
        foreach (DictionaryEntry entry in hashtable.Table)
        {
            values.Add((HousingDepartment)entry.Value);
        }

        stopwatch.Reset();
        stopwatch.Start();

        for (int i = 0; i < size; i++)
        {
            HousingDepartmentList.Add(values[rnd.Next(values.Count)]);
        }

        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }

    /// <summary>
    /// Измеряет время случайной выборки элементов из массива.
    /// </summary>
    /// <returns>Время выполнения в миллисекундах.</returns>
    public static int ArraySelectRandom()
    {
        HousingDepartmentList.Clear();

        stopwatch.Reset();
        stopwatch.Start();

        for (int i = 0; i < size; i++)
        {
            HousingDepartmentList.Add(
                housingDepartments[rnd.Next(size - 1)]
            );
        }

        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }
}