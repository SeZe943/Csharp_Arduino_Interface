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

namespace Csharp_Arduino_Interface
{
    public partial class Form1 : Form
    {
        string serialDataIn;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            button_ac.Enabled = true;
            button_kapat.Enabled = false;
            button_send.Enabled = false;
            progressBar_status.Value = 0;
            label_disconnect.Text = "DISCONNECTED";
            label_disconnect.ForeColor = Color.Red;

            comboBox_baud.Text = "9600";
            string[] portlists = SerialPort.GetPortNames();
            comboBox_comport.Items.AddRange(portlists);
        }

        private void button_ac_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_comport.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_baud.Text);
                serialPort1.Open();

                button_ac.Enabled = false;
                button_kapat.Enabled = true;
                button_send.Enabled = true;
                progressBar_status.Value = 100;
                label_disconnect.Text = "CONNECTED";
                label_disconnect.ForeColor = Color.Green;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_kapat_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                    button_ac.Enabled = true;
                    button_kapat.Enabled = false;
                    button_send.Enabled = false;
                    progressBar_status.Value = 0;
                    label_disconnect.Text = "DISCONNECTED";
                    label_disconnect.ForeColor = Color.Red;

                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("<AYARLA" + "," + textBox_send.Text +","+ textBox_send1.Text + "," + textBox_send2.Text + "," + textBox_send3.Text + "," + textBox_send4.Text+">");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            richTextBox_textreceiver.Text += serialDataIn;
        }

        private void richTextBox_textreceiver_TextChanged(object sender, EventArgs e)
        {
            richTextBox_textreceiver.SelectionStart = richTextBox_textreceiver.Text.Length;
            richTextBox_textreceiver.ScrollToCaret();
        }

        private void button_basla_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("<" + "BASLA" + ">");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void button_dur_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("<" + "DUR" + ">");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void button_sifirla_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("<" + "SIFIRLA" + ">");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void button_sol_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("<" + "SOL" + ">");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void button_sag_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("<" + "SAG" + ">");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}
