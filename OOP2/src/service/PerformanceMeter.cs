using OOP2.Src.Subject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.src;

public class PerformanceMeter
{
    private static Stopwatch stopwatch = new Stopwatch();
    private static Random rnd = new Random();

    private const int size = 100_000;

    // Для сохранения выборки
    public static List<HousingDepartment> HousingDepartmentList { get; private set; }
        = new List<HousingDepartment>();

    private static HousingDepartmentHashtable hashtable =
        new HousingDepartmentHashtable();

    private static HousingDepartment[] housingDepartments =
        new HousingDepartment[size];
    
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