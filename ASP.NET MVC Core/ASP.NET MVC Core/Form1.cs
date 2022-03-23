namespace ASP.NET_MVC_Core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private int num0 = 0;
        private int num1 = 1;
        private int num2 = 0;
        public void Fibonacci()
        {
            int sleep = 2000;
            num0 = num0 + num1;
            textBox1.BeginInvoke(new Action(() =>
            {
                textBox1.Text = num0.ToString();
            }));
            Thread.Sleep(sleep);
            while (true)
            {
                num2 = num0 + num1;
                textBox1.BeginInvoke(new Action(() =>
                {
                    textBox1.Text = num0.ToString();
                }));
                
                num0 = num1;
                num1 = num2;
                Thread.Sleep(sleep);
            }
            // ReSharper disable once FunctionNeverReturns
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Thread fibonacci = new Thread(Fibonacci);
            fibonacci.Start();
            button_start.Visible = false;
        }
    }
}