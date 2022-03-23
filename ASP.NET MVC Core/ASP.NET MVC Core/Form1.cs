using System.Globalization;

namespace ASP.NET_MVC_Core
{
    public partial class Form1 : Form
    {
        const double sec = 1000;
        public Form1()
        {
            InitializeComponent();
        }
        
        private int num0 = 0;
        private int num1 = 1;
        private int num2 = 0;
        public void Fibonacci(int sleep)
        {
            num0 += num1;
            try
            {
                textBox_fibonacci.BeginInvoke(new Action(() =>
                {
                    textBox_fibonacci.Text = num0.ToString();
                }));
                var timer = new Thread(() =>
                {
                    Timer(sleep);
                });
                timer.Start();
                Thread.Sleep(sleep);
                while (true)
                {
                    num2 = num0 + num1;
                    textBox_fibonacci.BeginInvoke(new Action(() =>
                    {
                        textBox_fibonacci.Text = num0.ToString();
                    }));

                    num0 = num1;
                    num1 = num2;
                    timer = new Thread(() =>
                    {
                        Timer(sleep);
                    });
                    timer.Start();
                    Thread.Sleep(sleep);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            // ReSharper disable once FunctionNeverReturns
        }

        public void Timer(int timer)
        {
            int sleep = 200;
            var specifier = "G";
            var culture = CultureInfo.CreateSpecificCulture("eu-ES");
            try
            {
                for (double i = timer; i >= 0;)
                {
                    textBox_time.BeginInvoke(new Action(() =>
                    {
                        if (i >= 0)
                            textBox_time.Text = (i / sec).ToString(specifier, culture);
                    }));
                    i -= sleep;
                    Thread.Sleep(sleep);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        private void button_start_Click(object sender, EventArgs e)
        {
            var sleep = 2000;
            new Thread(() =>
            {
                Fibonacci(sleep);
            }).Start();
            
            button_start.Visible = false;
        }
    }
}