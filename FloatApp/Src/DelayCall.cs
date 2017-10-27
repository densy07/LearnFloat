using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FloatApp
{
    class DelayCall
    {
        public int m_delayMS = 200;

        Task m_curDelayTask;

        CancellationTokenSource m_source;

        public Action m_callback;

        public void Call()
        {
            if (m_curDelayTask != null && m_curDelayTask.IsCompleted)
            {
                Console.WriteLine("Task is completed");
                m_curDelayTask = null;
            }

            if (m_curDelayTask != null)
            {
                Console.WriteLine("Status = " + m_curDelayTask.Status);
            }
            else {
                Console.WriteLine("Status None");
            }

            if (m_curDelayTask != null && m_curDelayTask.Status == TaskStatus.WaitingToRun)
            {
                return;
            }

            if (m_curDelayTask != null)
            {
                Console.WriteLine("dispose");
                m_source.Cancel();

                m_source = null;
                m_curDelayTask = null;
            }

            m_source = new CancellationTokenSource();
            m_curDelayTask = Task.Delay(m_delayMS, m_source.Token);

            m_curDelayTask.ContinueWith((t) =>
            {
                if (t.Status != TaskStatus.RanToCompletion) {
                    return;
                }

                m_curDelayTask = null;
                if (m_callback != null)
                {
                    m_callback.Invoke();
                }
            }) ;
        }
    }
}
