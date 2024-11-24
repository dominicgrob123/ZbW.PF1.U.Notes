using MB03.A8_2;
using MB03.Aufgaben;

namespace MB03
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new A8_2_1());
            Application.Run(new CmdCalculate());
            //Application.Run(new A6_2_1());
            //Application.Run(new A6_2_2());
            //Application.Run(new A6_2_3());
            //Application.Run(new A6_2_4());

        }
    }
}