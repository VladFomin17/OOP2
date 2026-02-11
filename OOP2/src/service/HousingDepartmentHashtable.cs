using OOP2.Src.Subject;
using System;
using System.Collections;
using OOP2.src.exception;

namespace OOP2.src;

public delegate void HashtableChanged(string message);

public class HousingDepartmentHashtable
{
    public Hashtable Table { get; }
    
    public int Count { get { return Table.Count; } }

    public event HashtableChanged ItemAdded;
    public event HashtableChanged ItemRemoved;

    public HousingDepartmentHashtable()
    {
        Table = new Hashtable();
    }

    public void Add(HousingDepartment item)
    {
        if (Table.ContainsKey(item.HousingDepartmentNumber))
        {
            throw new KeyAlreadyExistsException(item.HousingDepartmentNumber);
        }

        Table.Add(item.HousingDepartmentNumber, item);
        ItemAdded?.Invoke($"Элемент с ключом {item.HousingDepartmentNumber} добавлен." + Environment.NewLine);
    }

    public void AddRandomByKey(int key)
    {
        if (Table.ContainsKey(key))
        {
            throw new KeyAlreadyExistsException(key);
        }

        Table.Add(key, HousingDepartmentRandomGenerator.CreateRandomHousingDepartment(key));
        ItemAdded?.Invoke($"Элемент с ключом {key} добавлен." + Environment.NewLine);
    }

    public void Remove(int key)
    {
        if (!Table.ContainsKey(key))
        {
            throw new KeyDoesNotExistException(key);
        }

        Table.Remove(key);
        ItemRemoved?.Invoke($"Элемент с ключом {key} удален." + Environment.NewLine);
    }

    public HousingDepartment Get(int key)
    {
        if (!Table.ContainsKey(key))
        {
            throw new KeyDoesNotExistException(key);
        }
        return (HousingDepartment)Table[key];
    }
    
    public bool Contains(int key)
    {
        return Table.ContainsKey(key);
    }
}