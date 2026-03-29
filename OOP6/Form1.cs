using OOP6.Src.Subject;
using OOP6.Src.util;
using System;
using System.Collections;
using System.Diagnostics.Contracts;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Windows.Forms;
using OOP6.src;

namespace OOP6;

/// <summary>
/// Главная форма приложения.
/// Отвечает за взаимодействие пользователя с системой управления ЖЭК.
/// </summary>
public partial class Form1 : Form
{
    /// <summary>Начальная высота окна.</summary>
    const int START_WINDOW_HEIGHT = 451;
    
    /// <summary>Начальная ширина окна.</summary>
    const int START_WINDOW_WIDTH = 531;
        
    /// <summary>Основная высота окна.</summary>
    const int MAIN_WINDOW_HEIGHT = 621;
    
    /// <summary>Основная ширина окна.</summary>
    const int MAIN_WINDOW_WIDTH = 1086;

    /// <summary>
    /// Хэш-таблица для хранения объектов типа HousingDepartment.
    /// </summary>
    private HousingDepartmentHashtable _hashtable;

    /// <summary>
    /// Слушатель событий хэш-таблицы, используемый для отображения сообщений в интерфейсе.
    /// </summary>
    private HashtableEventListener _listener;
    
    /// <summary>
    /// Источник токена отмены для управления асинхронной задачей отображения времени.
    /// </summary>
    private CancellationTokenSource _cts;
    
    /// <summary>
    /// Флаг, указывающий, выполняется ли в данный момент отображение времени.
    /// </summary>
    private bool _isRunning = false;

    /// <summary>
    /// Конструктор формы. Инициализирует компоненты и задаёт начальные размеры окна.
    /// </summary>
    public Form1()
    {
        InitializeComponent();
        Size = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        MaximumSize = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        MinimumSize = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        lvMeasure.View = View.Details;
    }

    /// <summary>
    /// Обработчик нажатия кнопки перехода к основному интерфейсу.
    /// Изменяет размеры окна и отображает элементы управления.
    /// </summary>
    private void button1_Click(object sender, EventArgs e)
    {
        tableLayoutPanel1.Visible = false;
        label1.Visible = false;
        label2.Visible = false;
        label3.Visible = false;
        label4.Visible = false;
        next.Visible = false;
        Size = new Size(MAIN_WINDOW_WIDTH, MAIN_WINDOW_HEIGHT);
        MaximumSize = new Size(MAIN_WINDOW_WIDTH, MAIN_WINDOW_HEIGHT);
        MinimumSize = new Size(MAIN_WINDOW_WIDTH, MAIN_WINDOW_HEIGHT); 
        label5.Visible = true;
        label6.Visible = true;
        exitButton.Visible = true;
        lvMeasure.Visible = true;
        label8.Visible = true;
        prevButton.Visible = true;
        measureButton.Visible = true;
        tbFunction.Visible = true;
        tbTime.Visible = true;
        displayTimeButton.Visible = true;
        calculateFunction.Visible = true;
        functionArguementInput.Visible = true;
        label9.Visible = true;
    }

    /// <summary>
    /// Обработчик кнопки возврата к начальному экрану.
    /// Скрывает основные элементы и возвращает исходный размер окна.
    /// </summary>
    private void prev_Click(object sender, EventArgs e)
    {
        tableLayoutPanel1.Visible = true;
        label1.Visible = true;
        label2.Visible = true;
        label3.Visible = true;
        label4.Visible = true;
        next.Visible = true;
        Size = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        MaximumSize = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        MinimumSize = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT); 
        label5.Visible = false;
        label6.Visible = false;
        exitButton.Visible = false;
        lvMeasure.Visible = false;
        label8.Visible = false;
        prevButton.Visible = false;
        measureButton.Visible = false;
        tbFunction.Visible = false;
        tbTime.Visible = false;
        displayTimeButton.Visible = false;
        calculateFunction.Visible = false;
        label9.Visible = false;
        functionArguementInput.Visible = false;
    }

    /// <summary>
    /// Обработчик кнопки выхода из приложения.
    /// Закрывает форму.
    /// </summary>
    private void exit_Click(object sender, EventArgs e)
    {
        Close();
    }

    /// <summary>
    /// Асинхронный обработчик измерения производительности.
    /// Выполняет операции вставки и выборки для хэш-таблицы и массива,
    /// выводя результаты в ListView.
    /// </summary>
    private async void OnMeasureClick(object sender, EventArgs e)
    {
        measureButton.Enabled = false;
        measureButton.Text = "Загрузка...";
        lvMeasure.Items.Clear();

        var (hashResults, arrayResults) = await Task.Run(() =>
        {
            var hashResults = new
            {
                Insert = PerformanceMeter.InsertInHashtable().ToString(),
                Seq = PerformanceMeter.HashtableSelectSequential().ToString(),
                Rand = PerformanceMeter.HashtableSelectRandom().ToString()
            };

            var arrayResults = new
            {
                Insert = PerformanceMeter.InsertInArray().ToString(),
                Seq = PerformanceMeter.ArraySelectSequential().ToString(),
                Rand = PerformanceMeter.ArraySelectRandom().ToString()
            };

            return (hashResults, arrayResults);
        });

        ListViewItem itemHash = new ListViewItem("Хэш-таблица");
        itemHash.SubItems.AddRange(new[] { hashResults.Insert, hashResults.Seq, hashResults.Rand });
        lvMeasure.Items.Add(itemHash);

        ListViewItem itemArray = new ListViewItem("Массив");
        itemArray.SubItems.AddRange(new[] { arrayResults.Insert, arrayResults.Seq, arrayResults.Rand });
        lvMeasure.Items.Add(itemArray);

        measureButton.Text = "Измерить";
        measureButton.Enabled = true;
    }

    /// <summary>
    /// Асинхронный обработчик вычисления функции.
    /// Вычисляет значение экспоненты e^x и отображает результат в текстовом поле.
    /// </summary>
    private async void OnCalculateClick(object sender, EventArgs e)
    {
        calculateFunction.Enabled = false;
        calculateFunction.Text = "Вычисление...";

        int X = (int)functionArguementInput.Value;
        
        tbFunction.Text = "f(x) = eˣ" + Environment.NewLine + $"x = {X}" + Environment.NewLine;
        await FunctionCalculator.Exponent(X, tbFunction);
        calculateFunction.Text = "Рассчитать функцию";
        calculateFunction.Enabled = true;
    }

    /// <summary>
    /// Асинхронный обработчик отображения системного времени.
    /// Позволяет запускать и останавливать обновление времени с использованием CancellationToken.
    /// </summary>
    private async void OnTimeDisplay(object sender, EventArgs e)
    {
        if (!_isRunning)
        {
            _cts = new CancellationTokenSource();
            _isRunning = true;
            displayTimeButton.Text = "Остановить";

            try
            {
                await TimeService.ShowTimeAsync(
                    time => tbTime.Text = time,
                    _cts.Token);
            }
            catch (TaskCanceledException)
            {
            }
        }
        else
        {
            _cts.Cancel();
            _isRunning = false;
            displayTimeButton.Text = "Показать время";
        }
    }
}