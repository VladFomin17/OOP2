using OOP2.src;
using OOP2.Src.Subject;
using OOP2.Src.util;
using System;
using System.Collections;
using System.Diagnostics.Contracts;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Windows.Forms;

namespace OOP2;

public partial class Form1 : Form
{
    const int START_WINDOW_HEIGHT = 451;
    const int START_WINDOW_WIDTH = 531;
    const int MAIN_WINDOW_HEIGHT = 736;
    const int MAIN_WINDOW_WIDTH = 1327;

    private HousingDepartmentHashtable _hashtable;

    private HashtableEventListener _listener;

    public Form1()
    {
        InitializeComponent();
        Size = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        MaximumSize = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        MinimumSize = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        _hashtable = new HousingDepartmentHashtable();
        _listener = new HashtableEventListener(_hashtable, tbEvents);
        lvMeasure.View = View.Details;
    }

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
        MinimumSize = new Size(MAIN_WINDOW_WIDTH, MAIN_WINDOW_HEIGHT); label5.Visible = true;
        label7.Visible = true;
        tbEvents.Visible = true;
        label6.Visible = true;
        exitButton.Visible = true;
        objectGrid.Visible = true;
        lvMeasure.Visible = true;
        keyInput.Visible = true;
        label8.Visible = true;
        addButton.Visible = true;
        removeButton.Visible = true;
        prevButton.Visible = true;
        measureButton.Visible = true;
    }

    private void prev_Click(object sender, EventArgs e)
    {
        tableLayoutPanel1.Visible = true;
        label1.Visible = true;
        label2.Visible = true;
        label3.Visible = true;
        label4.Visible = true;
        next.Visible = true;
        Size = new Size(START_WINDOW_WIDTH, START_WINDOW_HEIGHT);
        label5.Visible = false;
        label7.Visible = false;
        tbEvents.Visible = true;
        label6.Visible = false;
        exitButton.Visible = false;
        objectGrid.Visible = false;
        lvMeasure.Visible = false;
        keyInput.Visible = false;
        label8.Visible = false;
        addButton.Visible = false;
        removeButton.Visible = false;
        prevButton.Visible = false;
        measureButton.Visible = false;
    }

    private void exit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void OnAddClick(object sender, EventArgs e)
    {
        try
        {
            int key = (int)keyInput.Value;

            _hashtable.AddRandomByKey(key);
            RefreshObjectGrid();
        }
        catch (Exception exception)
        {
            NativeMessageBox.MessageBox(
                0,
                exception.Message,
                "Ошибка",
                NativeMessageBox.MB_OK | NativeMessageBox.MB_ICONERROR
            );
        }
    }

    private void OnRemoveClick(object sender, EventArgs e)
    {
        try
        {
            int key = (int)keyInput.Value;

            _hashtable.Remove(key);
            RefreshObjectGrid();
        }
        catch (Exception exception)
        {
            NativeMessageBox.MessageBox(
                0,
                exception.Message,
                "Ошибка",
                NativeMessageBox.MB_OK | NativeMessageBox.MB_ICONERROR
            );
        }
    }

    private void RefreshObjectGrid()
    {
        objectGrid.Rows.Clear();

        foreach (DictionaryEntry entry in _hashtable.Table)
        {
            int key = (int)entry.Key;
            HousingDepartment hd = (HousingDepartment)entry.Value;

            objectGrid.Rows.Add(
                key,
                hd.District,
                hd.Residents.Length,
                hd.PaidResidentsCount,
                hd.Tariff,
                hd.Balance,
                hd.EmployeeCount
            );
        }
    }

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
}