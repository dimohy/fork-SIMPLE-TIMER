
using System.Diagnostics;

namespace WINFORM_TEST
{
    public partial class Form1 : Form
    {
        //DateTime clock = new DateTime(0);
        Stopwatch clock = new Stopwatch();
        public Form1()
        {

            InitializeComponent();
            //textBox2.AppendText($"{clock.Minute.ToString()}:{clock.Second.ToString()}");


            timer1.Interval = 1000;
            timer1.Start();
            timer2.Interval = 100;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText($"{DateTime.Now.Hour.ToString()}:{DateTime.Now.Minute.ToString()}:{DateTime.Now.Second.ToString()}");

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //clock = clock.AddMilliseconds(100);
            textBox2.Clear();
            //textBox2.AppendText($"{clock.Minute.ToString()}:{clock.Second.ToString()}:{clock.Millisecond.ToString()}");
            var ts = clock.Elapsed;
            textBox2.AppendText($"{ts.Minutes.ToString()}:{ts.Seconds.ToString()}:{ts.Milliseconds.ToString()}");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (timer2.Enabled == false)
            {
                timer2.Start();
                clock.Restart();
                button1.Text = "STOP";
            }
            else if (timer1.Enabled == true)
            {
                timer2.Stop();
                clock.Stop();
                button1.Text = "START";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clock = clock.AddTicks(-clock.Ticks);
            //textBox2.Clear();
            //textBox2.AppendText($"{clock.Minute.ToString()}:{clock.Second.ToString()}:{clock.Millisecond.ToString()}");
            clock.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox3.AppendText($"{DateTime.Now.ToString()} = {clock.Minute.ToString()}:{clock.Second.ToString()}:{clock.Millisecond.ToString()} {Environment.NewLine}");
            var ts = clock.Elapsed;
            textBox3.AppendText($"{DateTime.Now.ToString()} = {ts.Minutes.ToString()}:{ts.Seconds.ToString()}:{ts.Milliseconds.ToString()} {Environment.NewLine}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
    }
}
