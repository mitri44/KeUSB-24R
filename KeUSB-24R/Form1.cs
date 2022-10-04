﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.Threading;

namespace KeUSB_24R
{
    
    
    public partial class Form1 : Form
    {
        public int delay_off_rele = 1000; // время в мс для задержки между переключениями реле напряжения
        public Boolean isPowerStatus = false;
        public Boolean isConnected = false;

        DateTime timePowerOn = new DateTime();


        private void SendMessegePort (string mes)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    string messege = mes + "\r\n";
                    serialPort1.Write(messege);
                    textBoxMessege.AppendText(DateTime.Now.ToString("HH:mm:ss.ffff") + ": отправелено: " + messege );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void OffRele2to4()
        {
            SendMessegePort("$KE,REL,2,0");
            SendMessegePort("$KE,REL,3,0");
            SendMessegePort("$KE,REL,4,0");
        }

        private void SendMessagePortRele (int rel_number, int sost_rele)
/// включает иотключает реле. Возможно только включение одного реле///
        {
            SendMessegePort("$KE,REL," + rel_number.ToString() + "," + sost_rele.ToString());
           
        }

        
        private void ReadMessegePort()
        {
            try
            {
                if (serialPort1.IsOpen)
                {

                    textBoxMessege.AppendText(DateTime.Now.ToString("HH:mm:ss.ffff") + ": получено: " + serialPort1.ReadExisting()  );//+ Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "messege", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public Form1()
        {
            InitializeComponent();

            

            // получаем список доступных портов
            string[] ports = SerialPort.GetPortNames();
            comboBoxComPorts.Items.AddRange(ports);
            if (comboBoxComPorts.Items.Count > 0)   comboBoxComPorts.SelectedIndex = 0;
            
            /*
            DateTime a = new DateTime();
            a = DateTime.Now;
            a = a.AddDays(1);
            TimeSpan b = a - DateTime.Now;
            
            textBox1.Text = b.TotalMinutes.ToString();
            */



        }

         

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxComPorts.Text;
                serialPort1.Open();
                SendMessegePort("$KE");

                OffRele2to4();
                SendMessagePortRele(1, 0); // отключить все реле
                
                isConnected = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
        }

        private void buttonClosePort_Click(object sender, EventArgs e)
        {
            try
            {
                OffRele2to4();
                SendMessegePort("$KE,REL,1,0");//сбросить все реле
                serialPort1.Close();
                isConnected = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReadMessegePort();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                OffRele2to4();
                SendMessegePort("$KE,REL,1,0");//сбросить все реле
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_power_Click(object sender, EventArgs e)
        {
            if ((isPowerStatus == false) && (isConnected == true) )
            {
                isPowerStatus = true;
                OffRele2to4();
                Thread.Sleep(delay_off_rele);
                SendMessagePortRele(1, 1);
                
                timePowerOn = DateTime.Now;// устанавливаем время начала работы
                timerPowerOn.Enabled = true;

                button_power.BackColor = Color.Red;

            } else
            {
                isPowerStatus = false;
                timerPowerOn.Enabled = false;
                
                OffRele2to4();
                SendMessagePortRele(1, 0);

                button_power.BackColor = Color.Gray;
            }
        }

        
        

        private void timerPowerOn_Tick(object sender, EventArgs e)
        {
            if (isPowerStatus == true)
            {
                TimeSpan a = (DateTime.Now - timePowerOn);
                //label_time_power_on.Text = Convert.ToString( (TimeSpan)(DateTime.Now - timePowerOn)    );
                label_time_power_on.Text = String.Format("{0:00}:{1:00}:{2:00}",
                                                        a.Hours, a.Minutes, a.Seconds);
            }
            

        }
    }
}
