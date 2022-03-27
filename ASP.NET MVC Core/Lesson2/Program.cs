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

