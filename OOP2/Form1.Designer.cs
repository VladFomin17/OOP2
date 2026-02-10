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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        next = new Button();
        label5 = new Label();
        label6 = new Label();
        addButton = new Button();
        removeButton = new Button();
        label7 = new Label();
        objectGrid = new DataGridView();
        key = new DataGridViewTextBoxColumn();
        District = new DataGridViewTextBoxColumn();
        ResidentsAmount = new DataGridViewTextBoxColumn();
        PaidAmount = new DataGridViewTextBoxColumn();
        Tariff = new DataGridViewTextBoxColumn();
        Balance = new DataGridViewTextBoxColumn();
        EmployeeCount = new DataGridViewTextBoxColumn();
        label8 = new Label();
        exitButton = new Button();
        prevButton = new Button();
        keyInput = new NumericUpDown();
        tbEvents = new TextBox();
        lvMeasure = new ListView();
        timeInsert = new ColumnHeader();
        randomAccessTime = new ColumnHeader();
        seqAccessTime = new ColumnHeader();
        collectionName = new ColumnHeader();
        measureButton = new Button();
        ((System.ComponentModel.ISupportInitialize)objectGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)keyInput).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label1.Location = new Point(30, 21);
        label1.Name = "label1";
        label1.Size = new Size(391, 64);
        label1.TabIndex = 0;
        label1.Text = "Лабораторная работа 2";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label2.Location = new Point(30, 85);
        label2.Name = "label2";
        label2.Size = new Size(391, 64);
        label2.TabIndex = 1;
        label2.Text = "Вариант 4 - ЖЭК";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label3.Location = new Point(30, 143);
        label3.Name = "label3";
        label3.Size = new Size(391, 100);
        label3.TabIndex = 2;
        label3.Text = "Выполнили: Федоров, Фомин";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label4.Location = new Point(25, 226);
        label4.Name = "label4";
        label4.Size = new Size(391, 67);
        label4.TabIndex = 3;
        label4.Text = "Группа 24ВП1";
        label4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // next
        // 
        next.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
        next.Location = new Point(139, 352);
        next.Name = "next";
        next.Size = new Size(179, 51);
        next.TabIndex = 4;
        next.Text = "Далее";
        next.UseVisualStyleBackColor = true;
        next.Click += button1_Click;
        // 
        // label5
        // 
        label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label5.Location = new Point(413, 2);
        label5.Name = "label5";
        label5.Size = new Size(80, 28);
        label5.TabIndex = 7;
        label5.Text = "Объекты";
        label5.Visible = false;
        // 
        // label6
        // 
        label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label6.Location = new Point(1046, 2);
        label6.Name = "label6";
        label6.Size = new Size(80, 28);
        label6.TabIndex = 8;
        label6.Text = "События";
        label6.Visible = false;
        // 
        // addButton
        // 
        addButton.Location = new Point(427, 397);
        addButton.Name = "addButton";
        addButton.Size = new Size(419, 32);
        addButton.TabIndex = 9;
        addButton.Text = "Добавить объект";
        addButton.UseVisualStyleBackColor = true;
        addButton.Visible = false;
        addButton.Click += OnAddClick;
        // 
        // removeButton
        // 
        removeButton.Location = new Point(852, 395);
        removeButton.Name = "removeButton";
        removeButton.Size = new Size(445, 32);
        removeButton.TabIndex = 10;
        removeButton.Text = "Удалить объект";
        removeButton.UseVisualStyleBackColor = true;
        removeButton.Visible = false;
        removeButton.Click += OnRemoveClick;
        // 
        // label7
        // 
        label7.Location = new Point(46, 401);
        label7.Name = "label7";
        label7.Size = new Size(117, 22);
        label7.TabIndex = 12;
        label7.Text = "Номер ЖЭКа";
        label7.Visible = false;
        // 
        // objectGrid
        // 
        objectGrid.AllowUserToAddRows = false;
        objectGrid.AllowUserToDeleteRows = false;
        objectGrid.AllowUserToResizeColumns = false;
        objectGrid.AllowUserToResizeRows = false;
        objectGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        objectGrid.Columns.AddRange(new DataGridViewColumn[] { key, District, ResidentsAmount, PaidAmount, Tariff, Balance, EmployeeCount });
        objectGrid.Location = new Point(37, 33);
        objectGrid.Name = "objectGrid";
        objectGrid.RowHeadersVisible = false;
        objectGrid.RowHeadersWidth = 51;
        objectGrid.Size = new Size(804, 313);
        objectGrid.TabIndex = 13;
        objectGrid.Text = "dataGridView1";
        objectGrid.Visible = false;
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
        label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label8.Location = new Point(608, 459);
        label8.Name = "label8";
        label8.Size = new Size(165, 28);
        label8.TabIndex = 15;
        label8.Text = "Производительность";
        label8.Visible = false;
        // 
        // exitButton
        // 
        exitButton.Location = new Point(1170, 650);
        exitButton.Name = "exitButton";
        exitButton.Size = new Size(127, 28);
        exitButton.TabIndex = 16;
        exitButton.Text = "Выход";
        exitButton.UseVisualStyleBackColor = true;
        exitButton.Visible = false;
        exitButton.Click += exit_Click;
        // 
        // prevButton
        // 
        prevButton.Location = new Point(37, 650);
        prevButton.Name = "prevButton";
        prevButton.Size = new Size(127, 28);
        prevButton.TabIndex = 17;
        prevButton.Text = "Назад";
        prevButton.UseVisualStyleBackColor = true;
        prevButton.Visible = false;
        prevButton.Click += prev_Click;
        // 
        // keyInput
        // 
        keyInput.Location = new Point(169, 399);
        keyInput.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        keyInput.Name = "keyInput";
        keyInput.Size = new Size(241, 27);
        keyInput.TabIndex = 18;
        keyInput.Visible = false;
        // 
        // tbEvents
        // 
        tbEvents.Location = new Point(865, 30);
        tbEvents.Multiline = true;
        tbEvents.Name = "tbEvents";
        tbEvents.ReadOnly = true;
        tbEvents.ScrollBars = ScrollBars.Vertical;
        tbEvents.Size = new Size(413, 313);
        tbEvents.TabIndex = 19;
        // 
        // lvMeasure
        // 
        lvMeasure.Columns.AddRange(new ColumnHeader[] { collectionName, timeInsert, randomAccessTime, seqAccessTime });
        lvMeasure.Location = new Point(37, 490);
        lvMeasure.Name = "lvMeasure";
        lvMeasure.Size = new Size(1260, 156);
        lvMeasure.TabIndex = 20;
        lvMeasure.UseCompatibleStateImageBehavior = false;
        lvMeasure.Visible = false;
        // 
        // timeInsert
        // 
        timeInsert.Text = "Время вставки";
        timeInsert.Width = 315;
        // 
        // randomAccessTime
        // 
        randomAccessTime.Text = "Время случайной выборки";
        randomAccessTime.Width = 315;
        // 
        // seqAccessTime
        // 
        seqAccessTime.Text = "Время последовательной выборки";
        seqAccessTime.Width = 315;
        // 
        // collectionName
        // 
        collectionName.Text = "Коллекция";
        collectionName.Width = 315;
        // 
        // measureButton
        // 
        measureButton.Location = new Point(622, 649);
        measureButton.Name = "measureButton";
        measureButton.Size = new Size(127, 28);
        measureButton.TabIndex = 21;
        measureButton.Text = "Измерить";
        measureButton.UseVisualStyleBackColor = true;
        measureButton.Visible = false;
        measureButton.Click += OnMeasureClick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1309, 689);
        Controls.Add(measureButton);
        Controls.Add(lvMeasure);
        Controls.Add(tbEvents);
        Controls.Add(keyInput);
        Controls.Add(prevButton);
        Controls.Add(exitButton);
        Controls.Add(label8);
        Controls.Add(objectGrid);
        Controls.Add(label7);
        Controls.Add(removeButton);
        Controls.Add(addButton);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(next);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Location = new Point(15, 15);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)objectGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)keyInput).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.NumericUpDown keyInput;

    private System.Windows.Forms.Button prevButton;

    private System.Windows.Forms.Button exitButton;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.DataGridViewTextBoxColumn District;
    private System.Windows.Forms.DataGridViewTextBoxColumn ResidentsAmount;
    private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmount;
    private System.Windows.Forms.DataGridViewTextBoxColumn Tariff;
    private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCount;

    private System.Windows.Forms.DataGridViewTextBoxColumn key;
    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.DataGridView objectGrid;

    private System.Windows.Forms.Button removeButton;
    private System.Windows.Forms.TextBox tbEvents;

    private System.Windows.Forms.Button addButton;

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button next;


    #endregion

    private ListView lvMeasure;
    private ColumnHeader collectionName;
    private ColumnHeader timeInsert;
    private ColumnHeader randomAccessTime;
    private ColumnHeader seqAccessTime;
    private Button measureButton;
}