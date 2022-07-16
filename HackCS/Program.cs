using System.Diagnostics;

namespace HackCS
{

    internal static class Program
    {
        public static bool VidaInfinita { get; set; }
        public static bool ColeteInfinito { get; set; }
        public static bool MunicaoInfinita { get; set; }
        public static bool NoRecoil { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            VidaInfinita = false;
            MunicaoInfinita = false;
            ColeteInfinito = false;
            NoRecoil = false;

            Task.Run(() => Process());

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        async static Task Process()
        {
            Hack hack = new();
            while (true)
            {
                if (VidaInfinita) await hack.VidaInfinita();
                if (MunicaoInfinita) await hack.MunicaoInfinita();
                if (ColeteInfinito) await hack.ColeteInfinito();
                if (NoRecoil) await hack.NoRecoil();
                Thread.Sleep(100);
            }
        }
    }
}