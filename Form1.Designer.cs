namespace scm
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outTextBox = new System.Windows.Forms.RichTextBox();
            this.comPortList = new System.Windows.Forms.ComboBox();
            this.close = new System.Windows.Forms.Button();
            this.openBtt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paramReadButton = new System.Windows.Forms.Button();
            this.maskParametersReadButton = new System.Windows.Forms.Button();
            this.OnIgnitionButton = new System.Windows.Forms.Button();
            this.allParamTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMask = new System.Windows.Forms.NumericUpDown();
            this.paramReadСheckBox = new System.Windows.Forms.CheckBox();
            this.StartEngineButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OffIgnitionButton = new System.Windows.Forms.Button();
            this.UnblockingEngineButton = new System.Windows.Forms.Button();
            this.BlockEngineButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.ReadSettingsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownByte5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownByte4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownByte3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownByte2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownByte1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownByte0 = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SaveWayButton = new System.Windows.Forms.Button();
            this.ReadWayButton = new System.Windows.Forms.Button();
            this.numericUpDownWay = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ReadTimeButton = new System.Windows.Forms.Button();
            this.numericUpDownMaskWrite = new System.Windows.Forms.NumericUpDown();
            this.SaveTimeButton = new System.Windows.Forms.Button();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.StartEngineTimeButton = new System.Windows.Forms.Button();
            this.numericUpDownRanTime = new System.Windows.Forms.NumericUpDown();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.OpenTrunkButton = new System.Windows.Forms.Button();
            this.CloseDoorButton = new System.Windows.Forms.Button();
            this.OpenDoorButton = new System.Windows.Forms.Button();
            this.GetAutostartInfoButton = new System.Windows.Forms.Button();
            this.GetSystemInfoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMask)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte0)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWay)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaskWrite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRanTime)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // outTextBox
            // 
            this.outTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outTextBox.Location = new System.Drawing.Point(12, 485);
            this.outTextBox.Name = "outTextBox";
            this.outTextBox.Size = new System.Drawing.Size(800, 74);
            this.outTextBox.TabIndex = 2;
            this.outTextBox.Text = "";
            // 
            // comPortList
            // 
            this.comPortList.FormattingEnabled = true;
            this.comPortList.Location = new System.Drawing.Point(16, 13);
            this.comPortList.Name = "comPortList";
            this.comPortList.Size = new System.Drawing.Size(75, 21);
            this.comPortList.TabIndex = 5;
            this.comPortList.DropDown += new System.EventHandler(this.comPortList_DropDown);
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(128, 13);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = false;
            this.close.Visible = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // openBtt
            // 
            this.openBtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openBtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openBtt.Image = ((System.Drawing.Image)(resources.GetObject("openBtt.Image")));
            this.openBtt.Location = new System.Drawing.Point(97, 13);
            this.openBtt.Name = "openBtt";
            this.openBtt.Size = new System.Drawing.Size(25, 25);
            this.openBtt.TabIndex = 0;
            this.openBtt.UseVisualStyleBackColor = true;
            this.openBtt.Click += new System.EventHandler(this.open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "нет соединения";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comPortList);
            this.groupBox1.Controls.Add(this.openBtt);
            this.groupBox1.Controls.Add(this.close);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 44);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // paramReadButton
            // 
            this.paramReadButton.Location = new System.Drawing.Point(6, 36);
            this.paramReadButton.Name = "paramReadButton";
            this.paramReadButton.Size = new System.Drawing.Size(159, 35);
            this.paramReadButton.TabIndex = 17;
            this.paramReadButton.Text = "Запрос всех\r\nпараметров (03h)";
            this.paramReadButton.UseVisualStyleBackColor = true;
            this.paramReadButton.Click += new System.EventHandler(this.ParamReadButton_Click);
            // 
            // maskParametersReadButton
            // 
            this.maskParametersReadButton.Location = new System.Drawing.Point(171, 36);
            this.maskParametersReadButton.Name = "maskParametersReadButton";
            this.maskParametersReadButton.Size = new System.Drawing.Size(135, 35);
            this.maskParametersReadButton.TabIndex = 18;
            this.maskParametersReadButton.Text = "Параметры по маске (03h)";
            this.maskParametersReadButton.UseVisualStyleBackColor = true;
            this.maskParametersReadButton.Click += new System.EventHandler(this.MaskParametersReadButton_Click);
            // 
            // OnIgnitionButton
            // 
            this.OnIgnitionButton.Location = new System.Drawing.Point(14, 97);
            this.OnIgnitionButton.Name = "OnIgnitionButton";
            this.OnIgnitionButton.Size = new System.Drawing.Size(86, 35);
            this.OnIgnitionButton.TabIndex = 19;
            this.OnIgnitionButton.Text = "Включить зажигание (17h)";
            this.OnIgnitionButton.UseVisualStyleBackColor = true;
            this.OnIgnitionButton.Click += new System.EventHandler(this.OnIgnitionButton_Click);
            // 
            // allParamTextBox
            // 
            this.allParamTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allParamTextBox.Location = new System.Drawing.Point(6, 81);
            this.allParamTextBox.Name = "allParamTextBox";
            this.allParamTextBox.Size = new System.Drawing.Size(325, 390);
            this.allParamTextBox.TabIndex = 20;
            this.allParamTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownMask);
            this.groupBox2.Controls.Add(this.paramReadСheckBox);
            this.groupBox2.Controls.Add(this.paramReadButton);
            this.groupBox2.Controls.Add(this.allParamTextBox);
            this.groupBox2.Controls.Add(this.maskParametersReadButton);
            this.groupBox2.Location = new System.Drawing.Point(481, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 477);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // numericUpDownMask
            // 
            this.numericUpDownMask.Hexadecimal = true;
            this.numericUpDownMask.Location = new System.Drawing.Point(248, 11);
            this.numericUpDownMask.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownMask.Name = "numericUpDownMask";
            this.numericUpDownMask.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownMask.TabIndex = 22;
            this.numericUpDownMask.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            // 
            // paramReadСheckBox
            // 
            this.paramReadСheckBox.AutoSize = true;
            this.paramReadСheckBox.Location = new System.Drawing.Point(7, 11);
            this.paramReadСheckBox.Name = "paramReadСheckBox";
            this.paramReadСheckBox.Size = new System.Drawing.Size(168, 17);
            this.paramReadСheckBox.TabIndex = 21;
            this.paramReadСheckBox.Text = "Запрашивать периодически";
            this.paramReadСheckBox.UseVisualStyleBackColor = true;
            this.paramReadСheckBox.CheckedChanged += new System.EventHandler(this.paramReadСheckBox_CheckedChanged);
            // 
            // StartEngineButton
            // 
            this.StartEngineButton.Location = new System.Drawing.Point(14, 13);
            this.StartEngineButton.Name = "StartEngineButton";
            this.StartEngineButton.Size = new System.Drawing.Size(86, 35);
            this.StartEngineButton.TabIndex = 21;
            this.StartEngineButton.Text = "Запустить (15h)";
            this.StartEngineButton.UseVisualStyleBackColor = true;
            this.StartEngineButton.Click += new System.EventHandler(this.StartEngineButtonButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OffIgnitionButton);
            this.groupBox3.Controls.Add(this.UnblockingEngineButton);
            this.groupBox3.Controls.Add(this.StartEngineButton);
            this.groupBox3.Controls.Add(this.OnIgnitionButton);
            this.groupBox3.Controls.Add(this.BlockEngineButton);
            this.groupBox3.Location = new System.Drawing.Point(247, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 224);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // OffIgnitionButton
            // 
            this.OffIgnitionButton.Location = new System.Drawing.Point(14, 54);
            this.OffIgnitionButton.Name = "OffIgnitionButton";
            this.OffIgnitionButton.Size = new System.Drawing.Size(86, 35);
            this.OffIgnitionButton.TabIndex = 22;
            this.OffIgnitionButton.Text = "Выключить зажигание (18h)";
            this.OffIgnitionButton.UseVisualStyleBackColor = true;
            this.OffIgnitionButton.Click += new System.EventHandler(this.OffIgnitionButton_Click);
            // 
            // UnblockingEngineButton
            // 
            this.UnblockingEngineButton.Location = new System.Drawing.Point(14, 179);
            this.UnblockingEngineButton.Name = "UnblockingEngineButton";
            this.UnblockingEngineButton.Size = new System.Drawing.Size(86, 35);
            this.UnblockingEngineButton.TabIndex = 24;
            this.UnblockingEngineButton.Text = "Разблокировать";
            this.UnblockingEngineButton.UseVisualStyleBackColor = true;
            this.UnblockingEngineButton.Click += new System.EventHandler(this.UnblockingEngineButton_Click);
            // 
            // BlockEngineButton
            // 
            this.BlockEngineButton.Location = new System.Drawing.Point(14, 138);
            this.BlockEngineButton.Name = "BlockEngineButton";
            this.BlockEngineButton.Size = new System.Drawing.Size(86, 35);
            this.BlockEngineButton.TabIndex = 23;
            this.BlockEngineButton.Text = "Блокировать";
            this.BlockEngineButton.UseVisualStyleBackColor = true;
            this.BlockEngineButton.Click += new System.EventHandler(this.BlockEngineButton_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SaveSettingsButton);
            this.groupBox4.Controls.Add(this.ReadSettingsButton);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.numericUpDownByte5);
            this.groupBox4.Controls.Add(this.numericUpDownByte4);
            this.groupBox4.Controls.Add(this.numericUpDownByte3);
            this.groupBox4.Controls.Add(this.numericUpDownByte2);
            this.groupBox4.Controls.Add(this.numericUpDownByte1);
            this.groupBox4.Controls.Add(this.numericUpDownByte0);
            this.groupBox4.Location = new System.Drawing.Point(12, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 195);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры запуска";
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(243, 74);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(97, 41);
            this.SaveSettingsButton.TabIndex = 13;
            this.SaveSettingsButton.Text = "Записать\r\nнастройки (4Ah)";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // ReadSettingsButton
            // 
            this.ReadSettingsButton.Location = new System.Drawing.Point(243, 19);
            this.ReadSettingsButton.Name = "ReadSettingsButton";
            this.ReadSettingsButton.Size = new System.Drawing.Size(97, 41);
            this.ReadSettingsButton.TabIndex = 12;
            this.ReadSettingsButton.Text = "Читать\r\nнастройки (4Bh)";
            this.ReadSettingsButton.UseVisualStyleBackColor = true;
            this.ReadSettingsButton.Click += new System.EventHandler(this.ReadSettingsButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Перезагрузок системы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Отсечка, об/мин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Вращение стартера, с";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Свет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Температура прогр, °С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Время прогрева, с";
            // 
            // numericUpDownByte5
            // 
            this.numericUpDownByte5.Location = new System.Drawing.Point(139, 165);
            this.numericUpDownByte5.Name = "numericUpDownByte5";
            this.numericUpDownByte5.ReadOnly = true;
            this.numericUpDownByte5.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownByte5.TabIndex = 5;
            // 
            // numericUpDownByte4
            // 
            this.numericUpDownByte4.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownByte4.Location = new System.Drawing.Point(139, 121);
            this.numericUpDownByte4.Maximum = new decimal(new int[] {
            2550,
            0,
            0,
            0});
            this.numericUpDownByte4.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownByte4.Name = "numericUpDownByte4";
            this.numericUpDownByte4.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownByte4.TabIndex = 4;
            this.numericUpDownByte4.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // numericUpDownByte3
            // 
            this.numericUpDownByte3.DecimalPlaces = 1;
            this.numericUpDownByte3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownByte3.Location = new System.Drawing.Point(139, 95);
            this.numericUpDownByte3.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownByte3.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.numericUpDownByte3.Name = "numericUpDownByte3";
            this.numericUpDownByte3.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownByte3.TabIndex = 3;
            this.numericUpDownByte3.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // numericUpDownByte2
            // 
            this.numericUpDownByte2.Location = new System.Drawing.Point(139, 71);
            this.numericUpDownByte2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownByte2.Name = "numericUpDownByte2";
            this.numericUpDownByte2.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownByte2.TabIndex = 2;
            // 
            // numericUpDownByte1
            // 
            this.numericUpDownByte1.Location = new System.Drawing.Point(139, 45);
            this.numericUpDownByte1.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDownByte1.Minimum = new decimal(new int[] {
            126,
            0,
            0,
            -2147483648});
            this.numericUpDownByte1.Name = "numericUpDownByte1";
            this.numericUpDownByte1.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownByte1.TabIndex = 1;
            // 
            // numericUpDownByte0
            // 
            this.numericUpDownByte0.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownByte0.Location = new System.Drawing.Point(139, 17);
            this.numericUpDownByte0.Maximum = new decimal(new int[] {
            2550,
            0,
            0,
            0});
            this.numericUpDownByte0.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownByte0.Name = "numericUpDownByte0";
            this.numericUpDownByte0.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownByte0.TabIndex = 0;
            this.numericUpDownByte0.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SaveWayButton);
            this.groupBox5.Controls.Add(this.ReadWayButton);
            this.groupBox5.Controls.Add(this.numericUpDownWay);
            this.groupBox5.Location = new System.Drawing.Point(12, 200);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(203, 78);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Пробег, км";
            // 
            // SaveWayButton
            // 
            this.SaveWayButton.Location = new System.Drawing.Point(115, 46);
            this.SaveWayButton.Name = "SaveWayButton";
            this.SaveWayButton.Size = new System.Drawing.Size(75, 23);
            this.SaveWayButton.TabIndex = 2;
            this.SaveWayButton.Text = "Записать";
            this.SaveWayButton.UseVisualStyleBackColor = true;
            this.SaveWayButton.Click += new System.EventHandler(this.SaveWayButton_Click);
            // 
            // ReadWayButton
            // 
            this.ReadWayButton.Location = new System.Drawing.Point(10, 46);
            this.ReadWayButton.Name = "ReadWayButton";
            this.ReadWayButton.Size = new System.Drawing.Size(75, 23);
            this.ReadWayButton.TabIndex = 1;
            this.ReadWayButton.Text = "Считать";
            this.ReadWayButton.UseVisualStyleBackColor = true;
            this.ReadWayButton.Click += new System.EventHandler(this.ReadWayButton_Click);
            // 
            // numericUpDownWay
            // 
            this.numericUpDownWay.Location = new System.Drawing.Point(10, 19);
            this.numericUpDownWay.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDownWay.Name = "numericUpDownWay";
            this.numericUpDownWay.Size = new System.Drawing.Size(180, 20);
            this.numericUpDownWay.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ReadTimeButton);
            this.groupBox6.Controls.Add(this.numericUpDownMaskWrite);
            this.groupBox6.Controls.Add(this.SaveTimeButton);
            this.groupBox6.Controls.Add(this.numericUpDownTime);
            this.groupBox6.Location = new System.Drawing.Point(12, 52);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(229, 74);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Автоматическая выдыча параметров, с";
            // 
            // ReadTimeButton
            // 
            this.ReadTimeButton.Location = new System.Drawing.Point(151, 24);
            this.ReadTimeButton.Name = "ReadTimeButton";
            this.ReadTimeButton.Size = new System.Drawing.Size(72, 35);
            this.ReadTimeButton.TabIndex = 24;
            this.ReadTimeButton.Text = "Прочитать (05h)";
            this.ReadTimeButton.UseVisualStyleBackColor = true;
            this.ReadTimeButton.Click += new System.EventHandler(this.ReadTimeButton_Click);
            // 
            // numericUpDownMaskWrite
            // 
            this.numericUpDownMaskWrite.Hexadecimal = true;
            this.numericUpDownMaskWrite.Location = new System.Drawing.Point(10, 19);
            this.numericUpDownMaskWrite.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownMaskWrite.Name = "numericUpDownMaskWrite";
            this.numericUpDownMaskWrite.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownMaskWrite.TabIndex = 23;
            this.numericUpDownMaskWrite.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            // 
            // SaveTimeButton
            // 
            this.SaveTimeButton.Location = new System.Drawing.Point(76, 24);
            this.SaveTimeButton.Name = "SaveTimeButton";
            this.SaveTimeButton.Size = new System.Drawing.Size(72, 35);
            this.SaveTimeButton.TabIndex = 1;
            this.SaveTimeButton.Text = "Записать (04h)";
            this.SaveTimeButton.UseVisualStyleBackColor = true;
            this.SaveTimeButton.Click += new System.EventHandler(this.SaveTimeButton_Click);
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Location = new System.Drawing.Point(9, 45);
            this.numericUpDownTime.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownTime.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.StartEngineTimeButton);
            this.groupBox7.Controls.Add(this.numericUpDownRanTime);
            this.groupBox7.Location = new System.Drawing.Point(12, 132);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(229, 62);
            this.groupBox7.TabIndex = 26;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Запуск двигателя на заданное время, с";
            // 
            // StartEngineTimeButton
            // 
            this.StartEngineTimeButton.Location = new System.Drawing.Point(128, 19);
            this.StartEngineTimeButton.Name = "StartEngineTimeButton";
            this.StartEngineTimeButton.Size = new System.Drawing.Size(75, 35);
            this.StartEngineTimeButton.TabIndex = 1;
            this.StartEngineTimeButton.Text = "Запустить (16h)";
            this.StartEngineTimeButton.UseVisualStyleBackColor = true;
            this.StartEngineTimeButton.Click += new System.EventHandler(this.StartEngineTimeButton_Click);
            // 
            // numericUpDownRanTime
            // 
            this.numericUpDownRanTime.Location = new System.Drawing.Point(16, 29);
            this.numericUpDownRanTime.Maximum = new decimal(new int[] {
            2550,
            0,
            0,
            0});
            this.numericUpDownRanTime.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownRanTime.Name = "numericUpDownRanTime";
            this.numericUpDownRanTime.Size = new System.Drawing.Size(89, 20);
            this.numericUpDownRanTime.TabIndex = 0;
            this.numericUpDownRanTime.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.OpenTrunkButton);
            this.groupBox8.Controls.Add(this.CloseDoorButton);
            this.groupBox8.Controls.Add(this.OpenDoorButton);
            this.groupBox8.Controls.Add(this.GetAutostartInfoButton);
            this.groupBox8.Controls.Add(this.GetSystemInfoButton);
            this.groupBox8.Location = new System.Drawing.Point(364, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(111, 477);
            this.groupBox8.TabIndex = 27;
            this.groupBox8.TabStop = false;
            // 
            // OpenTrunkButton
            // 
            this.OpenTrunkButton.Location = new System.Drawing.Point(7, 175);
            this.OpenTrunkButton.Name = "OpenTrunkButton";
            this.OpenTrunkButton.Size = new System.Drawing.Size(97, 35);
            this.OpenTrunkButton.TabIndex = 4;
            this.OpenTrunkButton.Text = "Открыть  багажник (11h)";
            this.OpenTrunkButton.UseVisualStyleBackColor = true;
            this.OpenTrunkButton.Click += new System.EventHandler(this.OpenTrunkButton_Click);
            // 
            // CloseDoorButton
            // 
            this.CloseDoorButton.Location = new System.Drawing.Point(8, 134);
            this.CloseDoorButton.Name = "CloseDoorButton";
            this.CloseDoorButton.Size = new System.Drawing.Size(97, 35);
            this.CloseDoorButton.TabIndex = 3;
            this.CloseDoorButton.Text = "Закрыть ЦЗ (11h)";
            this.CloseDoorButton.UseVisualStyleBackColor = true;
            this.CloseDoorButton.Click += new System.EventHandler(this.CloseDoorButton_Click);
            // 
            // OpenDoorButton
            // 
            this.OpenDoorButton.Location = new System.Drawing.Point(7, 93);
            this.OpenDoorButton.Name = "OpenDoorButton";
            this.OpenDoorButton.Size = new System.Drawing.Size(97, 35);
            this.OpenDoorButton.TabIndex = 2;
            this.OpenDoorButton.Text = "Открыть ЦЗ (11h)";
            this.OpenDoorButton.UseVisualStyleBackColor = true;
            this.OpenDoorButton.Click += new System.EventHandler(this.OpenDoorButton_Click);
            // 
            // GetAutostartInfoButton
            // 
            this.GetAutostartInfoButton.Location = new System.Drawing.Point(7, 52);
            this.GetAutostartInfoButton.Name = "GetAutostartInfoButton";
            this.GetAutostartInfoButton.Size = new System.Drawing.Size(97, 35);
            this.GetAutostartInfoButton.TabIndex = 1;
            this.GetAutostartInfoButton.Text = "Информация об автозапуске(06h)";
            this.GetAutostartInfoButton.UseVisualStyleBackColor = true;
            this.GetAutostartInfoButton.Click += new System.EventHandler(this.GetAutostartInfoButton_Click);
            // 
            // GetSystemInfoButton
            // 
            this.GetSystemInfoButton.Location = new System.Drawing.Point(7, 11);
            this.GetSystemInfoButton.Name = "GetSystemInfoButton";
            this.GetSystemInfoButton.Size = new System.Drawing.Size(97, 35);
            this.GetSystemInfoButton.TabIndex = 0;
            this.GetSystemInfoButton.Text = "Информация об устройсве (01h)";
            this.GetSystemInfoButton.UseVisualStyleBackColor = true;
            this.GetSystemInfoButton.Click += new System.EventHandler(this.GetSystemInfoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 570);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "S-CAN4v2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMask)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte0)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWay)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaskWrite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRanTime)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openBtt;
        private System.Windows.Forms.Button close;
        public System.Windows.Forms.RichTextBox outTextBox;
        private System.Windows.Forms.ComboBox comPortList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button paramReadButton;
        private System.Windows.Forms.Button maskParametersReadButton;
        private System.Windows.Forms.Button OnIgnitionButton;
        public System.Windows.Forms.RichTextBox allParamTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button StartEngineButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button OffIgnitionButton;
        private System.Windows.Forms.CheckBox paramReadСheckBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.Button ReadSettingsButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown numericUpDownByte5;
        public System.Windows.Forms.NumericUpDown numericUpDownByte4;
        public System.Windows.Forms.NumericUpDown numericUpDownByte3;
        public System.Windows.Forms.NumericUpDown numericUpDownByte2;
        public System.Windows.Forms.NumericUpDown numericUpDownByte1;
        public System.Windows.Forms.NumericUpDown numericUpDownByte0;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button SaveWayButton;
        private System.Windows.Forms.Button ReadWayButton;
        public System.Windows.Forms.NumericUpDown numericUpDownWay;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button SaveTimeButton;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button StartEngineTimeButton;
        private System.Windows.Forms.NumericUpDown numericUpDownRanTime;
        private System.Windows.Forms.Button UnblockingEngineButton;
        private System.Windows.Forms.Button BlockEngineButton;
        private System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.NumericUpDown numericUpDownMask;
        private System.Windows.Forms.Button GetSystemInfoButton;
        private System.Windows.Forms.Button ReadTimeButton;
        private System.Windows.Forms.NumericUpDown numericUpDownMaskWrite;
        private System.Windows.Forms.Button GetAutostartInfoButton;
        private System.Windows.Forms.Button OpenTrunkButton;
        private System.Windows.Forms.Button CloseDoorButton;
        private System.Windows.Forms.Button OpenDoorButton;
    }
}

