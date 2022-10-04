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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton242 = new System.Windows.Forms.RadioButton();
            this.radioButton220 = new System.Windows.Forms.RadioButton();
            this.radioButton198 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label_time_power_on = new System.Windows.Forms.Label();
            this.timerPowerOn = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
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
            this.buttonConnect.Location = new System.Drawing.Point(25, 219);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(140, 69);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
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
            this.textBoxMessege.Size = new System.Drawing.Size(326, 195);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton242);
            this.groupBox1.Controls.Add(this.radioButton220);
            this.groupBox1.Controls.Add(this.radioButton198);
            this.groupBox1.Location = new System.Drawing.Point(573, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 122);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "напряжение, вольт";
            // 
            // radioButton242
            // 
            this.radioButton242.AutoSize = true;
            this.radioButton242.Location = new System.Drawing.Point(17, 95);
            this.radioButton242.Name = "radioButton242";
            this.radioButton242.Size = new System.Drawing.Size(43, 17);
            this.radioButton242.TabIndex = 2;
            this.radioButton242.Text = "242";
            this.radioButton242.UseVisualStyleBackColor = true;
            // 
            // radioButton220
            // 
            this.radioButton220.AutoSize = true;
            this.radioButton220.Location = new System.Drawing.Point(17, 61);
            this.radioButton220.Name = "radioButton220";
            this.radioButton220.Size = new System.Drawing.Size(43, 17);
            this.radioButton220.TabIndex = 1;
            this.radioButton220.Text = "220";
            this.radioButton220.UseVisualStyleBackColor = true;
            // 
            // radioButton198
            // 
            this.radioButton198.AutoSize = true;
            this.radioButton198.Checked = true;
            this.radioButton198.Location = new System.Drawing.Point(17, 28);
            this.radioButton198.Name = "radioButton198";
            this.radioButton198.Size = new System.Drawing.Size(43, 17);
            this.radioButton198.TabIndex = 0;
            this.radioButton198.TabStop = true;
            this.radioButton198.Text = "198";
            this.radioButton198.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.label_time_power_on);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_power);
            this.Controls.Add(this.textBoxMessege);
            this.Controls.Add(this.buttonClosePort);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxComPorts);
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "Form1";
            this.Text = "PH-metr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton198;
        private System.Windows.Forms.RadioButton radioButton242;
        private System.Windows.Forms.RadioButton radioButton220;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_time_power_on;
        private System.Windows.Forms.Timer timerPowerOn;
    }
}

