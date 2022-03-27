using System.Globalization;

namespace ASP.NET_MVC_Core
{
    public partial class Form1 : Form
    {
        private const double Sec = 1000;
        private int _num0 = 0;
        private int _num1 = 1;
        private int _num2 = 0;
        private int _sleep = 2000;
        private Thread _start;
        private static object lockObject = new object();
        public Form1()
        {
            InitializeComponent();
        }
        
        
        public void Fibonacci(int sleep)
        {
            _num0 += _num1;
            try
            {
                lock (lockObject)
                {
                    textBox_fibonacci.BeginInvoke(new Action(() =>
                    {
                        textBox_fibonacci.Text = _num0.ToString();
                    }));
                }

                var timer = new Thread(() =>
                {
                    Timer(sleep);
                });
                timer.Start();
                Thread.Sleep(sleep);
                while (true)
                {
                    _num2 = _num0 + _num1;
                    lock (lockObject)
                    {
                        textBox_fibonacci.BeginInvoke(new Action(() =>
                        {
                            textBox_fibonacci.Text = _num0.ToString();
                        }));
                    }

                    _num0 = _num1;
                    _num1 = _num2;
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
                            textBox_time.Text = (i / Sec).ToString(specifier, culture);
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
            _start = new Thread(() =>
            {
                Fibonacci(_sleep);
            });
            _start.Start();
            
            button_start.Visible = false;
        }

        private void timer_slide_Scroll(object sender, EventArgs e)
        {
            _start.Interrupt();
            new Thread(() =>
            {
                Slider();
            }).Start();
            _sleep = timer_slide.Value;
            text.Text = _sleep.ToString();
        }

        private void Slider()
        {
            Thread.Sleep(_sleep);
            
            if (_start.IsAlive == false)
            {

                _start = new Thread(() =>
                {
                    Fibonacci(_sleep);
                });
                _start.Start();
            }
        }
    }
}