using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        int dotsecond = 00;
        bool start = false;
        bool record = false;
        public Form1()
        {
            InitializeComponent();
            labelMin.Text = "00";
            labelSecond.Text = "00";
            labeldotSecond.Text = "00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (start == false) //시작
            {
                Timer.Interval = 17;
                Timer.Start();
                Timer.Tick += Timer_Tick;
                start = true;
                record = true;
                btRecord.Text = "기록";
                btStart.Text = "중지";
            }
            else
            {
                Timer.Stop(); //중지
                start = false;
                record = false;
                btRecord.Text = "초기화";
                btStart.Text = "시작";
            }
        }

        private void btRecord_Click(object sender, EventArgs e)
        {
            if (record == true) //기록
            {
                listBox1.Items.Add(labelMin.Text + ":" + labelSecond.Text + "." + labeldotSecond.Text);
            }
            else //초기화
            {
                Timer.Stop();
                start = false;
                listBox1.Items.Clear();
                labelMin.Text = "00";
                labelSecond.Text = "00";
                labeldotSecond.Text = "00";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labeldotSecond.Text = dotsecond.ToString("00");
            dotsecond++;
            if (int.Parse(labeldotSecond.Text) > 99)
            {
                dotsecond = 0;
                labeldotSecond.Text = "00";
                labelSecond.Text = (int.Parse(labelSecond.Text) + 1).ToString("00");
            }
            if(int.Parse(labelSecond.Text) > 59)
            {
                labelSecond.Text = "00";
                labelMin.Text = (int.Parse(labelMin.Text) + 1).ToString("00");
            }
        }
    }
}
