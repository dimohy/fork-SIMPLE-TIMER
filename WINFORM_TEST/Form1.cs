
namespace WINFORM_TEST
{
    public partial class Form1 : Form
    {
        DateTime clock = new DateTime(0);
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
            clock = clock.AddMilliseconds(100);
            textBox2.Clear();
            textBox2.AppendText($"{clock.Minute.ToString()}:{clock.Second.ToString()}:{clock.Millisecond.ToString()}");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (timer2.Enabled == false)
            {
                timer2.Start();
                button1.Text = "STOP";
            }
            else if (timer1.Enabled == true)
            {
                timer2.Stop();
                button1.Text = "START";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clock = clock.AddTicks(-clock.Ticks);
            textBox2.Clear();
            textBox2.AppendText($"{clock.Minute.ToString()}:{clock.Second.ToString()}:{clock.Millisecond.ToString()}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.AppendText($"{DateTime.Now.ToString()} = {clock.Minute.ToString()}:{clock.Second.ToString()}:{clock.Millisecond.ToString()} {Environment.NewLine}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
    }
}
