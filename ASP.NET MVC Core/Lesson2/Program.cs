// See https://aka.ms/new-console-template for more information

using Lesson2;

var threadPoolCustom = new ThreadPoolCustom();

for (int i = 0; i < 100; i++)
{
    var threadGenerator = new ThreadGenerator(i);
    threadPoolCustom.AddThread(new Thread(threadGenerator.Start));
}
threadPoolCustom.SetTheNumberOfRunningThreads(4);
threadPoolCustom.StartThreadPoolCustom();
Console.ReadLine();

//    < Window x: Class = "Wpf.MainWindow"
//xmlns = "http://schemas.microsoft.com/winfx/2006/xaml/presentation"
//xmlns: x = "http://schemas.microsoft.com/winfx/2006/xaml"
//xmlns: d = "http://schemas.microsoft.com/expression/blend/2008"
//xmlns: mc = "http://schemas.openxmlformats.org/markup-compatibility/2006"
//xmlns: local = "clr-namespace:Wpf"
//mc: Ignorable = "d"
//Title = "MainWindow" Height = "450" Width = "800" >


//    < Grid >



//    </ Grid >
//    </ Window >