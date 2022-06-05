using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class ThreadGenerator
    {
        private int _name;

        public ThreadGenerator(int name)
        {
            _name = name;
        }

        public void Start()
        {
            Console.WriteLine($"Старт потока {_name}");
            Thread.Sleep(500);
            Console.WriteLine($"Поток {_name} завершен");
        }
    }
}
