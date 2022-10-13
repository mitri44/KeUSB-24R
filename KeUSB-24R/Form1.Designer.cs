namespace KeUSB_24R
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxComPorts = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonClosePort = new System.Windows.Forms.Button();
            this.textBoxMessege = new System.Windows.Forms.TextBox();
            this.button_power = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_time_power_on = new System.Windows.Forms.Label();
            this.timerPowerOn = new System.Windows.Forms.Timer(this.components);
            this.button198V = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button242V = new System.Windows.Forms.Button();
            this.button220V = new System.Windows.Forms.Button();
            this.numericUpDownPause = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCountCicle = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCicleStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelTimeHeating = new System.Windows.Forms.Label();
            this.numericUpDownHeatingTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.timerCicleOn = new System.Windows.Forms.Timer(this.components);
            this.timerHeating = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountCicle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeatingTime)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxComPorts
            // 
            this.comboBoxComPorts.FormattingEnabled = true;
            this.comboBoxComPorts.Location = new System.Drawing.Point(32, 39);
            this.comboBoxComPorts.Name = "comboBoxComPorts";
            this.comboBoxComPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPorts.TabIndex = 1;
            this.comboBoxComPorts.Text = "выбрать COM Port";
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Gray;
            this.buttonConnect.ForeColor = System.Drawing.Color.PapayaWhip;
            this.buttonConnect.Location = new System.Drawing.Point(25, 219);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(140, 69);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "подключиться";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buttonClosePort
            // 
            this.buttonClosePort.Location = new System.Drawing.Point(211, 219);
            this.buttonClosePort.Name = "buttonClosePort";
            this.buttonClosePort.Size = new System.Drawing.Size(140, 69);
            this.buttonClosePort.TabIndex = 4;
            this.buttonClosePort.Text = "отключить устройство";
            this.buttonClosePort.UseVisualStyleBackColor = true;
            this.buttonClosePort.Click += new System.EventHandler(this.buttonClosePort_Click);
            // 
            // textBoxMessege
            // 
            this.textBoxMessege.Location = new System.Drawing.Point(25, 294);
            this.textBoxMessege.Multiline = true;
            this.textBoxMessege.Name = "textBoxMessege";
            this.textBoxMessege.ReadOnly = true;
            this.textBoxMessege.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessege.Size = new System.Drawing.Size(326, 289);
            this.textBoxMessege.TabIndex = 5;
            // 
            // button_power
            // 
            this.button_power.BackColor = System.Drawing.Color.Gray;
            this.button_power.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_power.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button_power.Location = new System.Drawing.Point(402, 39);
            this.button_power.Name = "button_power";
            this.button_power.Size = new System.Drawing.Size(123, 38);
            this.button_power.TabIndex = 8;
            this.button_power.Text = "вкл/выкл сеть";
            this.button_power.UseVisualStyleBackColor = false;
            this.button_power.Click += new System.EventHandler(this.button_power_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "время работы:";
            // 
            // label_time_power_on
            // 
            this.label_time_power_on.AutoSize = true;
            this.label_time_power_on.Location = new System.Drawing.Point(545, 64);
            this.label_time_power_on.Name = "label_time_power_on";
            this.label_time_power_on.Size = new System.Drawing.Size(10, 13);
            this.label_time_power_on.TabIndex = 14;
            this.label_time_power_on.Text = "-";
            // 
            // timerPowerOn
            // 
            this.timerPowerOn.Interval = 1000;
            this.timerPowerOn.Tick += new System.EventHandler(this.timerPowerOn_Tick);
            // 
            // button198V
            // 
            this.button198V.BackColor = System.Drawing.Color.Gray;
            this.button198V.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button198V.Location = new System.Drawing.Point(6, 34);
            this.button198V.Name = "button198V";
            this.button198V.Size = new System.Drawing.Size(94, 38);
            this.button198V.TabIndex = 15;
            this.button198V.Text = "198";
            this.button198V.UseVisualStyleBackColor = false;
            this.button198V.Click += new System.EventHandler(this.button198V_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button242V);
            this.groupBox2.Controls.Add(this.button220V);
            this.groupBox2.Controls.Add(this.button198V);
            this.groupBox2.Location = new System.Drawing.Point(402, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 168);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "напряжение, вольт";
            // 
            // button242V
            // 
            this.button242V.BackColor = System.Drawing.Color.Gray;
            this.button242V.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button242V.Location = new System.Drawing.Point(6, 122);
            this.button242V.Name = "button242V";
            this.button242V.Size = new System.Drawing.Size(94, 38);
            this.button242V.TabIndex = 15;
            this.button242V.Text = "242";
            this.button242V.UseVisualStyleBackColor = false;
            this.button242V.Click += new System.EventHandler(this.button242V_Click);
            // 
            // button220V
            // 
            this.button220V.BackColor = System.Drawing.Color.Gray;
            this.button220V.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button220V.Location = new System.Drawing.Point(6, 78);
            this.button220V.Name = "button220V";
            this.button220V.Size = new System.Drawing.Size(94, 38);
            this.button220V.TabIndex = 15;
            this.button220V.Text = "220";
            this.button220V.UseVisualStyleBackColor = false;
            this.button220V.Click += new System.EventHandler(this.button220V_Click);
            // 
            // numericUpDownPause
            // 
            this.numericUpDownPause.Location = new System.Drawing.Point(135, 61);
            this.numericUpDownPause.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownPause.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPause.Name = "numericUpDownPause";
            this.numericUpDownPause.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownPause.TabIndex = 15;
            this.numericUpDownPause.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "пауза, сек";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "кол-во циклов";
            // 
            // numericUpDownCountCicle
            // 
            this.numericUpDownCountCicle.Location = new System.Drawing.Point(135, 120);
            this.numericUpDownCountCicle.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownCountCicle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountCicle.Name = "numericUpDownCountCicle";
            this.numericUpDownCountCicle.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownCountCicle.TabIndex = 17;
            this.numericUpDownCountCicle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCicleStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownPause);
            this.groupBox1.Controls.Add(this.numericUpDownCountCicle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(402, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 168);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "циклы";
            // 
            // buttonCicleStart
            // 
            this.buttonCicleStart.BackColor = System.Drawing.Color.Gray;
            this.buttonCicleStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCicleStart.ForeColor = System.Drawing.Color.PapayaWhip;
            this.buttonCicleStart.Location = new System.Drawing.Point(17, 42);
            this.buttonCicleStart.Name = "buttonCicleStart";
            this.buttonCicleStart.Size = new System.Drawing.Size(92, 40);
            this.buttonCicleStart.TabIndex = 19;
            this.buttonCicleStart.Text = "запуск циклов";
            this.buttonCicleStart.UseVisualStyleBackColor = false;
            this.buttonCicleStart.Click += new System.EventHandler(this.buttonCicleStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelTimeHeating);
            this.groupBox3.Controls.Add(this.numericUpDownHeatingTime);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(662, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 100);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "прогрев";
            // 
            // labelTimeHeating
            // 
            this.labelTimeHeating.AutoSize = true;
            this.labelTimeHeating.Location = new System.Drawing.Point(124, 52);
            this.labelTimeHeating.Name = "labelTimeHeating";
            this.labelTimeHeating.Size = new System.Drawing.Size(10, 13);
            this.labelTimeHeating.TabIndex = 23;
            this.labelTimeHeating.Text = "-";
            // 
            // numericUpDownHeatingTime
            // 
            this.numericUpDownHeatingTime.Location = new System.Drawing.Point(6, 50);
            this.numericUpDownHeatingTime.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownHeatingTime.Name = "numericUpDownHeatingTime";
            this.numericUpDownHeatingTime.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownHeatingTime.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "время прогрева, мин";
            // 
            // timerCicleOn
            // 
            this.timerCicleOn.Tick += new System.EventHandler(this.timerCicleOn_Tick);
            // 
            // timerHeating
            // 
            this.timerHeating.Interval = 1000;
            this.timerHeating.Tick += new System.EventHandler(this.timerHeating_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label_time_power_on);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_power);
            this.Controls.Add(this.textBoxMessege);
            this.Controls.Add(this.buttonClosePort);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxComPorts);
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "Form1";
            this.Text = "PH-metr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountCicle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeatingTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxComPorts;
        private System.Windows.Forms.Button buttonConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonClosePort;
        private System.Windows.Forms.TextBox textBoxMessege;
        private System.Windows.Forms.Button button_power;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_time_power_on;
        private System.Windows.Forms.Timer timerPowerOn;
        private System.Windows.Forms.Button button198V;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button242V;
        private System.Windows.Forms.Button button220V;
        private System.Windows.Forms.NumericUpDown numericUpDownPause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCountCicle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCicleStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelTimeHeating;
        private System.Windows.Forms.NumericUpDown numericUpDownHeatingTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerCicleOn;
        private System.Windows.Forms.Timer timerHeating;
    }
}

