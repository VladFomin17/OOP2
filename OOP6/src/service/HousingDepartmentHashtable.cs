using System;
using System.Collections;
using OOP6.src.exception;
using OOP6.Src.Subject;

namespace OOP6.src;

/// <summary>
/// Делегат для обработки событий изменения хэш-таблицы.
/// </summary>
/// <param name="message">Сообщение о выполненной операции.</param>
public delegate void HashtableChanged(string message);

/// <summary>
/// Класс-обёртка над Hashtable для хранения объектов HousingDepartment.
/// Обеспечивает добавление, удаление и получение элементов с обработкой исключений
/// и уведомлением через события.
/// </summary>
public class HousingDepartmentHashtable
{
    /// <summary>
    /// Внутренняя хэш-таблица, хранящая объекты HousingDepartment.
    /// Ключ — номер ЖЭК.
    /// </summary>
    public Hashtable Table { get; }

    /// <summary>
    /// Количество элементов в таблице.
    /// </summary>
    public int Count { get { return Table.Count; } }

    /// <summary>
    /// Событие, возникающее при добавлении элемента.
    /// </summary>
    public event HashtableChanged ItemAdded;

    /// <summary>
    /// Событие, возникающее при удалении элемента.
    /// </summary>
    public event HashtableChanged ItemRemoved;

    /// <summary>
    /// Конструктор. Инициализирует пустую хэш-таблицу.
    /// </summary>
    public HousingDepartmentHashtable()
    {
        Table = new Hashtable();
    }

    /// <summary>
    /// Добавляет объект HousingDepartment в таблицу.
    /// </summary>
    /// <param name="item">Добавляемый объект.</param>
    /// <exception cref="KeyAlreadyExistsException">
    /// Выбрасывается, если элемент с таким ключом уже существует.
    /// </exception>
    public void Add(HousingDepartment item)
    {
        if (Table.ContainsKey(item.HousingDepartmentNumber))
        {
            throw new KeyAlreadyExistsException(item.HousingDepartmentNumber);
        }

        Table.Add(item.HousingDepartmentNumber, item);
        ItemAdded?.Invoke($"Элемент с ключом {item.HousingDepartmentNumber} добавлен." + Environment.NewLine);
    }

    /// <summary>
    /// Создаёт случайный объект HousingDepartment и добавляет его по заданному ключу.
    /// </summary>
    /// <param name="key">Ключ (номер ЖЭК).</param>
    /// <exception cref="KeyAlreadyExistsException">
    /// Выбрасывается, если элемент с таким ключом уже существует.
    /// </exception>
    public void AddRandomByKey(int key)
    {
        if (Table.ContainsKey(key))
        {
            throw new KeyAlreadyExistsException(key);
        }

        Table.Add(key, HousingDepartmentRandomGenerator.CreateRandomHousingDepartment(key));
        ItemAdded?.Invoke($"Элемент с ключом {key} добавлен." + Environment.NewLine);
    }

    /// <summary>
    /// Удаляет элемент из таблицы по ключу.
    /// </summary>
    /// <param name="key">Ключ элемента.</param>
    /// <exception cref="KeyDoesNotExistException">
    /// Выбрасывается, если элемент с таким ключом не найден.
    /// </exception>
    public void Remove(int key)
    {
        if (!Table.ContainsKey(key))
        {
            throw new KeyDoesNotExistException(key);
        }

        Table.Remove(key);
        ItemRemoved?.Invoke($"Элемент с ключом {key} удален." + Environment.NewLine);
    }

    /// <summary>
    /// Получает объект HousingDepartment по ключу.
    /// </summary>
    /// <param name="key">Ключ элемента.</param>
    /// <returns>Объект HousingDepartment.</returns>
    /// <exception cref="KeyDoesNotExistException">
    /// Выбрасывается, если элемент с таким ключом не найден.
    /// </exception>
    public HousingDepartment Get(int key)
    {
        if (!Table.ContainsKey(key))
        {
            throw new KeyDoesNotExistException(key);
        }
        return (HousingDepartment)Table[key];
    }

    /// <summary>
    /// Проверяет наличие элемента в таблице по ключу.
    /// </summary>
    /// <param name="key">Ключ элемента.</param>
    /// <returns>true, если элемент существует; иначе false.</returns>
    public bool Contains(int key)
    {
        return Table.ContainsKey(key);
    }
}