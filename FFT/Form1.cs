using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace serialPort
{
    public partial class Form1 : Form
    {

        Queue SerialBuff = new Queue(500);
        int command_available;

        int[] amplitude = new int[32];
        int[] freq = new int[32];

        Thread th1;


        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
            th1 = new Thread(thread1_method);
            th1.Start();
            th1.Suspend();

        }

        ~Form1()
        {
            serialPort1.Close();
        }

        public void thread1_method()
        {

            int i = 0;

            while (true)
            {

                char temp;
                string wynik="";

                while (true)
                {
                    temp = Convert.ToChar(SerialBuff.Dequeue());
                    if (temp == '\n')
                        break;

                    wynik += temp;          

                }
                i++;
                label3.Text = i.ToString() + ": " + wynik;
                command(wynik);
                wynik = "";
                command_available--;
                if (command_available == 0)
                    th1.Suspend();



            }

        }

        void command ( string s)
        {
            string[] asd;
            string[] xyz;
            asd = s.Split('=');
            if (asd[0] == "DATA")
            {
                xyz = asd[1].Split(',');

                for (int i = 0; i < xyz.Length; i++)
                {
                    amplitude[i] = Convert.ToInt32(xyz[i]);
                }

                chart.Series["Series1"].Points.DataBindXY(freq, amplitude);
            }

        }

        void get_availablePorts( )
        {
            String[] availablePorts = SerialPort.GetPortNames();
            com_comboBox.Items.AddRange(availablePorts);
            
        }

        private void findports_button_MouseClick(object sender, MouseEventArgs e)
        {
            get_availablePorts();
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                connect_button.Text = "Connect";

            }
            else
            {
                try {
                    if (com_comboBox.Text != "" && baudrate_Box.Text != "")
                    {
                        serialPort1.PortName = com_comboBox.Text;
                        serialPort1.BaudRate = Convert.ToInt32(baudrate_Box.Text);
                        serialPort1.Open();
                        connect_button.Text = "Disconnect";
                    }
                    else
                    {

                    }
                }
                catch(UnauthorizedAccessException)
                {

                }
            }

        }

        private void write_button_Click(object sender, EventArgs e)
        {
            serialPort1.Write(write_textBox.Text);
            serialPort1.Write("\r");
        }

        private void read_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("AT+RD");
                serialPort1.Write("\r");
                read_textBox.Text = serialPort1.ReadLine();
            }
            catch(TimeoutException)
            {

            }
            
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            char temp;
            while (serialPort1.BytesToRead != 0)
            {
                temp = Convert.ToChar(serialPort1.ReadByte());
                SerialBuff.Enqueue(temp);

                if (temp == '\n')
                {
                    command_available++;
                    th1.Resume();
                }
            }

        }

    }

}
