using System;
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
        public int delay_off_rele = 1000;
        public Boolean powerStatus = false;
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

        private void SendMessagePortRele (int rel_number, int sost_rele)
/// включает иотключает реле. Возможно только включение одного реле///
        {
            //отключаем все реле на всякий случай
            //SendMessegePort("$KE,REL,1,0");
            SendMessegePort("$KE,REL,2,0");
            SendMessegePort("$KE,REL,3,0");
            SendMessegePort("$KE,REL,4,0");

            /*button_198V.BackColor = Color.Gray;
            button_220V.BackColor = Color.Gray;
            button_242V.BackColor = Color.Gray;*/

            if (( rel_number  <= 4) && (rel_number >1) && (powerStatus == true) )  // если 5 - то просто сбросить все реле
            {
                Thread.Sleep(delay_off_rele);

                SendMessegePort("$KE,REL," + rel_number.ToString() + "," + sost_rele.ToString());
            } 

            if (rel_number == 1)
            {
                SendMessegePort("$KE,REL," + rel_number.ToString() + "," + sost_rele.ToString());

            }

            if (rel_number == 5)
            {
                SendMessegePort("$KE,REL,1,0");
                powerStatus = false;
                button_power.BackColor = Color.Gray;
            }
            
        }

        private int WhatPowerRadioButtonChanged()
        {
            if (radioButton198.Checked) return 2;
            if (radioButton220.Checked) return 3;
            if (radioButton242.Checked) return 4;
            return 5;
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
                SendMessagePortRele(5, 0); //сбросить все реле
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
                SendMessagePortRele(5, 0); //сбросить все реле
                serialPort1.Close();
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
                SendMessagePortRele(5, 0); //сбросить все реле
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
            if ((powerStatus == false) && (serialPort1.IsOpen) )
            {
                powerStatus = true;
                SendMessagePortRele(1, 1);
                SendMessagePortRele( WhatPowerRadioButtonChanged(), 1);
                timePowerOn = DateTime.Now;// устанавливаем время начала работы
                timerPowerOn.Enabled = true;

                button_power.BackColor = Color.Red;

            } else
            {
                powerStatus = false;
                timerPowerOn.Enabled = false;
                //SendMessagePortRele(1, 0);
                SendMessagePortRele(5, 0);
                button_power.BackColor = Color.Gray;
            }
        }

        
        private void radioButtonPower_CheckedChanged(object sender, EventArgs e)
        {
            if ( ((RadioButton)sender).Checked == false ) return;

            SendMessagePortRele(WhatPowerRadioButtonChanged(), 1);
            
        }

        private void timerPowerOn_Tick(object sender, EventArgs e)
        {
            if (powerStatus == true)
            {
                TimeSpan a = (DateTime.Now - timePowerOn);
                //label_time_power_on.Text = Convert.ToString( (TimeSpan)(DateTime.Now - timePowerOn)    );
                label_time_power_on.Text = String.Format("{0:00}:{1:00}:{2:00}",
                                                        a.Hours, a.Minutes, a.Seconds);
            }
            

        }
    }
}
