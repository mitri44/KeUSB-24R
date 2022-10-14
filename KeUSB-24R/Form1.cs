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
        public int delay_off_rele = 1000; // время в мс для задержки между переключениями реле напряжения
        public Boolean isPowerStatus = false;
        public Boolean isConnected = false;
        public Boolean is198V = false;
        public Boolean is220V = false;
        public Boolean is242V = false;

        // серия флагов/переменных для сиклов
        public Boolean isCicleOn = false;
        public int cicleCount = 0;
        public int cicleReleOn = 0; //какое реле работало последним 198-2, 220-3, 242-4

        // для прогрева
        public Boolean isHearting = false;
        public int timeHeating;



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
            button198V.BackColor = Color.Gray;
            button220V.BackColor = Color.Gray;
            button242V.BackColor = Color.Gray;
            is198V = false;
            is220V = false;
            is242V = false;
        }

        private void SendMessagePortRele (int rel_number, int sost_rele)
/// включает иотключает реле. Возможно только включение одного реле///
        {
            SendMessegePort("$KE,REL," + rel_number.ToString() + "," + sost_rele.ToString());
           
        }

        private void Button198220242Enabled (Boolean onOff)
        {
            button198V.Enabled = onOff;
            button220V.Enabled = onOff;
            button242V.Enabled = onOff;
        }

        private void ButtonAllEneble (Boolean onOff)
        {
            Button198220242Enabled(onOff);
            buttonCicleStart.Enabled = onOff;
        }
        

        private void CicleStart (int delayReleOn , int countCicle)
        {
            delayReleOn = delayReleOn * 1000;
            OffRele2to4();
            Button198220242Enabled(false);
            isCicleOn = true;

            cicleCount = countCicle * 3 ; // по кол-ву реле 
            labelCountToEndCicle.Text = "осталось: " + Convert.ToString((int)(cicleCount / 3));
            timerCicleOn.Interval = delayReleOn + delay_off_rele;    
            timerCicleOn.Enabled = true;

            cicleReleOn = 2; // установили флаг, что работает реле 2
            button198V_Click(null, null); // пуск первого реле
            

        }

        private void PowerHeating()
        {
            
            timeHeating = (int)numericUpDownHeatingTime.Value * 60; // определяем в сек
            if (timeHeating > 0)
            {
                ButtonAllEneble(false);
                isHearting = true;
                timerHeating.Enabled = true;

            }
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
            if (isConnected == false)
            {
                try
                {
                    serialPort1.PortName = comboBoxComPorts.Text;
                    serialPort1.Open();
                    SendMessegePort("$KE");

                    OffRele2to4();
                    SendMessagePortRele(1, 0); // отключить все реле

                    isConnected = true;
                    Button198220242Enabled(true);
                    buttonConnect.BackColor = Color.Red;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
           
            
            
        }

        private void buttonClosePort_Click(object sender, EventArgs e)
        {
            try
            {
                OffRele2to4();
                SendMessegePort("$KE,REL,1,0");//сбросить  реле
                if (isPowerStatus == true)
                {
                    button_power_Click(null, null);
                }

                
                serialPort1.Close();
                isConnected = false;
                buttonConnect.BackColor = Color.Gray;

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
                
                Button198220242Enabled(true);
                PowerHeating();
                


            } else
            {
                if (isConnected == true)
                {
                    timerPowerOn.Enabled = false;
                    TimeSpan a = (DateTime.Now - timePowerOn);
                    label_time_power_on.Text = String.Format("{0:00}:{1:00}:{2:00}",
                                                            a.Hours, a.Minutes, a.Seconds);
                }
               
                isPowerStatus = false;
                

                OffRele2to4();
                SendMessagePortRele(1, 0);

                button_power.BackColor = Color.Gray;
                isHearting = false;
                ButtonAllEneble(true);
                labelTimeHeating.Text = "-";
            }

            isCicleOn = false;
            timerCicleOn.Enabled = false;
            buttonCicleStart.BackColor = Color.Gray;
            labelCountToEndCicle.Text = "-";
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

        private void button198V_Click(object sender, EventArgs e)
        {
            if ((isPowerStatus == true) && (isConnected == true) && (is198V == false)     )
            {
                
                OffRele2to4();
                button198V.BackColor = Color.Red;
                Thread.Sleep(delay_off_rele);
                SendMessagePortRele(2, 1);                
                is198V = true;

            } else if ((is198V == true) )
            {
                OffRele2to4();
                
            }
        }

        private void button220V_Click(object sender, EventArgs e)
        {
            if ((isPowerStatus == true) && (isConnected == true) && (is220V == false) )
            {
                
                OffRele2to4();
                button220V.BackColor = Color.Red;
                Thread.Sleep(delay_off_rele);
                SendMessagePortRele(3, 1);                
                is220V = true;

            }
            else if ((is220V == true) )
            {
                OffRele2to4();
                
            }
        }

        private void button242V_Click(object sender, EventArgs e)
        {
            if ((isPowerStatus == true) && (isConnected == true) && (is242V == false) )
            {
                OffRele2to4();
                button242V.BackColor = Color.Red;
                Thread.Sleep(delay_off_rele);
                SendMessagePortRele(4, 1);                
                is242V = true;
                


            }
            else if ((is242V == true))
            {
                OffRele2to4();
                
            }
        }

        private void buttonCicleStart_Click(object sender, EventArgs e)
        {
            if ((isPowerStatus == true) && (isConnected == true) && (isCicleOn == false))
            {
                int timedelay = (int)numericUpDownPause.Value * 60;
                int countCicle = (int)numericUpDownCountCicle.Value;

                if (timedelay != 0 && countCicle != 0)
                {
                    buttonCicleStart.BackColor = Color.Red;
                    
                    CicleStart(timedelay, countCicle);
                    //buttonCicleStart.BackColor = Color.Gray;
                }

            } else if (isCicleOn == true)
            {
                timerCicleOn.Enabled = false;
                isCicleOn = false;
                buttonCicleStart.BackColor = Color.Gray;
                OffRele2to4();
                Button198220242Enabled(true);
                labelCountToEndCicle.Text = "-";



            }






        }

        private void timerCicleOn_Tick(object sender, EventArgs e)
        {
            if (isCicleOn == true)
            {
                if (cicleCount > 0)
                {
                    if (cicleReleOn == 2)
                    {
                        button198V_Click(null, null);
                        cicleReleOn = 3;
                    }
                    else if (cicleReleOn == 3)
                    {
                        button220V_Click(null, null);
                        cicleReleOn = 4;
                    }
                    else if (cicleReleOn == 4)
                    {
                        button242V_Click(null, null);
                        cicleReleOn = 2;
                    }
                    
                    cicleCount -= 1;
                    labelCountToEndCicle.Text = "осталось: " + Convert.ToString((int)(cicleCount / 3) + 1);

                } else
                {
                    isCicleOn = false;
                    OffRele2to4();
                    timerCicleOn.Enabled = false;
                    buttonCicleStart.BackColor = Color.Gray;
                    labelCountToEndCicle.Text = "-";
                }
                
            }
        }

        private void timerHeating_Tick(object sender, EventArgs e)
        {
            if (isHearting == true)
            {
                if (timeHeating >= 0)
                {
                    labelTimeHeating.Text = Convert.ToString(timeHeating);
                    timeHeating -= 1; 
                } else
                {
                    ButtonAllEneble(true);
                    isHearting = false;
                    timerHeating.Enabled = false;
                    labelTimeHeating.Text = "-";

                }
            }
        }
    }
}
