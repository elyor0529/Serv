using System;
using System.Timers;
using Demo.Serv;
using Demo.Serv.Infrastructures.Impl;
using Demo.Serv.Repository;

namespace Demo.Cmd
{
    public class TownCrier
    {
        private readonly Timer _timer;

        public TownCrier()
        {
            _timer = new Timer(60 * 1000)
            {
                AutoReset = true
            };
            _timer.Elapsed += TimerOnElapsed;
        }

        private static async void TimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            using (var repo = new TaskRepository())
            {
                var task = await repo.FetchForExecution();

                if (task != null)
                {
                    using (var exec = new ExecutorFactory(repo).GetExecutor(task))
                    {
                        await exec.Run();
                    }
                }

            }
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }
}