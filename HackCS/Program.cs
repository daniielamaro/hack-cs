using System.Diagnostics;

namespace HackCS
{

    internal static class Program
    {
        public static bool VidaInfinita { get; set; }
        public static bool MunicaoInfinita { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            VidaInfinita = false;
            Task.Run(() => Process());
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        async static Task Process()
        {
            Hack hack = new();
            while (true)
            {
                Thread.Sleep(100);
                if (VidaInfinita) await hack.VidaInfinita();
                if (MunicaoInfinita) await hack.MunicaoInfinita();
            }
        }
    }
}