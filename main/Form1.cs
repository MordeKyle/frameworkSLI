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

namespace main
{
    public partial class Form1 : Form
    {
        int onOff = -1;
        string state = String.Empty;
        SerialPort Comm = new SerialPort("COM8", 9600);
        

        public Form1()
        {
            InitializeComponent();

            

            
            
        }

        private void sendBoth(string left, string right, string gear, string rpm)
        {
            if (Comm.IsOpen == false)
            {
                Comm.Open();
                Comm.WriteLine(left);
                Comm.WriteLine(right);
                Comm.WriteLine(gear);
                Comm.WriteLine(rpm);
                Comm.Close();
            }
            else
            {
                Comm.WriteLine(left);
                Comm.WriteLine(right);
                Comm.WriteLine(gear);
                Comm.WriteLine(rpm);
                Comm.Close();
            }
        }

        private void send(string msg)
        {
            
            if (Comm.IsOpen == false)
            {
                Comm.Open();
                Comm.WriteLine(msg);
                Comm.Close();
            }
            else
            {
                Comm.WriteLine(msg);
                Comm.Close();
            }
        }
        private void sendConstantRpm(string rpm)
        {
            while (rpm == "Eq")
            {
                if (Comm.IsOpen == false)
                {
                    Comm.Open();
                    Comm.WriteLine(rpm);
                    Comm.Close();
                }
                else
                {
                    Comm.WriteLine(rpm);
                    Comm.Close();
                }
            }
        }

        private void onBtn_Click(object sender, EventArgs e)
        {

            state = "LEDON";
            send(state);
            
        }

        private void offBtn_Click(object sender, EventArgs e)
        {
            state = "LEDOFF";
            send(state);
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string text = sendTxt.Text;
            send(text);
        }

        private void bothSendBtn_Click(object sender, EventArgs e)
        {
            string leftHolder = "L" + leftTxt.Text;
            string rightHolder = "R" + rightTxt.Text;
            string gearHolder = "G" + gearTxt.Text;
            string rpmHolder = "E" + rpmTxt.Text;
            sendBoth(leftHolder, rightHolder, gearHolder, rpmHolder);
        }

        private void constantRpmBtn_Click(object sender, EventArgs e)
        {
            string rpmHolder = "E" + constantRpmTxt.Text;
            sendConstantRpm(rpmHolder);
        }

        private void secToMinBtn_Click(object sender, EventArgs e)
        {
            double seconds = double.Parse(secondsTxt.Text);
            if (seconds <= 59.999)
            {
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                string str = time.ToString(@"ss\.fff");
                timeLbl.Text = str;
            }
            else if (seconds <= 599.999)
            {
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                string str = time.ToString(@"m\.ss\.fff");
                timeLbl.Text = str;
            }
            else
            {
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                string str = time.ToString(@"mm\.ss\.fff");
                timeLbl.Text = str;
            }
            
            
        }
    }
}
