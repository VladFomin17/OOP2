using OOP6.src.exception;

namespace OOP6.Src.Subject;

/// <summary>
/// Класс, представляющий ЖЭК (жилищно-эксплуатационную контору).
/// Содержит информацию о районе, жильцах, оплатах, тарифах и сотрудниках.
/// </summary>
public class HousingDepartment
{
    /// <summary>
    /// Количество созданных объектов класса HousingDepartment.
    /// </summary>
    public static int ObjectCount { get; private set; }
    
    /// <summary>
    /// Район обслуживания ЖЭК.
    /// </summary>
    public string District { get; set; }

    /// <summary>
    /// Номер ЖЭК.
    /// </summary>
    public int HousingDepartmentNumber { get; set; }

    /// <summary>
    /// Массив жильцов.
    /// </summary>
    private Resident[] _residents;

    /// <summary>
    /// Получает или задаёт массив жильцов.
    /// Проверяет корректность количества оплативших жильцов.
    /// </summary>
    public Resident[] Residents
    {
        get => _residents;
        set
        {
            if (_paidResidentsCount > value.Length)
                throw new InvalidPaymentCountException(_paidResidentsCount, value.Length);
            _residents = value;
        }
    }

    /// <summary>
    /// Количество жильцов, оплативших услуги.
    /// </summary>
    private int _paidResidentsCount;

    /// <summary>
    /// Получает или задаёт количество оплативших жильцов.
    /// Значение не может превышать общее количество жильцов.
    /// </summary>
    public int PaidResidentsCount
    {
        get => _paidResidentsCount;
        set
        {
            if (value > _residents.Length)
                throw new InvalidPaymentCountException(value, _residents.Length);
            _paidResidentsCount = value;
        }
    }

    /// <summary>
    /// Тариф на обслуживание.
    /// </summary>
    public double Tariff { get; set; }
    
    /// <summary>
    /// Баланс ЖЭК.
    /// </summary>
    public decimal Balance { get; set; }

    /// <summary>
    /// Количество сотрудников.
    /// </summary>
    public int EmployeeCount { get; set; }

    /// <summary>
    /// Конструктор без параметров.
    /// Инициализирует объект значениями по умолчанию.
    /// </summary>
    public HousingDepartment()
    {
        District = "Не указан";
        HousingDepartmentNumber = 0;
        _residents = new Resident[0];
        _paidResidentsCount = 0;
        Tariff = 0;
        Balance = 0;
        EmployeeCount = 0;

        ObjectCount++;
    }
    /// <summary>
    /// Конструктор с указанием района.
    /// </summary>
    /// <param name="district">Район обслуживания.</param>
    public HousingDepartment(string district) : this()
    {
        District = district;
    }

    /// <summary>
    /// Конструктор с указанием района и номера ЖЭК.
    /// </summary>
    /// <param name="district">Район обслуживания.</param>
    /// <param name="housingDepartmentNumber">Номер ЖЭК.</param>
    public HousingDepartment(string district, int housingDepartmentNumber) 
        : this(district)
    {
        HousingDepartmentNumber = housingDepartmentNumber;
    }

    /// <summary>
    /// Конструктор с полной инициализацией всех полей.
    /// </summary>
    /// <param name="district">Район обслуживания.</param>
    /// <param name="housingDepartmentNumber">Номер ЖЭК.</param>
    /// <param name="residents">Массив жильцов.</param>
    /// <param name="paidResidentsCount">Количество оплативших жильцов.</param>
    /// <param name="tariff">Тариф.</param>
    /// <param name="balance">Баланс.</param>
    /// <param name="employeeCount">Количество сотрудников.</param>
    public HousingDepartment(
        string district,
        int housingDepartmentNumber,
        Resident[] residents,
        int paidResidentsCount,
        double tariff,
        decimal balance,
        int employeeCount
    ) : this(district, housingDepartmentNumber)
    {
        Residents = residents;
        PaidResidentsCount = paidResidentsCount;
        Tariff = tariff;
        Balance = balance;
        EmployeeCount = employeeCount;
    }

    
    /// <summary>
    /// Возвращает строковое представление департамента.
    /// </summary>
    /// <returns>Информация о департаменте.</returns>
    public override string ToString()
    {
        return
            $"Район: {District}\n" +
            $"Номер ЖЭК: {HousingDepartmentNumber}\n" +
            $"Номер ЖЭК HEX: {GetHousingDepartmentNumberHex()}\n" +
            $"Количество жильцов: {Residents.Length}\n" +
            $"Количество оплативших жильцов: {PaidResidentsCount}\n" +
            $"Тариф: {Tariff}\n" +
            $"Баланс: {Balance}\n" +
            $"Количество работников: {EmployeeCount}\n" +
            $"Количество созданных объектов: {ObjectCount}\n";
    }

    /// <summary>
    /// Возвращает информацию о всех жильцах.
    /// </summary>
    /// <returns>Строка с информацией о жильцах.</returns>
    public string GetInfoAboutResidents()
    {
        string info = "";

        foreach (Resident resident in Residents)
        {
            info += resident.ToString();
        }

        return info;
    }

    /// <summary>
    /// Возвращает номер департамента в шестнадцатеричном формате.
    /// </summary>
    /// <returns>HEX-представление номера.</returns>
    public string GetHousingDepartmentNumberHex()
    {
        return HousingDepartmentNumber.ToString("X");
    }

    /// <summary>
    /// Возвращает информацию о жильце по индексу.
    /// </summary>
    /// <param name="index">Индекс жильца.</param>
    /// <returns>Информация о жильце.</returns>
    /// <exception cref="HousingDepartmentIndexOutOfRangeException">
    /// Выбрасывается, если индекс вне диапазона.
    /// </exception>
    public string GetResidentInfoByIndex(int index)
    {
        if (index < 0 || index >= _residents.Length)
        {
            throw new HousingDepartmentIndexOutOfRangeException(index, _residents.Length);
        }

        return _residents[index].ToString();
    }
}