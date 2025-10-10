using System.Timers;

namespace Led_Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            clock.Invoke((MethodInvoker)delegate
            {
                clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
                //clock.SubscriptText = DateTime.Now.ToString("tt");
            });
        }

    }
}
