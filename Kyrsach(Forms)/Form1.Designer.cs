
namespace Kyrsach_Forms_
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronomi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass_serias_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_of_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day_birth_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.greedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.poisk_vklad = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Number_of_Vklad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Open = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Close = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum_of_Vklad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Vklad_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear_2_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToFileVkladToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenVkladToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(1731, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-6, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1895, 800);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1887, 762);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Surname_column,
            this.Name_column,
            this.Patronomi_column,
            this.Pass_serias_column,
            this.Number_of_pass,
            this.Day_birth_column,
            this.Address_column,
            this.telephone_column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1896, 723);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.MinimumWidth = 8;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Surname_column
            // 
            this.Surname_column.HeaderText = "Фамилия";
            this.Surname_column.MinimumWidth = 8;
            this.Surname_column.Name = "Surname_column";
            this.Surname_column.ReadOnly = true;
            this.Surname_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Name_column
            // 
            this.Name_column.HeaderText = "Имя";
            this.Name_column.MinimumWidth = 8;
            this.Name_column.Name = "Name_column";
            this.Name_column.ReadOnly = true;
            this.Name_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Patronomi_column
            // 
            this.Patronomi_column.HeaderText = "Отчество";
            this.Patronomi_column.MinimumWidth = 8;
            this.Patronomi_column.Name = "Patronomi_column";
            this.Patronomi_column.ReadOnly = true;
            this.Patronomi_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Pass_serias_column
            // 
            this.Pass_serias_column.HeaderText = " Серия паспорта";
            this.Pass_serias_column.MinimumWidth = 8;
            this.Pass_serias_column.Name = "Pass_serias_column";
            this.Pass_serias_column.ReadOnly = true;
            this.Pass_serias_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Number_of_pass
            // 
            this.Number_of_pass.HeaderText = "Номер паспорта";
            this.Number_of_pass.MinimumWidth = 8;
            this.Number_of_pass.Name = "Number_of_pass";
            this.Number_of_pass.ReadOnly = true;
            this.Number_of_pass.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Day_birth_column
            // 
            this.Day_birth_column.HeaderText = "Дата рождения";
            this.Day_birth_column.MinimumWidth = 8;
            this.Day_birth_column.Name = "Day_birth_column";
            this.Day_birth_column.ReadOnly = true;
            this.Day_birth_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Address_column
            // 
            this.Address_column.HeaderText = "Адрес";
            this.Address_column.MinimumWidth = 8;
            this.Address_column.Name = "Address_column";
            this.Address_column.ReadOnly = true;
            this.Address_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // telephone_column
            // 
            this.telephone_column.HeaderText = "Телефон";
            this.telephone_column.MinimumWidth = 8;
            this.telephone_column.Name = "telephone_column";
            this.telephone_column.ReadOnly = true;
            this.telephone_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greedToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1881, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // greedToolStripMenuItem
            // 
            this.greedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.ExcelToolStripMenuItem,
            this.очиститьТаблицуToolStripMenuItem});
            this.greedToolStripMenuItem.Name = "greedToolStripMenuItem";
            this.greedToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.greedToolStripMenuItem.Text = "Таблица";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.addToolStripMenuItem.Text = "Добавить клиента";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // ExcelToolStripMenuItem
            // 
            this.ExcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExcelToolStripMenuItem.Image")));
            this.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem";
            this.ExcelToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.ExcelToolStripMenuItem.Text = "Перейти в Excel";
            this.ExcelToolStripMenuItem.Click += new System.EventHandler(this.ExcelToolStripMenuItem_Click_1);
            // 
            // очиститьТаблицуToolStripMenuItem
            // 
            this.очиститьТаблицуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("очиститьТаблицуToolStripMenuItem.Image")));
            this.очиститьТаблицуToolStripMenuItem.Name = "очиститьТаблицуToolStripMenuItem";
            this.очиститьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.очиститьТаблицуToolStripMenuItem.Text = "Очистить таблицу";
            this.очиститьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToFileToolStripMenuItem,
            this.LoadClientsToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveToFileToolStripMenuItem
            // 
            this.SaveToFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToFileToolStripMenuItem.Image")));
            this.SaveToFileToolStripMenuItem.Name = "SaveToFileToolStripMenuItem";
            this.SaveToFileToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.SaveToFileToolStripMenuItem.Text = "Сохранить в файл ";
            this.SaveToFileToolStripMenuItem.Click += new System.EventHandler(this.SaveToFileToolStripMenuItem_Click);
            // 
            // LoadClientsToolStripMenuItem
            // 
            this.LoadClientsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LoadClientsToolStripMenuItem.Image")));
            this.LoadClientsToolStripMenuItem.Name = "LoadClientsToolStripMenuItem";
            this.LoadClientsToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.LoadClientsToolStripMenuItem.Text = "Открыть файл";
            this.LoadClientsToolStripMenuItem.Click += new System.EventHandler(this.LoadClientsToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.poisk_vklad);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.menuStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1887, 762);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вклады";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // poisk_vklad
            // 
            this.poisk_vklad.Location = new System.Drawing.Point(1738, 5);
            this.poisk_vklad.Name = "poisk_vklad";
            this.poisk_vklad.Size = new System.Drawing.Size(150, 31);
            this.poisk_vklad.TabIndex = 2;
            this.poisk_vklad.TextChanged += new System.EventHandler(this.poisk_vklad_TextChanged);
            this.poisk_vklad.Enter += new System.EventHandler(this.poisk_vklad_Enter);
            this.poisk_vklad.Leave += new System.EventHandler(this.poisk_vklad_Leave);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number_of_Vklad,
            this.Column1,
            this.Date_Open,
            this.Date_Close,
            this.Sum_of_Vklad,
            this.Procent,
            this.End_Sum,
            this.Currency});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(3, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1885, 720);
            this.dataGridView2.TabIndex = 1;
            // 
            // Number_of_Vklad
            // 
            this.Number_of_Vklad.FillWeight = 36.6364F;
            this.Number_of_Vklad.HeaderText = "№";
            this.Number_of_Vklad.MinimumWidth = 8;
            this.Number_of_Vklad.Name = "Number_of_Vklad";
            this.Number_of_Vklad.ReadOnly = true;
            this.Number_of_Vklad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 202.3377F;
            this.Column1.HeaderText = "Наименование вклада";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Date_Open
            // 
            this.Date_Open.FillWeight = 202.3377F;
            this.Date_Open.HeaderText = "Дата открытия";
            this.Date_Open.MinimumWidth = 8;
            this.Date_Open.Name = "Date_Open";
            this.Date_Open.ReadOnly = true;
            this.Date_Open.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Date_Close
            // 
            this.Date_Close.FillWeight = 202.3377F;
            this.Date_Close.HeaderText = "Дата закрытия";
            this.Date_Close.MinimumWidth = 8;
            this.Date_Close.Name = "Date_Close";
            this.Date_Close.ReadOnly = true;
            this.Date_Close.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Sum_of_Vklad
            // 
            this.Sum_of_Vklad.FillWeight = 202.3377F;
            this.Sum_of_Vklad.HeaderText = "Сумма вклада";
            this.Sum_of_Vklad.MinimumWidth = 8;
            this.Sum_of_Vklad.Name = "Sum_of_Vklad";
            this.Sum_of_Vklad.ReadOnly = true;
            this.Sum_of_Vklad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Procent
            // 
            this.Procent.FillWeight = 202.3377F;
            this.Procent.HeaderText = "Процентная ставка";
            this.Procent.MinimumWidth = 8;
            this.Procent.Name = "Procent";
            this.Procent.ReadOnly = true;
            this.Procent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // End_Sum
            // 
            this.End_Sum.FillWeight = 202.3377F;
            this.End_Sum.HeaderText = "Рассчёт";
            this.End_Sum.MinimumWidth = 8;
            this.End_Sum.Name = "End_Sum";
            this.End_Sum.ReadOnly = true;
            this.End_Sum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Currency
            // 
            this.Currency.FillWeight = 62.33766F;
            this.Currency.HeaderText = "Валюта";
            this.Currency.MinimumWidth = 8;
            this.Currency.Name = "Currency";
            this.Currency.ReadOnly = true;
            this.Currency.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаToolStripMenuItem,
            this.файлToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1881, 33);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Vklad_ToolStripMenuItem,
            this.перейтиВExcelToolStripMenuItem,
            this.Clear_2_ToolStripMenuItem1});
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.таблицаToolStripMenuItem.Text = "Таблица";
            // 
            // Add_Vklad_ToolStripMenuItem
            // 
            this.Add_Vklad_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("Add_Vklad_ToolStripMenuItem.Image")));
            this.Add_Vklad_ToolStripMenuItem.Name = "Add_Vklad_ToolStripMenuItem";
            this.Add_Vklad_ToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.Add_Vklad_ToolStripMenuItem.Text = "Добавить вклад";
            this.Add_Vklad_ToolStripMenuItem.Click += new System.EventHandler(this.Add_Vklad_ToolStripMenuItem_Click);
            // 
            // перейтиВExcelToolStripMenuItem
            // 
            this.перейтиВExcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("перейтиВExcelToolStripMenuItem.Image")));
            this.перейтиВExcelToolStripMenuItem.Name = "перейтиВExcelToolStripMenuItem";
            this.перейтиВExcelToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.перейтиВExcelToolStripMenuItem.Text = "Перейти в Excel";
            this.перейтиВExcelToolStripMenuItem.Click += new System.EventHandler(this.ExcelToolVkladStripMenuItem_Click_2);
            // 
            // Clear_2_ToolStripMenuItem1
            // 
            this.Clear_2_ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("Clear_2_ToolStripMenuItem1.Image")));
            this.Clear_2_ToolStripMenuItem1.Name = "Clear_2_ToolStripMenuItem1";
            this.Clear_2_ToolStripMenuItem1.Size = new System.Drawing.Size(259, 34);
            this.Clear_2_ToolStripMenuItem1.Text = "Очистить таблицу";
            this.Clear_2_ToolStripMenuItem1.Click += new System.EventHandler(this.Clear_2_ToolStripMenuItem1_Click);
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToFileVkladToolStripMenuItem,
            this.OpenVkladToolStripMenuItem});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // SaveToFileVkladToolStripMenuItem
            // 
            this.SaveToFileVkladToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToFileVkladToolStripMenuItem.Image")));
            this.SaveToFileVkladToolStripMenuItem.Name = "SaveToFileVkladToolStripMenuItem";
            this.SaveToFileVkladToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.SaveToFileVkladToolStripMenuItem.Text = "Сохранить в файл";
            this.SaveToFileVkladToolStripMenuItem.Click += new System.EventHandler(this.SaveToFileVkladToolStripMenuItem_Click);
            // 
            // OpenVkladToolStripMenuItem
            // 
            this.OpenVkladToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenVkladToolStripMenuItem.Image")));
            this.OpenVkladToolStripMenuItem.Name = "OpenVkladToolStripMenuItem";
            this.OpenVkladToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.OpenVkladToolStripMenuItem.Text = "Открыть файл";
            this.OpenVkladToolStripMenuItem.Click += new System.EventHandler(this.OpenVkladToolStripMenuItem_Click);
            // 
            // exit_button
            // 
            this.exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button.Location = new System.Drawing.Point(-3909, 772);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(131, 33);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1893, 817);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem greedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadClientsToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem очиститьТаблицуToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Add_Vklad_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейтиВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Clear_2_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveToFileVkladToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenVkladToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_of_Vklad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Open;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum_of_Vklad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procent;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.TextBox poisk_vklad;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronomi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass_serias_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_of_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day_birth_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone_column;
    }
}

