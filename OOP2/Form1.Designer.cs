namespace OOP2;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        key = new System.Windows.Forms.DataGridViewTextBoxColumn();
        District = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ResidentsAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
        PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Tariff = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
        EmployeeCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
        label8 = new System.Windows.Forms.Label();
        exitButton = new System.Windows.Forms.Button();
        prevButton = new System.Windows.Forms.Button();
        lvMeasure = new System.Windows.Forms.ListView();
        collectionName = new System.Windows.Forms.ColumnHeader();
        timeInsert = new System.Windows.Forms.ColumnHeader();
        randomAccessTime = new System.Windows.Forms.ColumnHeader();
        seqAccessTime = new System.Windows.Forms.ColumnHeader();
        measureButton = new System.Windows.Forms.Button();
        next = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        tbFunction = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        functionArguementInput = new System.Windows.Forms.NumericUpDown();
        label6 = new System.Windows.Forms.Label();
        calculateFunction = new System.Windows.Forms.Button();
        displayTimeButton = new System.Windows.Forms.Button();
        label9 = new System.Windows.Forms.Label();
        tbTime = new System.Windows.Forms.TextBox();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)functionArguementInput).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(3, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(525, 47);
        label1.TabIndex = 0;
        label1.Text = "Лабораторная работа 6";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // key
        // 
        key.HeaderText = "Ключ (Номер ЖЭКа)";
        key.MinimumWidth = 6;
        key.Name = "key";
        key.Width = 125;
        // 
        // District
        // 
        District.HeaderText = "Район";
        District.MinimumWidth = 6;
        District.Name = "District";
        District.Width = 125;
        // 
        // ResidentsAmount
        // 
        ResidentsAmount.HeaderText = "Количество жильцов";
        ResidentsAmount.MinimumWidth = 6;
        ResidentsAmount.Name = "ResidentsAmount";
        ResidentsAmount.Width = 125;
        // 
        // PaidAmount
        // 
        PaidAmount.HeaderText = "Количество оплативших";
        PaidAmount.MinimumWidth = 6;
        PaidAmount.Name = "PaidAmount";
        PaidAmount.Width = 125;
        // 
        // Tariff
        // 
        Tariff.HeaderText = "Тариф";
        Tariff.MinimumWidth = 6;
        Tariff.Name = "Tariff";
        Tariff.Width = 125;
        // 
        // Balance
        // 
        Balance.HeaderText = "Баланс";
        Balance.MinimumWidth = 6;
        Balance.Name = "Balance";
        Balance.Width = 125;
        // 
        // EmployeeCount
        // 
        EmployeeCount.HeaderText = "Количество сотрудников";
        EmployeeCount.MinimumWidth = 6;
        EmployeeCount.Name = "EmployeeCount";
        EmployeeCount.Width = 125;
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label8.Location = new System.Drawing.Point(447, 342);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(165, 28);
        label8.TabIndex = 15;
        label8.Text = "Производительность";
        label8.Visible = false;
        // 
        // exitButton
        // 
        exitButton.Location = new System.Drawing.Point(921, 535);
        exitButton.Name = "exitButton";
        exitButton.Size = new System.Drawing.Size(127, 28);
        exitButton.TabIndex = 16;
        exitButton.Text = "Выход";
        exitButton.UseVisualStyleBackColor = true;
        exitButton.Visible = false;
        exitButton.Click += exit_Click;
        // 
        // prevButton
        // 
        prevButton.Location = new System.Drawing.Point(20, 533);
        prevButton.Name = "prevButton";
        prevButton.Size = new System.Drawing.Size(127, 28);
        prevButton.TabIndex = 17;
        prevButton.Text = "Назад";
        prevButton.UseVisualStyleBackColor = true;
        prevButton.Visible = false;
        prevButton.Click += prev_Click;
        // 
        // lvMeasure
        // 
        lvMeasure.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { collectionName, timeInsert, randomAccessTime, seqAccessTime });
        lvMeasure.Location = new System.Drawing.Point(20, 373);
        lvMeasure.Margin = new System.Windows.Forms.Padding(0);
        lvMeasure.Name = "lvMeasure";
        lvMeasure.Size = new System.Drawing.Size(1028, 156);
        lvMeasure.TabIndex = 20;
        lvMeasure.UseCompatibleStateImageBehavior = false;
        lvMeasure.Visible = false;
        // 
        // collectionName
        // 
        collectionName.Name = "collectionName";
        collectionName.Text = "Коллекция";
        collectionName.Width = 257;
        // 
        // timeInsert
        // 
        timeInsert.Name = "timeInsert";
        timeInsert.Text = "Время вставки";
        timeInsert.Width = 257;
        // 
        // randomAccessTime
        // 
        randomAccessTime.Name = "randomAccessTime";
        randomAccessTime.Text = "Время случайной выборки";
        randomAccessTime.Width = 257;
        // 
        // seqAccessTime
        // 
        seqAccessTime.Name = "seqAccessTime";
        seqAccessTime.Text = "Время последовательной выборки";
        seqAccessTime.Width = 257;
        // 
        // measureButton
        // 
        measureButton.Location = new System.Drawing.Point(462, 535);
        measureButton.Name = "measureButton";
        measureButton.Size = new System.Drawing.Size(127, 28);
        measureButton.TabIndex = 21;
        measureButton.Text = "Измерить";
        measureButton.UseVisualStyleBackColor = true;
        measureButton.Visible = false;
        measureButton.Click += OnMeasureClick;
        // 
        // next
        // 
        next.Anchor = System.Windows.Forms.AnchorStyles.Top;
        next.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        next.Location = new System.Drawing.Point(144, 203);
        next.Margin = new System.Windows.Forms.Padding(0);
        next.Name = "next";
        next.Size = new System.Drawing.Size(242, 65);
        next.TabIndex = 4;
        next.Text = "Далее";
        next.UseVisualStyleBackColor = true;
        next.Click += button1_Click;
        // 
        // label2
        // 
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        label2.Location = new System.Drawing.Point(3, 124);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(525, 79);
        label2.TabIndex = 1;
        label2.Text = "Вариант 4 - ЖЭК";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Dock = System.Windows.Forms.DockStyle.Fill;
        label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        label3.Location = new System.Drawing.Point(3, 86);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(525, 38);
        label3.TabIndex = 2;
        label3.Text = "Выполнили: Федоров, Фомин";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.Dock = System.Windows.Forms.DockStyle.Fill;
        label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        label4.Location = new System.Drawing.Point(3, 47);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(525, 39);
        label4.TabIndex = 3;
        label4.Text = "Группа 24ВП1";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.1695906F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.83041F));
        tableLayoutPanel1.Controls.Add(label2, 2, 3);
        tableLayoutPanel1.Controls.Add(label3, 2, 2);
        tableLayoutPanel1.Controls.Add(label4, 2, 1);
        tableLayoutPanel1.Controls.Add(label1, 2, 0);
        tableLayoutPanel1.Controls.Add(next, 0, 4);
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.782608F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.217392F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235F));
        tableLayoutPanel1.Size = new System.Drawing.Size(531, 439);
        tableLayoutPanel1.TabIndex = 22;
        // 
        // tbFunction
        // 
        tbFunction.Location = new System.Drawing.Point(20, 57);
        tbFunction.Multiline = true;
        tbFunction.Name = "tbFunction";
        tbFunction.ReadOnly = true;
        tbFunction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        tbFunction.Size = new System.Drawing.Size(439, 172);
        tbFunction.TabIndex = 23;
        tbFunction.Visible = false;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label5.Location = new System.Drawing.Point(155, 31);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(168, 23);
        label5.TabIndex = 24;
        label5.Text = "Вычисление функции";
        label5.Visible = false;
        // 
        // functionArguementInput
        // 
        functionArguementInput.Location = new System.Drawing.Point(121, 259);
        functionArguementInput.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
        functionArguementInput.Name = "functionArguementInput";
        functionArguementInput.Size = new System.Drawing.Size(143, 27);
        functionArguementInput.TabIndex = 25;
        functionArguementInput.Visible = false;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(20, 261);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(84, 25);
        label6.TabIndex = 26;
        label6.Text = "Аргумент";
        label6.Visible = false;
        // 
        // calculateFunction
        // 
        calculateFunction.Location = new System.Drawing.Point(292, 259);
        calculateFunction.Name = "calculateFunction";
        calculateFunction.Size = new System.Drawing.Size(166, 26);
        calculateFunction.TabIndex = 27;
        calculateFunction.Text = "Вычислить";
        calculateFunction.UseVisualStyleBackColor = true;
        calculateFunction.Visible = false;
        calculateFunction.Click += OnCalculateClick;
        // 
        // displayTimeButton
        // 
        displayTimeButton.Location = new System.Drawing.Point(744, 259);
        displayTimeButton.Name = "displayTimeButton";
        displayTimeButton.Size = new System.Drawing.Size(181, 26);
        displayTimeButton.TabIndex = 32;
        displayTimeButton.Text = "Показать время";
        displayTimeButton.UseVisualStyleBackColor = true;
        displayTimeButton.Visible = false;
        displayTimeButton.Click += OnTimeDisplay;
        // 
        // label9
        // 
        label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label9.Location = new System.Drawing.Point(744, 31);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(181, 23);
        label9.TabIndex = 29;
        label9.Text = "Отображение времени";
        label9.Visible = false;
        // 
        // tbTime
        // 
        tbTime.Location = new System.Drawing.Point(609, 57);
        tbTime.Multiline = true;
        tbTime.Name = "tbTime";
        tbTime.ReadOnly = true;
        tbTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        tbTime.Size = new System.Drawing.Size(439, 172);
        tbTime.TabIndex = 28;
        tbTime.Visible = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(1068, 574);
        Controls.Add(displayTimeButton);
        Controls.Add(label9);
        Controls.Add(tbTime);
        Controls.Add(calculateFunction);
        Controls.Add(label6);
        Controls.Add(functionArguementInput);
        Controls.Add(label5);
        Controls.Add(tbFunction);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(measureButton);
        Controls.Add(lvMeasure);
        Controls.Add(prevButton);
        Controls.Add(exitButton);
        Controls.Add(label8);
        Location = new System.Drawing.Point(15, 15);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Text = "ЖЭК";
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)functionArguementInput).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button displayTimeButton;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox tbTime;

    private System.Windows.Forms.Button calculateFunction;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.NumericUpDown functionArguementInput;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.TextBox tbFunction;

    private System.Windows.Forms.Button prevButton;

    private System.Windows.Forms.Button exitButton;

    private System.Windows.Forms.DataGridViewTextBoxColumn District;
    private System.Windows.Forms.DataGridViewTextBoxColumn ResidentsAmount;
    private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmount;
    private System.Windows.Forms.DataGridViewTextBoxColumn Tariff;
    private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCount;

    private System.Windows.Forms.DataGridViewTextBoxColumn key;
    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.DataGridView objectGrid;

    private System.Windows.Forms.Label label1;


    #endregion

    private System.Windows.Forms.ListView lvMeasure;
    private System.Windows.Forms.ColumnHeader collectionName;
    private System.Windows.Forms.ColumnHeader timeInsert;
    private System.Windows.Forms.ColumnHeader randomAccessTime;
    private System.Windows.Forms.ColumnHeader seqAccessTime;
    private System.Windows.Forms.Button measureButton;
    private Button next;
    private System.Windows.Forms.Label label2;
    private Label label3;
    private Label label4;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
}