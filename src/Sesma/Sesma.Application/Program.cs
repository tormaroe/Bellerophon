using System;
using System.Threading;

namespace Sesma.Application
{
    static class Program
    {
        private static Thread _HelpThread;
        
        [STAThread]
        static void Main()
        {
            StartHelpServer();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new MainForm());
        }

        public static void Stop()
        {
            StopHelpServer();

            System.Environment.Exit(0);
        }

        private static void StartHelpServer()
        {
            var helpServer = new HelpServer("127.0.0.1", 8123);
            _HelpThread = new Thread(() => helpServer.Start());
            _HelpThread.Start();
        }

        private static void StopHelpServer()
        {
            _HelpThread.Abort();
        }
    }
}
