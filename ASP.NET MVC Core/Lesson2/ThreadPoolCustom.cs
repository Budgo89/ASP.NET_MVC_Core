using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class ThreadPoolCustom
    {
        private List<Thread> _listThread;
        private int _numberOfRunningThreads = 1;
        private List<Thread> _listRunningThreads;

        public ThreadPoolCustom()
        {
            _listThread = new List<Thread>();
            _listRunningThreads = new List<Thread>();
        }
        public void AddThread(Thread thread)
        {
            
            _listThread.Add(thread);
        }

        public void SetTheNumberOfRunningThreads(int numberOfRunningThreads)
        {
            _numberOfRunningThreads = numberOfRunningThreads;
        }

        public int GetTheNumberOfRunningThreads()
        {
            return _numberOfRunningThreads;
        }

        public void StartThreadPoolCustom()
        {
            if (_listThread.Count == 0)
            {
                Console.WriteLine("Потоков нет");
                return;
            }

            try
            {
                while (ThereAreThreadsInTheQueue())
                {
                    CheckingForThreadTermination();
                    if (_listRunningThreads.Count == 0)
                        Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        private void Start()
        {
            var number = _numberOfRunningThreads < _listThread.Count
                ? _numberOfRunningThreads
                : _listThread.Count;
            
            for (int i = 0; i < number; i++)
            {
                _listThread[i].Start();
                _listRunningThreads.Add(_listThread[i]);

            }

            for (int i = 0; i < number; i++)
            {
                _listThread.Remove(_listRunningThreads[i]);
            }
        }

        private void CheckingForThreadTermination()
        {
            if (_listRunningThreads.Count == 0)
                return;

            for (int i = 0; i < _listRunningThreads.Count; i++)
            {
                if (_listRunningThreads[i].IsAlive == false)
                {
                    _listRunningThreads.Remove(_listRunningThreads[i]);
                }
            }

        }

        private bool ThereAreThreadsInTheQueue()
        {
            return _listThread.Count != 0 ? true : false;
        }
    }
}
